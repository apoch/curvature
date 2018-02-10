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

        [DataMember]
        public bool WrapInput;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public Consideration(string name)
        {
            ReadableName = name;
            ParameterValues = new List<InputParameterValue>();
            Curve = new ResponseCurve(ResponseCurve.CurveType.Linear, 1.0, 1.0, 0.0, 0.0);
        }


        public void CopyFrom(Consideration other)
        {
            ReadableName = other.ReadableName;
            Input = other.Input;
            Curve.CopyFrom(other.Curve);
            ParameterValues = other.ParameterValues;
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
                    if (oldparams != null && oldparams.Count > i && oldparams[i].GetControllingParameter() == p)
                    {
                        ParameterValues.Add(oldparams[i]);
                    }
                    else
                    {
                        if (p is InputParameterNumeric)
                        {
                            var pnum = p as InputParameterNumeric;
                            var v = new InputParameterValueNumeric(pnum, ParameterValues.Count > 0 ? pnum.MaximumValue : pnum.MinimumValue);
                            ParameterValues.Add(v);
                        }
                        else if (p is InputParameterEnumeration)
                        {
                            var penum = p as InputParameterEnumeration;
                            var v = new InputParameterValueEnumeration(penum, null);
                            ParameterValues.Add(v);
                        }
                    }

                    ++i;
                }
            }
        }

        internal Scenario.Score Score(IInputBroker broker, Scenario.Context context)
        {
            var score = new Scenario.Score();
            score.InputRawValue = broker.GetInputValue(this, context);
            score.InputValue = NormalizeInput(score.InputRawValue);
            score.FinalScore = Curve.ComputeValue(score.InputValue);
            return score;
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

        internal double NormalizeInput(double raw)
        {
            if (ParameterValues.Count == 1)
            {
                if (ParameterValues[0] is InputParameterValueEnumeration)
                {
                    if (raw < 0.0)
                        return 0.0;

                    if (raw > 1.0)
                        return 1.0;

                    return raw;
                }
                else
                {
                    double max = (ParameterValues[0] as InputParameterValueNumeric).Value;
                    if (max == 0.0)
                        return 0.0;

                    if (WrapInput)
                    {
                        raw %= max;
                    }
                    else
                    {
                        if (raw < 0.0)
                            raw = 0.0;
                        else if (raw > max)
                            raw = max;
                    }

                    return raw / max;
                }
            }
            else if (ParameterValues.Count == 2)
            {
                double min = (ParameterValues[0] as InputParameterValueNumeric).Value;
                double max = (ParameterValues[1] as InputParameterValueNumeric).Value;

                if (WrapInput)
                {
                    if (raw < min)
                        raw = min;
                    
                    raw %= (max - min);

                    return raw;
                }
                else
                {
                    if (raw < min)
                        raw = min;
                    else if (raw > max)
                        raw = max;

                    return (raw - min) / (max - min);
                }
            }
            else
            {
                if (WrapInput)
                {
                    return raw - Math.Truncate(raw);
                }
                else
                {
                    if (raw < 0.0)
                        return 0.0;

                    if (raw > 1.0)
                        return 1.0;

                    return raw;
                }
            }
        }
    }
}
