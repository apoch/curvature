using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class ScenarioAgent : Scenario.IScenarioMember
    {
        [DataMember]
        public string Name;

        [DataMember]
        public PointF Position;

        [DataMember]
        public PointF StartPosition;

        [DataMember]
        public float Radius;

        [DataMember]
        public Dictionary<string, double> Properties;

        [DataMember]
        public HashSet<string> Tags;

        [DataMember]
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

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Stalled = false;
        }


        public string GetName()
        {
            return Name;
        }

        public PointF GetPosition()
        {
            return Position;
        }

        public float GetRadius()
        {
            return Radius;
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

            if (topBehavior.score > 0.0f)
                return topBehavior.ctx;

            return null;
        }

        public double GetProperty(string name)
        {
            return Properties[name];
        }
    }
}
