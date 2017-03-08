using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public partial class EditWidgetProject : UserControl
    {
        private Project EditedProject;


        internal EditWidgetProject(Project editedProject)
        {
            InitializeComponent();
            EditedProject = editedProject;

            ProjectNameLabel.Text = EditedProject.ReadableName;
        }
    }
}
