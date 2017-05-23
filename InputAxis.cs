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
    public class InputAxis : IUserEditable, INameable
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
        public KnowledgeBase.Record KBRecord;


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

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetInputAxis(project, this);
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
    }
}
