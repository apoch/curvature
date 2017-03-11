using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public class BehaviorSet : IUserEditable
    {
        public string ReadableName;
        public HashSet<Behavior> EnabledBehaviors;

        public BehaviorSet(string name)
        {
            ReadableName = name;
            EnabledBehaviors = new HashSet<Behavior>();
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetBehaviorSet(project, this);
        }
    }
}
