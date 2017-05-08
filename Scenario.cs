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


        public Scenario(string name)
        {
            ReadableName = name;

            Agents = new List<ScenarioAgent>();
            Locations = new List<ScenarioLocation>();
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
            graphics.FillRectangle(Brushes.White, rect);
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
    }
}
