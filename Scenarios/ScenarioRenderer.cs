using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Curvature.Scenarios.ScenarioMath;

namespace Curvature.Scenarios
{
    class ScenarioRenderer
    {
        public class InspectionText
        {
            public string Caption;
            public string Description;
            public ToolTipIcon Icon;
        }

        private float HorizontalUnitsVisible = 2.0f;
        private float VerticalUnitsVisible = 2.0f;

        private float HorizontalUnitsOffset = 0.5f;
        private float VerticalUnitsOffset = 0.5f;

        private Pen RenderPenDottedBlack;

        private StringFormat MyStringFormat;

        public ScenarioRenderer()
        {
            RenderPenDottedBlack = new Pen(Color.Black, 1.0f)
            {
                DashStyle = DashStyle.Dot
            };

            MyStringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }


        public void Render(Scenario scenario, Graphics graphics, Rectangle rect)
        {
            // Set up scaling
            ComputeVisibleBounds(scenario, out PointF minCoordinate, out PointF maxCoordinate);

            HorizontalUnitsVisible = Math.Max(2.0f, (maxCoordinate.X - minCoordinate.X));
            VerticalUnitsVisible = Math.Max(2.0f, (maxCoordinate.Y - minCoordinate.Y));

            HorizontalUnitsOffset = -minCoordinate.X;
            VerticalUnitsOffset = -minCoordinate.Y;

            // Backplot and axes
            DrawBackgroundObjects(graphics, rect, minCoordinate, maxCoordinate);

            // Locations
            DrawLocations(scenario, graphics, rect);


            // TODO - finish cleaning up this code (#55)

            // Agents
            foreach (var agent in scenario.Agents)
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
                graphics.DrawString(agent.GetName(), SystemFonts.IconTitleFont, Brushes.DarkRed, textRect, MyStringFormat);

                textRect.Offset(-1, -1);
                graphics.DrawString(agent.GetName(), SystemFonts.IconTitleFont, Brushes.Black, textRect, MyStringFormat);
            }

            // Custom action balloons
            if (scenario.CustomActions != null)
            {
                foreach (var ctx in scenario.CustomActions)
                {
                    if (ctx.Target != null)
                    {
                        var targetCenter = CoordinatesToDisplayPoint(ctx.Target.GetPosition().X, ctx.Target.GetPosition().Y, rect);
                        var agentCenter = CoordinatesToDisplayPoint(ctx.ThinkingAgent.GetPosition().X, ctx.ThinkingAgent.GetPosition().Y, rect);
                        graphics.DrawLine(Pens.Blue, targetCenter, agentCenter);

                        var midpoint = new Point((agentCenter.X + targetCenter.X) / 2, (agentCenter.Y + targetCenter.Y) / 2);
                        var textRect = new Rectangle(midpoint.X - 60, midpoint.Y - 15, 120, 30);
                        graphics.DrawString(ctx.ChosenBehavior.Payload, SystemFonts.IconTitleFont, Brushes.Blue, textRect, MyStringFormat);
                    }
                    else
                    {
                        int pad = 20;
                        var displayRect = ToDisplayRect(ctx.ThinkingAgent, rect);
                        var textRect = new Rectangle(displayRect.Left - pad, displayRect.Top - pad, displayRect.Width + pad * 2, pad * 3);
                        graphics.DrawString(ctx.ChosenBehavior.Payload, SystemFonts.IconTitleFont, Brushes.Blue, textRect, MyStringFormat);
                    }

                }
            }
        }


