using System.Windows.Forms;

namespace Curvature
{
    interface IUserEditable
    {
        Control CreateEditorUI(Project project);
    }
}
