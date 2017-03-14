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
    public class Consideration : IUserEditable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public InputAxis Input;

        [DataMember]
        public ResponseCurve Curve;

        [DataMember]
        public List<InputParameter> Parameters;

        internal Consideration()
        {
        }

        public Consideration(string name)
        {
            ReadableName = name;
            Parameters = new List<InputParameter>();
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetConsideration(project, this);
        }
    }
}
