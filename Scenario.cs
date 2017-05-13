using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    class Scenario : IInputBroker
    {
        public interface IScenarioMember
        {
            string GetName();
            PointF GetPosition();
        }

        public class Context
        {
            public ScenarioAgent ThinkingAgent;
            public IScenarioMember Target;
            public Behavior ChosenBehavior;
        }


        public string ReadableName;
        public List<ScenarioAgent> Agents;
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


            PopulateWithDummyData();
        }


        private void PopulateWithDummyData()
        {
            {
                var agent = new ScenarioAgent("Test", null);
                agent.Position = new PointF(-0.5f, -0.25f);
                agent.Radius = 0.1f;
                Agents.Add(agent);
            }

            {
                var agent = new ScenarioAgent("Test Origin", null);
                agent.Position = new PointF(0.0f, 0.0f);
                agent.Radius = 0.05f;
                Agents.Add(agent);
            }

            {
                var agent = new ScenarioAgent("Distant", null);
                agent.Position = new PointF(2.0f, 0.0f);
                agent.Radius = 0.025f;
                Agents.Add(agent);
            }
        }


        public void Advance(float dt)
        {
            List<IScenarioMember> targets = new List<IScenarioMember>();
            targets.AddRange(Agents);
            targets.AddRange(Locations);

            foreach (var agent in Agents)
            {
                var context = agent.ChooseBehavior(this, targets);
                ExecuteBehaviorOnAgent(context, dt);
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
                minpos.X -= agent.Radius;
                minpos.Y -= agent.Radius;

                var maxpos = agent.GetPosition();
                maxpos.X += agent.Radius;
                maxpos.Y += agent.Radius;

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
            // TODO
            return 0.0;
        }


        private void ExecuteBehaviorOnAgent(Context context, float dt)
        {
            // TODO
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
    }
}
