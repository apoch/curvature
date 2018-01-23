using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Behavior : INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public List<Consideration> Considerations;

        [DataMember]
        public double Weight;

        [DataMember]
        public ActionType Action;

        [DataMember]
        public bool CanTargetSelf;

        [DataMember]
        public bool CanTargetOthers;

        [DataMember]
        public string Payload;


        public enum ActionType
        {
            [Description("Do nothing")]
            Idle,

            [Description("Move towards the target")]
            MoveToTarget,

            [Description("Move away from the target")]
            MoveAwayFromTarget,

            [Description("Show a speech balloon")]
            Talk,

            [Description("Show a custom animation")]
            Custom
        }

        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        internal Behavior()
        {
            Action = ActionType.Idle;
            CanTargetSelf = false;
            CanTargetOthers = true;
        }

        public Behavior(string name)
        {
            ReadableName = name;
            Considerations = new List<Consideration>();
            Weight = 1.0;
            Action = ActionType.Idle;
            CanTargetSelf = false;
            CanTargetOthers = true;
        }


        public override string ToString()
        {
            if (string.IsNullOrEmpty(ReadableName))
                return "(Untitled)";

            return ReadableName;
        }

        internal Scenario.ConsiderationScores Score(IInputBroker broker, Scenario.Context context)
        {
            var ret = new Scenario.ConsiderationScores();
            ret.Considerations = new Dictionary<Consideration, Scenario.Score>();

            double compensationFactor = 1.0 - (1.0 / (double)Considerations.Count);
            double result = Weight;
            ret.InitialWeight = Weight;

            foreach (Consideration c in Considerations)
            {
                Scenario.Score considerationScore = c.Score(broker, context);
                double modification = (1.0 - considerationScore.FinalScore) * compensationFactor;
                considerationScore.FinalScore = considerationScore.FinalScore + (modification * considerationScore.FinalScore);

                result *= considerationScore.FinalScore;
                ret.Considerations.Add(c, considerationScore);
            }

            ret.FinalScore = result;
            return ret;
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
    }

    internal static class EnumExtensions
    {
        internal static string GetDescription(this Enum genericEnum)
        {
            Type genericEnumType = genericEnum.GetType();
            var memberInfo = genericEnumType.GetMember(genericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return genericEnum.ToString();
        }
    }
}