        private void ComputeVisibleBounds(Scenario scenario, out PointF minCoordinate, out PointF maxCoordinate)
        {
            if (scenario.Agents.Count > 0)
            {
                minCoordinate = new PointF(1e6f, 1e6f);
                maxCoordinate = new PointF(-1e6f, -1e6f);

                foreach (var agent in scenario.Agents)
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

                foreach (var loc in scenario.Locations)
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
        }


        private void DrawBackgroundObjects(Graphics graphics, Rectangle rect, PointF minCoordinate, PointF maxCoordinate)
        {
            graphics.FillRectangle(Brushes.White, rect);
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(minCoordinate.X, 0.0f, rect), CoordinatesToDisplayPoint(maxCoordinate.X, 0.0f, rect));
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(0.0f, minCoordinate.Y, rect), CoordinatesToDisplayPoint(0.0f, maxCoordinate.Y, rect));
        }


        private void DrawLocations(Scenario scenario, Graphics graphics, Rectangle rect)
        {
            foreach (var loc in scenario.Locations)
            {
                var displayRect = ToDisplayRect(loc, rect);
                graphics.FillEllipse(Brushes.Gray, displayRect);

                int pad = 20;
                var textRect = new Rectangle(displayRect.Left - pad, displayRect.Top + displayRect.Height + 5, displayRect.Width + pad * 2, pad + 5);
                graphics.DrawString(loc.GetName(), SystemFonts.IconTitleFont, Brushes.DarkGreen, textRect, MyStringFormat);
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

        private Rectangle ToDisplayRect(Scenario.IScenarioMember obj, Rectangle rect, float scaleRadius = 1.0f)
        {
            PointF center = obj.GetPosition();
            Point centerRender = CoordinatesToDisplayPoint(center.X, center.Y, rect);

            int width = (int)((float)rect.Width * obj.GetRadius() * scaleRadius / (HorizontalUnitsVisible / 2.0f));
            int height = (int)((float)rect.Height * obj.GetRadius() * scaleRadius / (VerticalUnitsVisible / 2.0f));

            return new Rectangle(centerRender.X - (width / 2), centerRender.Y - (height / 2), width, height);
        }


        private bool HitTest(Scenario.IScenarioMember member, PointF simpt)
        {
            var simposition = member.GetPosition();

            float dx = simpt.X - simposition.X;
            float dy = simpt.Y - simposition.Y;

            float distanceSq = dx * dx + dy * dy;

            return (distanceSq <= member.GetRadius() * member.GetRadius());
        }


        public InspectionText GetInspectionText(Scenario scenario, Rectangle rect, Point pt)
        {
            var simpt = DisplayPointToCoordinates(pt, rect);

            foreach (var agent in scenario.Agents)
            {
                if (HitTest(agent, simpt))
                {
                    ToolTipIcon icon = ToolTipIcon.Warning;
                    string positiontext = $"{agent.GetPosition()} R:{agent.GetRadius()}";

                    string decisiontext = "[Stalled]";
                    if (scenario.AgentDecisions != null && scenario.AgentDecisions.ContainsKey(agent))
                    {
                        if (scenario.AgentDecisions[agent].WinningContext != null)
                        {
                            decisiontext = scenario.AgentDecisions[agent].WinningContext.ToString();
                            icon = ToolTipIcon.Info;
                        }
                    }

                    return new InspectionText { Caption = $"Agent: {agent.GetName()}", Description = $"{positiontext}\r\n{decisiontext}", Icon = icon };
                }
            }

            foreach (var loc in scenario.Locations)
            {
                if (HitTest(loc, simpt))
                {
                    string positiontext = $"{loc.GetPosition()} R:{loc.GetRadius()}";
                    return new InspectionText { Caption = $"Location: {loc.GetName()}", Description = $"{positiontext}", Icon = ToolTipIcon.Info };
                }
            }

            return null;
        }


        public ScenarioAgent GetAgentAtLocation(Scenario scenario, Rectangle rect, Point pt)
        {
            var simpt = DisplayPointToCoordinates(pt, rect);
            foreach (var agent in scenario.Agents)
            {
                if (HitTest(agent, simpt))
                    return agent;
            }

            return null;
        }


        private static Color GetDarkerColor(Color c)
        {
            return ControlPaint.Dark(c, 0.25f);
        }

        private static Color GetLighterColor(Color c)
        {
            return ControlPaint.Light(c, 0.25f);
        }
    }
}
