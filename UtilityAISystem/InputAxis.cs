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

        public InputAxis Union(InputAxis other)
        {
            if (other == null)
                return this;

            if (other.ReadableName.CompareTo(ReadableName) != 0)
                throw new ArgumentException("Cannot union unrelated inputs");

            if (Parameters.Count != other.Parameters.Count)
                throw new ArgumentException("Cannot union inputs with disjoint parameters");

            var ret = new InputAxis(ReadableName, Origin);
            ret.KBRecord = KBRecord;
            ret.ReadableName = ReadableName;

            for (int i = 0; i < Parameters.Count; ++i)
            {
                if (other.Parameters[i].ReadableName.CompareTo(Parameters[i].ReadableName) != 0)
                    throw new ArgumentException("Cannot union inputs with disjoint parameters");

                float newmin = Math.Min(Parameters[i].MinimumValue, other.Parameters[i].MinimumValue);
                float newmax = Math.Max(Parameters[i].MaximumValue, other.Parameters[i].MaximumValue);

                var param = new InputParameter(Parameters[i].ReadableName, newmin, newmax);
                ret.Parameters.Add(param);
            }

            return ret;
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
