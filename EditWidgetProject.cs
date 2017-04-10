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


        public EditWidgetProject()
        {
            InitializeComponent();
        }


        internal void Attach(Project editedProject)
        {
            EditedProject = editedProject;
            ProjectNameLabel.Text = EditedProject.ReadableName;
        }
    }
}
