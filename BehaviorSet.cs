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
    public class BehaviorSet : IUserEditable
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

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetBehaviorSet(project, ReadableName, EnabledBehaviors);
        }
    }
}
