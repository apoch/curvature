using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    class KnowledgeBase : IUserEditable
    {

        internal class Record
        {
            public string ReadableName;
            public double MinimumValue;
            public double MaximumValue;

            public Record(string name, double min, double max)
            {
                ReadableName = name;
                MinimumValue = min;
                MaximumValue = max;
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
