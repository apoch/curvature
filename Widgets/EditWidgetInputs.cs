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
        }

        internal void Attach(Project project, List<InputAxis> inputs)
        {
            EditingProject = project;
            Inputs = inputs;
            RefreshControls();
        }

        private void RefreshControls()
        {
            foreach (Control c in InputsFlowPanel.Controls)
                c.Dispose();

            InputsFlowPanel.Controls.Clear();


            foreach (var input in Inputs)
            {
                InputsFlowPanel.Controls.Add(new EditWidgetInputAxis(EditingProject, input));
            }

            var newInputButton = new Button
            {
                ImageList = IconImageList,
                ImageIndex = 0,
                ImageAlign = ContentAlignment.MiddleRight,
                TextImageRelation = TextImageRelation.ImageBeforeText,

                Text = "Create Input Axis",
                AutoSize = true
            };

            newInputButton.Click += (e, args) =>
            {
                Inputs.Add(new InputAxis("New input", InputAxis.OriginType.PropertyOfSelf));
                EditingProject.MarkDirty();
                RefreshControls();
            };

            InputsFlowPanel.Controls.Add(newInputButton);
            InputsFlowPanel.ScrollControlIntoView(newInputButton);
        }
    }
}
