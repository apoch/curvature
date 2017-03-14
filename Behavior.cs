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
    public class Behavior : IUserEditable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public List<Consideration> Considerations;


        internal Behavior()
        {
        }

        public Behavior(string name)
        {
            ReadableName = name;
            Considerations = new List<Consideration>();
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetBehavior(this);
        }

        public override string ToString()
        {
            return ReadableName;
        }
    }
}
