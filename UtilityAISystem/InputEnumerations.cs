using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Curvature
{
    [DataContract(Namespace = "")]
    public class InputParameterEnumeration : InputParameter
    {
        [DataMember]
        public HashSet<string> ValidValues;

        [DataMember]
        public string MatchString;

        [DataMember]
        public bool ScoreOnMatch;


        public InputParameterEnumeration(string name, HashSet<string> valids)
        {
            ReadableName = name;
            ValidValues = valids;

            ScoreOnMatch = true;
        }
    }

    [DataContract(Namespace = "")]
    public class InputParameterValueEnumeration : InputParameterValue
    {
        [DataMember]
        public InputParameterEnumeration ControllingParameter;

        [DataMember]
        public string Key;


        public InputParameterValueEnumeration(InputParameterEnumeration controller, string key)
        {
            ControllingParameter = controller;
            Key = key;
        }

        public override float GetValue()
        {
            if (Key.Equals(ControllingParameter.MatchString, System.StringComparison.CurrentCultureIgnoreCase))
            {
                if (ControllingParameter.ScoreOnMatch)
                    return 1.0f;

                return 0.0f;
            }

            if (ControllingParameter.ScoreOnMatch)
                return 0.0f;

            return 1.0f;
        }

        public override InputParameter GetControllingParameter()
        {
            return ControllingParameter;
        }
    }
}
