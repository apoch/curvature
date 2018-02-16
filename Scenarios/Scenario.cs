using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Scenario : INameable, IInputBroker
    {
        public interface IScenarioMember
        {
            string GetName();
            PointF GetPosition();
            object GetProperty(KnowledgeBase.Record kbrec);
            float GetRadius();
        }

        public class Score
        {
            public double InputRawValue;
            public double InputValue;
            public double FinalScore;
        }

        public class ConsiderationScores
        {
            public Dictionary<Consideration, Score> Considerations;
            public double InitialWeight;
            public double FinalScore;

            public override string ToString()
            {
                string ret = $"Initial weight: {InitialWeight:f3}\r\nFinal score: {FinalScore:f3}\r\n\r\n";
                foreach (var pair in Considerations)
                {
                    ret += $"{pair.Key.ReadableName}\r\nInput \"{pair.Key.Input.ReadableName}\"\r\n";
                    ret += $"    Raw input: {pair.Value.InputRawValue:f3}\r\n";
                    ret += $"    Normalized input: { pair.Value.InputValue:f3}\r\n";
                    ret += $"    Response curve score: {pair.Value.FinalScore:f3}\r\n\r\n";
                }

                return ret;
            }
        }

        public class Context
        {
            public ScenarioAgent ThinkingAgent;
            public IScenarioMember Target;
            public Behavior ChosenBehavior;
            public ConsiderationScores BehaviorScore;

            public override string ToString()
            {
                return $"Target: {Target.GetName()}\r\nBehavior: {ChosenBehavior} [{ChosenBehavior.Action}]\r\n{BehaviorScore}";
            }
        }

        public class InspectionText
        {
            public string Caption;
            public string Description;
            public ToolTipIcon Icon;
        }

        [DataMember]
        public string ReadableName;

        [DataMember]
        public List<ScenarioAgent> Agents;

        [DataMember]
        public List<ScenarioLocation> Locations;

        private Pen RenderPenDottedBlack;
        private float HorizontalUnitsVisible = 2.0f;
        private float VerticalUnitsVisible = 2.0f;

        private float HorizontalUnitsOffset = 0.5f;
        private float VerticalUnitsOffset = 0.5f;

        private Random RandomNumbers = new Random();

        private HashSet<ScenarioAgent> AgentsActiveThisTick;
        private Dictionary<ScenarioAgent, DecisionHistory> AgentDecisions;
        private List<Context> CustomActions;


        private double SimulationTime = 0.0;


        public class DecisionHistory
        {
            public List<Context> ScoredContexts;
            public Context WinningContext;
        }

        internal class ScenarioEventArgs : EventArgs
        {
            internal float DeltaTime;
            internal Dictionary<ScenarioAgent, DecisionHistory> AgentDecisions;
        }

        internal delegate void ScenarioEventHandler(object sender, ScenarioEventArgs args);
        internal event ScenarioEventHandler SimulationAdvance;

        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public Scenario(string name)
        {
            ReadableName = name;

            Agents = new List<ScenarioAgent>();
            Locations = new List<ScenarioLocation>();

            InitializeDrawingResources();
        }

        public void ReseedRandoms(int seed)
        {
            RandomNumbers = new Random(seed);
        }

        public void ReseedRandoms()
        {
            RandomNumbers = new Random();
        }

        public void ResetAgents(KnowledgeBase kb)
        {
            SimulationTime = 0.0;
            foreach (var agent in Agents)
            {
                agent.MoveToStartPosition(RandomNumbers);

                agent.GenerateStartProperties(kb);
                agent.Properties = new Dictionary<KnowledgeBase.Record, object>();
                foreach (var kvp in agent.StartProperties)
                    agent.Properties.Add(kvp.Key, kvp.Value);
            }

            foreach (var location in Locations)
            {
                location.GenerateStartProperties(kb);
                location.Properties = new Dictionary<KnowledgeBase.Record, object>();
                foreach (var kvp in location.StartProperties)
                    location.Properties.Add(kvp.Key, kvp.Value);
            }
        }

        public void Advance(float dt)
        {
            AgentDecisions = new Dictionary<ScenarioAgent, DecisionHistory>();
            AgentsActiveThisTick = new HashSet<ScenarioAgent>();
            CustomActions = null;

            List<IScenarioMember> targets = new List<IScenarioMember>();
            targets.AddRange(Agents);
            targets.AddRange(Locations);

            foreach (var agent in Agents)
            {
                var decisionhistory = new DecisionHistory();
                decisionhistory.ScoredContexts = new List<Context>();

                var context = agent.ChooseBehavior(this, targets, decisionhistory);
                if (context != null)
                    ExecuteBehaviorOnAgent(context, dt);
                else
                    agent.Stalled = true;

                decisionhistory.WinningContext = context;
                AgentDecisions.Add(agent, decisionhistory);
            }

            SimulationAdvance(this, new ScenarioEventArgs { DeltaTime = dt, AgentDecisions = AgentDecisions });
            SimulationTime += dt;
        }


        public void Render(Graphics graphics, Rectangle rect)
        {
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Set up scaling
            PointF minCoordinate;
            PointF maxCoordinate;

            if (Agents.Count > 0)
            {
                minCoordinate = new PointF(1e6f, 1e6f);
                maxCoordinate = new PointF(-1e6f, -1e6f);

                foreach (var agent in Agents)
                {
                    var minpos = agent.GetPosition();
                    minpos.X -= (agent.Radius * 2.5f);
                    minpos.Y -= (agent.Radius * 2.5f);

                    var maxpos = agent.GetPosition();
                    maxpos.X += (agent.Radius * 2.5f);
                    maxpos.Y += (agent.Radius * 2.5f);

                    minCoordinate.X = Math.Min(minCoordinate.X, minpos.X);
                    minCoordinate.Y = Math.Min(minCoordinate.Y, minpos.Y);

                    maxCoordinate.X = Math.Max(maxCoordinate.X, maxpos.X);
                    maxCoordinate.Y = Math.Max(maxCoordinate.Y, maxpos.Y);
                }

                foreach (var loc in Locations)
                {
                    var minpos = loc.GetPosition();
                    minpos.X -= (loc.Radius * 1.5f);
                    minpos.Y -= (loc.Radius * 1.5f);

                    var maxpos = loc.GetPosition();
                    maxpos.X += (loc.Radius * 1.5f);
                    maxpos.Y += (loc.Radius * 1.5f);

                    minCoordinate.X = Math.Min(minCoordinate.X, minpos.X);
                    minCoordinate.Y = Math.Min(minCoordinate.Y, minpos.Y);

                    maxCoordinate.X = Math.Max(maxCoordinate.X, maxpos.X);
                    maxCoordinate.Y = Math.Max(maxCoordinate.Y, maxpos.Y);
                }
            }
            else
            {
                 minCoordinate = new PointF(1.0f, 1.0f);
                 maxCoordinate = new PointF(-1.0f, -1.0f);
            }

            HorizontalUnitsVisible = Math.Max(2.0f, (maxCoordinate.X - minCoordinate.X));
            VerticalUnitsVisible = Math.Max(2.0f, (maxCoordinate.Y - minCoordinate.Y));

            HorizontalUnitsOffset = -minCoordinate.X;
            VerticalUnitsOffset = -minCoordinate.Y;

            // Backplot and axes
            graphics.FillRectangle(Brushes.White, rect);
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(minCoordinate.X, 0.0f, rect), CoordinatesToDisplayPoint(maxCoordinate.X, 0.0f, rect));
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(0.0f, minCoordinate.Y, rect), CoordinatesToDisplayPoint(0.0f, maxCoordinate.Y, rect));

            // Locations
            foreach (var loc in Locations)
            {
                var displayRect = ToDisplayRect(loc, rect);
                graphics.FillEllipse(Brushes.Gray, displayRect);

                int pad = 20;
                var textRect = new Rectangle(displayRect.Left - pad, displayRect.Top + displayRect.Height + 5, displayRect.Width + pad * 2, pad + 5);
                graphics.DrawString(loc.GetName(), SystemFonts.IconTitleFont, Brushes.DarkGreen, textRect, stringFormat);
            }

            // Agents
            foreach (var agent in Agents)
            {
                var displayRect = ToDisplayRect(agent, rect);
                if (agent.Stalled)
                    graphics.DrawRectangle(Pens.Red, displayRect);


                using (var pen = new Pen(agent.Color))
                {
                    graphics.DrawEllipse(pen, displayRect);
                }


                // Intention indicator
                if (agent.Intent != null)
                {
                    var intentVec = new PointF() { X = agent.GetPosition().X - agent.Intent.GetPosition().X, Y = agent.GetPosition().Y - agent.Intent.GetPosition().Y };
                    var intentLength = Magnitude(intentVec);

                    if (intentLength > 0.05f)
                    {
                        intentVec.X /= intentLength;
                        intentVec.Y /= intentLength;

                        if (!agent.IntentAttractive)
                        {
                            intentVec.X = -intentVec.X;
                            intentVec.Y = -intentVec.Y;
                        }

                        var tip = CoordinatesToDisplayPoint(agent.GetPosition().X - intentVec.X * agent.Radius, agent.GetPosition().Y - intentVec.Y * agent.Radius, rect);
                        var bottomCenter = new PointF(agent.GetPosition().X + intentVec.X * agent.Radius, agent.GetPosition().Y + intentVec.Y * agent.Radius);

                        var intentOrthogonalVec = Normalize(new PointF(-intentVec.Y, intentVec.X));

                        var bottomL = CoordinatesToDisplayPoint(bottomCenter.X - intentOrthogonalVec.X * agent.Radius * 0.3f, bottomCenter.Y - intentOrthogonalVec.Y * agent.Radius * 0.3f, rect);
                        var bottomR = CoordinatesToDisplayPoint(bottomCenter.X + intentOrthogonalVec.X * agent.Radius * 0.3f, bottomCenter.Y + intentOrthogonalVec.Y * agent.Radius * 0.3f, rect);

                        var bcExtended = new PointF(agent.GetPosition().X + intentVec.X * agent.Radius * 1.2f, agent.GetPosition().Y + intentVec.Y * agent.Radius * 1.2f);
                        var bc = CoordinatesToDisplayPoint(bcExtended.X, bcExtended.Y, rect);

                        Color darker = GetDarkerColor(agent.Color);
                        Color lighter = GetLighterColor(agent.Color);

                        using (var gradient = new LinearGradientBrush(tip, bc, lighter, darker))
                        {
                            var poly = new Point[] { tip, bottomL, bottomR, tip };

                            graphics.DrawLines(Pens.Black, poly);
                            graphics.FillPolygon(gradient, poly);

                            using (var dashPen = new Pen(agent.Color))
                            {
                                var agentCenter = CoordinatesToDisplayPoint(agent.GetPosition().X, agent.GetPosition().Y, rect);

                                dashPen.DashStyle = DashStyle.Dash;
                                graphics.DrawLine(dashPen, agentCenter, CoordinatesToDisplayPoint(agent.Intent.GetPosition().X, agent.Intent.GetPosition().Y, rect));
                            }
                        }
                    }
                }
                else
                {
                    using (var ellipse = new GraphicsPath())
                    {
                        var insetRect = ToDisplayRect(agent, rect, 0.35f);
                        ellipse.AddEllipse(insetRect);

                        using (var gradient = new PathGradientBrush(ellipse))
                        {
                            gradient.CenterColor = GetDarkerColor(agent.Color);
                            gradient.SurroundColors = new[] { GetLighterColor(agent.Color) };

                            graphics.FillRectangle(gradient, insetRect);
                        }
                    }
                }


                int pad = 20;
                var textRect = new Rectangle(displayRect.Left - pad, displayRect.Top - pad, displayRect.Width + pad * 2, displayRect.Height + pad * 2);
                graphics.DrawString(agent.GetName(), SystemFonts.IconTitleFont, Brushes.DarkRed, textRect, stringFormat);

                textRect.Offset(-1, -1);
                graphics.DrawString(agent.GetName(), SystemFonts.IconTitleFont, Brushes.Black, textRect, stringFormat);
            }

            // Custom action balloons
            if (CustomActions != null)
            {
                foreach (var ctx in CustomActions)
                {
                    if (ctx.Target != null)
                    {
                        var targetCenter = CoordinatesToDisplayPoint(ctx.Target.GetPosition().X, ctx.Target.GetPosition().Y, rect);
                        var agentCenter = CoordinatesToDisplayPoint(ctx.ThinkingAgent.GetPosition().X, ctx.ThinkingAgent.GetPosition().Y, rect);
                        graphics.DrawLine(Pens.Blue, targetCenter, agentCenter);

                        var midpoint = new Point((agentCenter.X + targetCenter.X) / 2, (agentCenter.Y + targetCenter.Y) / 2);
                        var textRect = new Rectangle(midpoint.X - 60, midpoint.Y - 15, 120, 30);
                        graphics.DrawString(ctx.ChosenBehavior.Payload, SystemFonts.IconTitleFont, Brushes.Blue, textRect, stringFormat);
                    }
                    else
                    {
                        int pad = 20;
                        var displayRect = ToDisplayRect(ctx.ThinkingAgent, rect);
                        var textRect = new Rectangle(displayRect.Left - pad, displayRect.Top - pad, displayRect.Width + pad * 2, pad * 3);
                        graphics.DrawString(ctx.ChosenBehavior.Payload, SystemFonts.IconTitleFont, Brushes.Blue, textRect, stringFormat);
                    }
                }
            }

            stringFormat.Dispose();
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
            DialogRebuildNeeded?.Invoke();
        }

        public string GetName()
        {
            return ReadableName;
        }

        public void RefreshInputs()
        {
        }

        public double GetInputValue(Consideration consideration)
        {
            return 0.0;
        }

        public double GetInputValue(Consideration consideration, Context context)
        {
            double raw = 0.0;
            if (consideration == null || consideration.Input == null)
                return raw;

            switch (consideration.Input.Origin)
            {
                case InputAxis.OriginType.ComputedValue:
                    switch (consideration.Input.KBRec.Prefab)
                    {
                        case KnowledgeBase.Record.Prefabs.Distance:
                            raw = Distance(context.ThinkingAgent.GetPosition(), context.Target.GetPosition());
                            break;

                        case KnowledgeBase.Record.Prefabs.SimulationTime:
                            raw = SimulationTime;
                            break;

                        default:
                            return raw;
                    }
                    break;

                case InputAxis.OriginType.PropertyOfSelf:
                    if (consideration.Input.KBRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
                    {
                        int comparison = string.Compare((consideration.ParameterValues[0] as InputParameterValueEnumeration).Key, (string)context.ThinkingAgent.GetProperty(consideration.Input.KBRec));

                        if ((consideration.Input.Parameters[0] as InputParameterEnumeration).ScoreOnMatch)
                        {
                            if (comparison == 0)
                                return 1.0;

                            return 0.0;
                        }
                        else
                        {
                            if (comparison != 0)
                                return 1.0;

                            return 0.0;
                        }
                    }
                    else
                        raw = (double)context.ThinkingAgent.GetProperty(consideration.Input.KBRec);

                    break;

                case InputAxis.OriginType.PropertyOfTarget:
                    if (consideration.Input.KBRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
                    {
                        int comparison = string.Compare((consideration.ParameterValues[0] as InputParameterValueEnumeration).Key, (string)context.Target.GetProperty(consideration.Input.KBRec));

                        if ((consideration.Input.Parameters[0] as InputParameterEnumeration).ScoreOnMatch)
                        {
                            if (comparison == 0)
                                return 1.0;

                            return 0.0;
                        }
                        else
                        {
                            if (comparison != 0)
                                return 1.0;

                            return 0.0;
                        }
                    }
                    else
                        raw = (double)context.Target.GetProperty(consideration.Input.KBRec);
                    break;
            }

            return raw;
        }


        private void ExecuteBehaviorOnAgent(Context context, float dt)
        {
            const float speed = 1.0f;

            context.ThinkingAgent.Stalled = false;
            context.ThinkingAgent.Intent = context.Target;
            context.ThinkingAgent.IntentAttractive = true;

            switch (context.ChosenBehavior.Action)
            {
                case Behavior.ActionType.Idle:
                    break;

                case Behavior.ActionType.MoveAwayFromTarget:
                    if (context.Target != null)
                    {
                        var pos = context.ThinkingAgent.Position;
                        var vec = ComputeVectorTowardsTarget(context);
                        context.ThinkingAgent.Position.X = ClampToEscape(pos.X, context.Target.GetPosition().X, pos.X - (speed * dt * vec.X));
                        context.ThinkingAgent.Position.Y = ClampToEscape(pos.Y, context.Target.GetPosition().Y, pos.Y - (speed * dt * vec.Y));

                        context.ThinkingAgent.IntentAttractive = false;
                    }
                    break;

                case Behavior.ActionType.MoveToTarget:
                    if (context.Target != null)
                    {
                        var pos = context.ThinkingAgent.Position;
                        var vec = ComputeVectorTowardsTarget(context);
                        context.ThinkingAgent.Position.X = ClampToArrival(pos.X, context.Target.GetPosition().X, pos.X + (speed * dt * vec.X));
                        context.ThinkingAgent.Position.Y = ClampToArrival(pos.Y, context.Target.GetPosition().Y, pos.Y + (speed * dt * vec.Y));
                    }
                    break;

                case Behavior.ActionType.Talk:
                    if (CustomActions == null)
                        CustomActions = new List<Context>();

                    CustomActions.Add(context);
                    break;

                case Behavior.ActionType.Custom:
                    if (CustomActions == null)
                        CustomActions = new List<Context>();

                    CustomActions.Add(context);
                    break;
            }
        }

        private PointF DisplayPointToCoordinates(Point display, Rectangle viewrect)
        {
            float x = (float)display.X / (float)viewrect.Width;
            float y = 1.0f - (float)display.Y / (float)viewrect.Height;

            x *= HorizontalUnitsVisible;
            y *= VerticalUnitsVisible;

            x -= HorizontalUnitsOffset;
            y -= VerticalUnitsOffset;

            return new PointF(x, y);
        }


        private Point CoordinatesToDisplayPoint(float x, float y, Rectangle rect)
        {
            x += HorizontalUnitsOffset;
            y += VerticalUnitsOffset;

            x /= HorizontalUnitsVisible;
            y /= VerticalUnitsVisible;

            return new Point((int)(x * (float)rect.Width), rect.Height - (int)(y * (float)rect.Height));
        }

        private Rectangle ToDisplayRect(IScenarioMember obj, Rectangle rect, float scaleRadius = 1.0f)
        {
            PointF center = obj.GetPosition();
            Point centerRender = CoordinatesToDisplayPoint(center.X, center.Y, rect);

            int width = (int)((float)rect.Width * obj.GetRadius() * scaleRadius / (HorizontalUnitsVisible / 2.0f));
            int height = (int)((float)rect.Height * obj.GetRadius() * scaleRadius / (VerticalUnitsVisible / 2.0f));

            return new Rectangle(centerRender.X - (width / 2), centerRender.Y - (height / 2), width, height);
        }

        private PointF ComputeVectorTowardsTarget(Context context)
        {
            PointF targetPoint = context.Target.GetPosition();
            float dx = targetPoint.X - context.ThinkingAgent.Position.X;
            float dy = targetPoint.Y - context.ThinkingAgent.Position.Y;

            var normal = Normalize(new PointF(dx, dy));
            return normal;
        }

        private PointF Normalize(PointF input)
        {
            float length = (float)Math.Sqrt(input.X * input.X + input.Y * input.Y);
            if (length < 0.001f)
                return new PointF(0.0f, 0.0f);

            float invlength = 1.0f / length;
            return new PointF(input.X * invlength, input.Y * invlength);
        }

        private float ClampToArrival(float start, float limit, float desired)
        {
            if (start <= limit)
            {
                if (desired > limit)
                    return limit;

                return desired;
            }
            else
            {
                if (desired < limit)
                    return limit;

                return desired;
            }
        }

        private float ClampToEscape(float start, float limit, float desired)
        {
            if (start <= limit)
            {
                if (desired > limit)
                    return limit;

                return desired + 0.04f - ((float)RandomNumbers.NextDouble() * 0.08f);
            }
            else
            {
                if (desired < limit)
                    return limit;

                return desired + 0.04f - ((float)RandomNumbers.NextDouble() * 0.08f);
            }
        }

        private float Distance(PointF a, PointF b)
        {
            float dx = b.X - a.X;
            float dy = b.Y - a.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private float Magnitude(PointF p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            InitializeDrawingResources();
            RandomNumbers = new Random();
        }


        private void InitializeDrawingResources()
        {
            RenderPenDottedBlack = new Pen(Color.Black, 1.0f);
            RenderPenDottedBlack.DashStyle = DashStyle.Dot;
        }


        private bool HitTest(IScenarioMember member, PointF simpt)
        {
            var simposition = member.GetPosition();

            float dx = simpt.X - simposition.X;
            float dy = simpt.Y - simposition.Y;

            float distanceSq = dx * dx + dy * dy;

            return (distanceSq <= member.GetRadius() * member.GetRadius());
        }


        public InspectionText GetInspectionText(Rectangle rect, Point pt)
        {
            var simpt = DisplayPointToCoordinates(pt, rect);

            foreach (var agent in Agents)
            {
                if (HitTest(agent, simpt))
                {
                    ToolTipIcon icon = ToolTipIcon.Warning;
                    string positiontext = $"{agent.GetPosition()} R:{agent.GetRadius()}";

                    string decisiontext = "[Stalled]";
                    if (AgentDecisions != null && AgentDecisions.ContainsKey(agent))
                    {
                        if (AgentDecisions[agent].WinningContext != null)
                        {
                            decisiontext = AgentDecisions[agent].WinningContext.ToString();
                            icon = ToolTipIcon.Info;
                        }
                    }

                    return new InspectionText { Caption = $"Agent: {agent.GetName()}", Description = $"{positiontext}\r\n{decisiontext}", Icon = icon };
                }
            }

            foreach (var loc in Locations)
            {
                if (HitTest(loc, simpt))
                {
                    string positiontext = $"{loc.GetPosition()} R:{loc.GetRadius()}";
                    return new InspectionText { Caption = $"Location: {loc.GetName()}", Description = $"{positiontext}", Icon = ToolTipIcon.Info };
                }
            }

            return null;
        }


        public ScenarioAgent GetAgentAtLocation(Rectangle rect, Point pt)
        {
            var simpt = DisplayPointToCoordinates(pt, rect);
            foreach (var agent in Agents)
            {
                if (HitTest(agent, simpt))
                    return agent;
            }

            return null;
        }


        private Color GetDarkerColor (Color c)
        {
            return ControlPaint.Dark(c, 0.25f);
        }

        private Color GetLighterColor (Color c)
        {
            return ControlPaint.Light(c, 0.25f);
        }
    }
}
