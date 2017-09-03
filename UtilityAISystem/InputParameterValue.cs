using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class InputParameterValue
    {
        [DataMember]
        public InputParameter ControllingParameter;

        [DataMember]
        public float Value;


        internal InputParameterValue()
        {
        }

        public InputParameterValue(InputParameter controller, float value)
        {
            ControllingParameter = controller;
            Value = value;
        }
    }
}
