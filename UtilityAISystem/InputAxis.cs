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
    public class InputAxis : INameable
    {
        public enum OriginType
        {
            PropertyOfSelf,
            PropertyOfTarget,
            ComputedValue
        }

        [DataMember]
        public string ReadableName;

        [DataMember]
        public OriginType Origin;

        [DataMember]
        public List<InputParameter> Parameters;

        [DataMember]
        private KnowledgeBase.Record KBRecord;

        public KnowledgeBase.Record KBRec
        {
            get
            {
                return KBRecord;
            }

            set
            {
                if (KBRecord == value)
                    return;

                if(KBRecord != null)
                    KBRecord.PropertyChanged -= KBChanged;

                KBRecord = value;

                if (KBRecord != null)
                    KBRecord.PropertyChanged += KBChanged;

                GenerateParametersFromKBRecord();
            }
        }


        public delegate void ParametersChangedHandler(object sender, EventArgs e);
        public event ParametersChangedHandler ParametersChanged;

        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        internal InputAxis()
        {
        }

        public InputAxis(string name, OriginType origin)
        {
            ReadableName = name;
            Origin = origin;
            Parameters = new List<InputParameter>();
        }

        public override string ToString()
        {
            return ReadableName;
        }

        public InputAxis Clamp(List<InputParameterValue> parameters)
        {
            if (parameters == null)
                return this;

            if (parameters.Count == 0)
                return this;

            if (parameters.Count == 1)
            {
                if (parameters[0] is InputParameterValueEnumeration)
                    return this;

                var ret = new InputAxis(ReadableName, Origin)
                {
                    KBRecord = KBRecord,
                    ReadableName = ReadableName
                };

                float newmin = (Parameters[0] as InputParameterNumeric).MinimumValue;
                float newmax = Math.Min((Parameters[0] as InputParameterNumeric).MaximumValue, (parameters[0] as InputParameterValueNumeric).Value);

                var param = new InputParameterNumeric(Parameters[0].ReadableName, newmin, newmax);
                ret.Parameters.Add(param);

                return ret;
            }

            if (parameters.Count == 2)
            {
                var ret = new InputAxis(ReadableName, Origin)
                {
                    KBRecord = KBRecord,
                    ReadableName = ReadableName
                };

                float newmin = Math.Max((Parameters[0] as InputParameterNumeric).MinimumValue, (parameters[0] as InputParameterValueNumeric).Value);
                float newmax = Math.Min((Parameters[1] as InputParameterNumeric).MaximumValue, (parameters[1] as InputParameterValueNumeric).Value);

                var param = new InputParameterNumeric(Parameters[0].ReadableName, newmin, newmax);
                ret.Parameters.Add(param);

                return ret;
            }

            return this;
        }

        public InputAxis Union(InputAxis other)
        {
            if (other == null)
                return this;

            if (other.Parameters.Count == 0)
                return this;

            if (other.Parameters.Count == 1)
            {
                if (other.Parameters[0] is InputParameterEnumeration)
                    return this;

                var ret = new InputAxis(ReadableName, Origin)
                {
                    KBRecord = KBRecord,
                    ReadableName = ReadableName
                };

                float newmin = Math.Min((Parameters[0] as InputParameterNumeric).MinimumValue, (other.Parameters[0] as InputParameterNumeric).MinimumValue);
                float newmax = Math.Max((Parameters[0] as InputParameterNumeric).MaximumValue, (other.Parameters[0] as InputParameterNumeric).MaximumValue);

                var param = new InputParameterNumeric(Parameters[0].ReadableName, newmin, newmax);
                ret.Parameters.Add(param);

                return ret;
            }

            return null;
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

        public void GenerateParametersFromKBRecord()
        {
            Parameters = new List<InputParameter>();
            if (KBRecord == null)
            {
                ParametersChanged?.Invoke(this, null);
                return;
            }

            switch (KBRecord.Params)
            {
                case KnowledgeBase.Record.Parameterization.ConfigurableRange:
                    Parameters.Add(new InputParameterNumeric("Range lower bound", (float)KBRecord.MinimumValue, (float)KBRecord.MaximumValue));
                    Parameters.Add(new InputParameterNumeric("Range upper bound", (float)KBRecord.MinimumValue, (float)KBRecord.MaximumValue));
                    break;

                case KnowledgeBase.Record.Parameterization.Enumeration:
                    Parameters.Add(new InputParameterEnumeration("Enumeration", KBRecord.EnumerationValues));
                    break;

                case KnowledgeBase.Record.Parameterization.FixedRange:
                    Parameters.Add(new InputParameterNumeric("Ceiling", (float)KBRecord.MinimumValue, (float)KBRecord.MaximumValue));
                    break;
            }

            ParametersChanged?.Invoke(this, null);
        }

        private void KBChanged(object kbrec, EventArgs args)
        {
            GenerateParametersFromKBRecord();
        }
    }
}
