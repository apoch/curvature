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
    public partial class EditWidgetConsideration : UserControl
    {
        private Consideration EditConsideration;
        private Project EditProject;

        public EditWidgetConsideration()
        {
            InitializeComponent();
        }

        internal void Attach(Project project, Consideration editConsideration)
        {
            EditConsideration = editConsideration;
            EditProject = project;

            ConsiderationNameLabel.Text = "Consideration: " + EditConsideration.ReadableName;

            InputAxisDropdown.Items.Clear();
            foreach (InputAxis axis in project.Inputs)
            {
                InputAxisDropdown.Items.Add(axis);
            }

            foreach (Control c in ParamFlowPanel.Controls)
                c.Dispose();

            ParamFlowPanel.Controls.Clear();

            foreach (InputParameter param in EditConsideration.Parameters)
            {
                ParamFlowPanel.Controls.Add(new EditWidgetParameter(param));
            }

            InputAxisDropdown.SelectedItem = EditConsideration.Input;
            ResponseCurveEditor.AttachCurve(EditConsideration.Curve);
        }

        private void CurveWizardButton_Click(object sender, EventArgs e)
        {
            (new CurveWizardForm(EditProject, EditConsideration)).ShowDialog();
        }

        private void InputAxisDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditConsideration.Input = InputAxisDropdown.SelectedItem as InputAxis;
        }
    }
}
