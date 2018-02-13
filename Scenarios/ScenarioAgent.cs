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
        public Dictionary<KnowledgeBase.Record, object> Properties;

        [DataMember]
        public Dictionary<KnowledgeBase.Record, object> StartProperties;
        
        [DataMember]
        public Archetype AgentArchetype;

        [DataMember]
        public Color Color;

        [DataMember]
        public ScenarioLocation StartLocation;

        [DataMember]
        public bool StartFuzzed;


        public bool Stalled = false;
        public Scenario.IScenarioMember Intent = null;
        public bool IntentAttractive = true;


        public ScenarioAgent(string name, Archetype archetype)
        {
            Name = name;
            AgentArchetype = archetype;

            Position = new PointF(0.0f, 0.0f);
            Radius = 1.0f;

            Properties = new Dictionary<KnowledgeBase.Record, object>();

            Color = Color.LightSteelBlue;
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


        public Scenario.Context ChooseBehavior(IInputBroker broker, List<Scenario.IScenarioMember> targets, Scenario.DecisionHistory scores)
        {
            if (AgentArchetype == null)
                return null;

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

                            scores.ScoredContexts.Add(context);
                        }
                    }
                }
            }

            var scoredBehaviors = scores.ScoredContexts.Select(ctx => new { ctx, score = ctx.ChosenBehavior.Score(broker, ctx) }).OrderByDescending(x => x.score.FinalScore);
            if (scoredBehaviors == null || !scoredBehaviors.Any())
                return null;

            foreach (var behavior in scoredBehaviors.ToList())
                behavior.ctx.BehaviorScore = behavior.score;


            var topBehavior = scoredBehaviors.First();

            if (topBehavior.score.FinalScore > 0.0f)
                return topBehavior.ctx;
 
            return null;
        }

        public object GetProperty(KnowledgeBase.Record kbrec)
        {
            if (Properties == null || !Properties.ContainsKey(kbrec))
                return 0.0;

            return Properties[kbrec];
        }

        public void GenerateStartProperties(KnowledgeBase kb)
        {
            var oldstarts = StartProperties;
            if (oldstarts == null)
                oldstarts = new Dictionary<KnowledgeBase.Record, object>();

            StartProperties = new Dictionary<KnowledgeBase.Record, object>();

            foreach (var rec in kb.Records)
            {
                if (rec.Computed)
                    continue;

                if (oldstarts.ContainsKey(rec))
                    StartProperties.Add(rec, oldstarts[rec]);
                else
                {
                    if (rec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
                        StartProperties.Add(rec, rec.EnumerationValues.First());
                    else
                        StartProperties.Add(rec, rec.MinimumValue);
                }
            }
        }

        internal void MoveToStartPosition(Random rand)
        {
            float fuzzRadius = Radius;
            PointF startPos = StartPosition;

            if (StartLocation != null)
            {
                startPos.X += StartLocation.Position.X;
                startPos.Y += StartLocation.Position.Y;
            }

            if (StartFuzzed)
            {
                startPos.X += (0.5f - (float)rand.NextDouble()) * fuzzRadius * 2.0f;
                startPos.Y += (0.5f - (float)rand.NextDouble()) * fuzzRadius * 2.0f;
            }

            Position = startPos;
        }
    }
}
