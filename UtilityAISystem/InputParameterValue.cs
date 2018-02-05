using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public abstract class InputParameterValue
    {
        public abstract float GetValue();
        public abstract InputParameter GetControllingParameter();
    }


    [DataContract(Namespace = "")]
    public class InputParameterValueNumeric : InputParameterValue
    {
        [DataMember]
        public InputParameterNumeric ControllingParameter;

        [DataMember]
        public float Value;


        public InputParameterValueNumeric(InputParameterNumeric controller, float value)
        {
            ControllingParameter = controller;
            Value = value;
        }

        public override float GetValue()
        {
            return Value;
        }

        public override InputParameter GetControllingParameter()
        {
            return ControllingParameter;
        }
    }
}
