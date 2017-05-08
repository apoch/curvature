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
                ExecuteBehaviorOnAgent(context, dt);
            }
        }


        public void Render(Graphics graphics, Rectangle rect)
        {
            // Set up scaling
            // TODO

            // Backplot and axes
            graphics.FillRectangle(Brushes.White, rect);
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(-1.0f, 0.0f, rect), CoordinatesToDisplayPoint(1.0f, 0.0f, rect));
            graphics.DrawLine(RenderPenDottedBlack, CoordinatesToDisplayPoint(0.0f, -1.0f, rect), CoordinatesToDisplayPoint(0.0f, 1.0f, rect));
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
            x /= (HorizontalUnitsVisible * 0.5f);
            y /= (VerticalUnitsVisible * 0.5f);

            x += 0.5f;
            y += 0.5f;

            return new Point((int)(x * (float)rect.Width), (int)(y * (float)rect.Height));
        }
    }
}
