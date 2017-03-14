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
    public class KnowledgeBase : IUserEditable
    {

        [DataContract(Namespace = "")]
        public class Record
        {
            [DataMember]
            public string ReadableName;

            [DataMember]
            public double MinimumValue;

            [DataMember]
            public double MaximumValue;

            [DataMember]
            public bool Computed;


            internal Record()
            {
            }

            public Record(string name, double min, double max, bool computed)
            {
                ReadableName = name;
                MinimumValue = min;
                MaximumValue = max;
                Computed = computed;
            }

            public override string ToString()
            {
                return ReadableName;
            }
        }

        [DataMember]
        internal List<Record> Records;


        public KnowledgeBase()
        {
            Records = new List<Record>();
        }


        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetKnowledgeBase(this);
        }
    }
}
