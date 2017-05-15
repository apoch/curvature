using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public class ScenarioAgent : Scenario.IScenarioMember
    {
        public string Name;
        public PointF Position;
        public float Radius;

        public Dictionary<string, double> Properties;
        public HashSet<string> Tags;

        public Archetype AgentArchetype;

        public bool Stalled = false;


        public ScenarioAgent(string name, Archetype archetype)
        {
            Name = name;
            AgentArchetype = archetype;

            Position = new PointF(0.0f, 0.0f);
            Radius = 1.0f;

            Properties = new Dictionary<string, double>();
            Tags = new HashSet<string>();
        }


        public string GetName()
        {
            return Name;
        }

        public PointF GetPosition()
        {
            return Position;
        }


        public Scenario.Context ChooseBehavior(IInputBroker broker, List<Scenario.IScenarioMember> targets)
        {
            if (AgentArchetype == null)
                return null;

            List<Scenario.Context> scoreSet = new List<Scenario.Context>();

            foreach (var set in AgentArchetype.BehaviorSets)
            {
                foreach (var behavior in set.EnabledBehaviors)
                {
                    if (behavior.CanTargetOthers || behavior.CanTargetSelf)
                    {
                        foreach (var scenarioTarget in targets)
                        {
                            if (!behavior.CanTargetOthers && (scenarioTarget != this))
                                continue;

                            if (!behavior.CanTargetSelf && (scenarioTarget == this))
                                continue;

                            var context = new Scenario.Context();
                            context.ChosenBehavior = behavior;
                            context.Target = scenarioTarget;
                            context.ThinkingAgent = this;

                            scoreSet.Add(context);
                        }
                    }
                }
            }

            var scoredBehaviors = scoreSet.Select(ctx => new { ctx, score = ctx.ChosenBehavior.Score(broker) }).OrderByDescending(x => x.score);
            var topBehavior = scoredBehaviors.First();

            return topBehavior.ctx;
        }

        public double GetProperty(string name)
        {
            return Properties[name];
        }
    }
}
