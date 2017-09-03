using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Consideration : INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public InputAxis Input;

        [DataMember]
        public ResponseCurve Curve;

        [DataMember]
        public List<InputParameterValue> ParameterValues;

        internal Consideration()
        {
        }

        public Consideration(string name)
        {
            ReadableName = name;
            ParameterValues = new List<InputParameterValue>();
            Curve = new ResponseCurve(ResponseCurve.CurveType.Linear, 1.0, 1.0, 0.0, 0.0);
        }

        public void GenerateParameterValuesFromInput()
        {
            var oldparams = ParameterValues;

            ParameterValues = new List<InputParameterValue>();
            if (Input != null)
            {
                int i = 0;
                foreach (var p in Input.Parameters)
                {
                    if (oldparams != null && oldparams[i].ControllingParameter == p)
                    {
                        ParameterValues.Add(oldparams[i]);
                    }
                    else
                    {
                        var v = new InputParameterValue(p, ParameterValues.Count > 0 ? p.MaximumValue : p.MinimumValue);
                        ParameterValues.Add(v);
                    }

                    ++i;
                }
            }
        }

        internal Scenario.Score Score(IInputBroker broker, Scenario.Context context)
        {
            var score = new Scenario.Score();
            score.InputValue = broker.GetInputValue(Input, context);
            score.FinalScore = Curve.ComputeValue(score.InputValue);
            return score;
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
        }

        public string GetName()
        {
            return ReadableName;
        }
    }
}
