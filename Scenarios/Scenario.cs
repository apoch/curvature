using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using static Curvature.Scenarios.ScenarioMath;

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


        [DataMember]
        public string ReadableName;

        [DataMember]
        public List<ScenarioAgent> Agents;

        [DataMember]
        public List<ScenarioLocation> Locations;


        private Random RandomNumbers = new Random();

        private HashSet<ScenarioAgent> AgentsActiveThisTick;

        internal Dictionary<ScenarioAgent, DecisionHistory> AgentDecisions;
        internal List<Context> CustomActions;


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
                var decisionhistory = new DecisionHistory
                {
                    ScoredContexts = new List<Context>()
                };

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


        private static PointF ComputeVectorTowardsTarget(Context context)
        {
            PointF targetPoint = context.Target.GetPosition();
            float dx = targetPoint.X - context.ThinkingAgent.Position.X;
            float dy = targetPoint.Y - context.ThinkingAgent.Position.Y;

            var normal = Normalize(new PointF(dx, dy));
            return normal;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            RandomNumbers = new Random();
        }
    }
}
