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


        public delegate void ParametersChangedHandler(object o, EventArgs a);
        public event ParametersChangedHandler ParametersChanged;


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
                var ret = new InputAxis(ReadableName, Origin);
                ret.KBRecord = KBRecord;
                ret.ReadableName = ReadableName;

                float newmin = Math.Max(Parameters[0].MinimumValue, parameters[0].Value);
                float newmax = Math.Min(Parameters[0].MaximumValue, parameters[0].Value);

                var param = new InputParameter(Parameters[0].ReadableName, newmin, newmax);
                ret.Parameters.Add(param);

                return ret;
            }

            if (parameters.Count == 2)
            {
                var ret = new InputAxis(ReadableName, Origin);
                ret.KBRecord = KBRecord;
                ret.ReadableName = ReadableName;

                float newmin = Math.Max(Parameters[0].MinimumValue, parameters[0].Value);
                float newmax = Math.Min(Parameters[1].MaximumValue, parameters[1].Value);

                var param = new InputParameter(Parameters[0].ReadableName, newmin, newmax);
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
                var ret = new InputAxis(ReadableName, Origin);
                ret.KBRecord = KBRecord;
                ret.ReadableName = ReadableName;

                float newmin = Math.Min(Parameters[0].MinimumValue, other.Parameters[0].MinimumValue);
                float newmax = Math.Max(Parameters[0].MaximumValue, other.Parameters[0].MaximumValue);

                var param = new InputParameter(Parameters[0].ReadableName, newmin, newmax);
                ret.Parameters.Add(param);

                return ret;
            }

            return null;
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
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
                    Parameters.Add(new InputParameter("Range lower bound", -1e6f, 1e6f));
                    Parameters.Add(new InputParameter("Range upper bound", -1e6f, 1e6f));
                    break;

                case KnowledgeBase.Record.Parameterization.Enumeration:
                    // TODO - implement enumerated parameters
                    break;

                case KnowledgeBase.Record.Parameterization.FixedRange:
                    Parameters.Add(new InputParameter("Range", -1e6f, 1e6f));
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
