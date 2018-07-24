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
    public partial class EditWidgetInputs : UserControl
    {
        Project EditingProject;
        List<InputAxis> Inputs;

        public EditWidgetInputs()
        {
            InitializeComponent();

            NewInputButton.Click += (e, args) =>
            {
                Inputs.Add(new InputAxis("New input", InputAxis.OriginType.PropertyOfSelf));
                EditingProject.MarkDirty();
                RefreshControls();
            };
        }

        internal void Attach(Project project, List<InputAxis> inputs)
        {
            EditingProject = project;
            Inputs = inputs;
            RefreshControls();
        }

        private void RefreshControls()
        {
            ScrollablePanel.SuspendLayout();

            foreach (Control c in ScrollablePanel.Controls)
                c.Dispose();

            ScrollablePanel.Controls.Clear();

            foreach (var input in Inputs)
            {
                var inputcontrol = new EditWidgetInputAxis(EditingProject, input);
                inputcontrol.Dock = DockStyle.Top;
                ScrollablePanel.Controls.Add(inputcontrol);
            }

            ScrollablePanel.ResumeLayout();
            ScrollablePanel.PerformLayout();
        }
    }
}
