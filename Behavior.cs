using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    class Behavior : IUserEditable
    {
        public string ReadableName;
        public List<Consideration> Considerations;

        public Behavior(string name)
        {
            ReadableName = name;
            Considerations = new List<Consideration>();
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetBehavior(this);
        }
    }
}
