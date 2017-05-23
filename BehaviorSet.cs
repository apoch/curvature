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
    public class BehaviorSet : IUserEditable, INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public HashSet<Behavior> EnabledBehaviors;


        internal BehaviorSet()
        {
        }

        public BehaviorSet(string name)
        {
            ReadableName = name;
            EnabledBehaviors = new HashSet<Behavior>();
        }

        public override string ToString()
        {
            return ReadableName;
        }

        public Control CreateEditorUI(Project project)
        {
            var widget = new EditWidgetBehaviorSet();
            widget.Attach(this, project);
            return widget;
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
