using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Scenario : IInputBroker
    {
        public interface IScenarioMember
        {
            string GetName();
            PointF GetPosition();
            double GetProperty(string name);
        }

        public class Context
        {
            public ScenarioAgent ThinkingAgent;
            public IScenarioMember Target;
            public Behavior ChosenBehavior;
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


        public Scenario(string name)
        {
            ReadableName = name;

            Agents = new List<ScenarioAgent>();
            Locations = new List<ScenarioLocation>();

            RenderPenDottedBlack = new Pen(Color.Black, 1.0f);
            RenderPenDottedBlack.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        public void Advance(float dt)
        {
            List<IScenarioMember> targets = new List<IScenarioMember>();
            targets.AddRange(Agents);
            targets.AddRange(Locations);

            foreach (var agent in Agents)
            {
                var context = agent.ChooseBehavior(this, targets);
                if (context != null)
                    ExecuteBehaviorOnAgent(context, dt);
                else
                    SignalStallOnAgent(agent);
            }
        }


        public void Render(Graphics graphics, Rectangle rect)
        {
            // Set up scaling
            var minCoordinate = new PointF(1e6f, 1e6f);
            var maxCoordinate = new PointF(-1e6f, -1e6f);

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

            HorizontalUnitsVisible = Math.Max(2.0f, (maxCoordinate.X - minCoordinate.X));
            VerticalUnitsVisible = Math.Max(2.0f, (maxCoordinate.Y - minCoordinate.Y));

            HorizontalUnitsOffset = -minCoordinate.X;
            VerticalUnitsOffset = -minCoordinate.Y;

            // Backplot and axes
            graphics.FillRectangle(Brushes.White, rect);
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(minCoordinate.X, 0.0f, rect), CoordinatesToDisplayPoint(maxCoordinate.X, 0.0f, rect));
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(0.0f, minCoordinate.Y, rect), CoordinatesToDisplayPoint(0.0f, maxCoordinate.Y, rect));

            // Agents
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            foreach (var agent in Agents)
            {
                var displayRect = AgentToDisplayRect(agent, rect);
                graphics.FillEllipse(Brushes.Black, displayRect);

                if (agent.Stalled)
                    graphics.DrawRectangle(Pens.Red, displayRect);

                int pad = 20;
                var textRect = new Rectangle(displayRect.Left - pad, displayRect.Top - pad, displayRect.Width + pad * 2, displayRect.Height + pad * 2);
                graphics.DrawString(agent.GetName(), SystemFonts.IconTitleFont, Brushes.Red, textRect, stringFormat);
            }
        }

        public void RefreshInputs()
        {
        }

        public double GetInputValue(InputAxis axis)
        {
            return 0.0;
        }

        public double GetInputValue(InputAxis axis, Context context)
        {
            double raw = 0.0;

            switch (axis.Origin)
            {
                case InputAxis.OriginType.ComputedValue:
                    // TODO - compute stuff that isn't distance
                    raw = Distance(context.ThinkingAgent.GetPosition(), context.Target.GetPosition());
                    break;

                case InputAxis.OriginType.PropertyOfSelf:
                    raw = context.ThinkingAgent.GetProperty(axis.KBRecord.ReadableName);
                    break;

                case InputAxis.OriginType.PropertyOfTarget:
                    raw = context.Target.GetProperty(axis.KBRecord.ReadableName);
                    break;
            }

            if (raw < axis.KBRecord.MinimumValue)
                raw = axis.KBRecord.MinimumValue;

            if (raw > axis.KBRecord.MaximumValue)
                raw = axis.KBRecord.MaximumValue;

            return raw;
        }


        private void ExecuteBehaviorOnAgent(Context context, float dt)
        {
            const float speed = 0.4f;

            context.ThinkingAgent.Stalled = false;

            switch (context.ChosenBehavior.Action)
            {
                case Behavior.ActionType.Idle:
                    break;

                case Behavior.ActionType.MoveAwayFromTarget:
                    if (context.Target != null)
                    {
                        var pos = context.ThinkingAgent.Position;
                        var vec = ComputeVectorTowardsTarget(context);
                        context.ThinkingAgent.Position.X = ClampToArrival(pos.X, context.Target.GetPosition().X, pos.X - (speed * dt * vec.X));
                        context.ThinkingAgent.Position.Y = ClampToArrival(pos.Y, context.Target.GetPosition().Y, pos.Y - (speed * dt * vec.Y));
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
                    break;

                case Behavior.ActionType.Custom:
                    break;
            }
        }

        private void SignalStallOnAgent(ScenarioAgent agent)
        {
            agent.Stalled = true;
        }


        private Point CoordinatesToDisplayPoint(float x, float y, Rectangle rect)
        {
            x += HorizontalUnitsOffset;
            y += VerticalUnitsOffset;

            x /= HorizontalUnitsVisible;
            y /= VerticalUnitsVisible;

            return new Point((int)(x * (float)rect.Width), (int)(y * (float)rect.Height));
        }

        private Rectangle AgentToDisplayRect(ScenarioAgent agent, Rectangle rect)
        {
            PointF center = agent.GetPosition();
            Point centerRender = CoordinatesToDisplayPoint(center.X, center.Y, rect);

            int width = (int)((float)rect.Width * agent.Radius / (HorizontalUnitsVisible));
            int height = (int)((float)rect.Height * agent.Radius / (VerticalUnitsVisible));

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

        private float Distance(PointF a, PointF b)
        {
            float dx = b.X - a.X;
            float dy = b.Y - a.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
