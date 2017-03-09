using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public class InputAxis : IUserEditable
    {
        public string ReadableName;
        public List<InputParameter> Parameters;


        public InputAxis(string name)
        {
            ReadableName = name;
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
    }
}
