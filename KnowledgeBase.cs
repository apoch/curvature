using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public class KnowledgeBase : IUserEditable
    {

        public class Record
        {
            public string ReadableName;
            public double MinimumValue;
            public double MaximumValue;
            public bool Computed;

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
