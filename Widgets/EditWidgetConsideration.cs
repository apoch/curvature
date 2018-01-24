using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curvature.Widgets;

namespace Curvature
{
    public partial class EditWidgetConsideration : UserControl
    {
        private Consideration EditConsideration;
        private Project EditProject;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetConsideration()
        {
            InitializeComponent();
        }

        internal void Attach(Project project, Consideration editConsideration)
        {
            EditConsideration = editConsideration;
            EditProject = project;

            EditConsideration.DialogRebuildNeeded += Rebuild;

            NameEditWidget.Attach("Consideration", EditConsideration, project);

            InputAxisDropdown.Items.Clear();
            foreach (InputAxis axis in project.Inputs)
            {
                InputAxisDropdown.Items.Add(axis);
            }

            InputAxisDropdown.SelectedItem = EditConsideration.Input;
            ResponseCurveEditor.AttachCurve(EditConsideration.Curve, EditProject);
        }

        private void CurveWizardButton_Click(object sender, EventArgs e)
        {
            var result = (new CurveWizardForm(EditProject, EditConsideration)).ShowDialog();
            if (result == DialogResult.OK)
                EditProject.MarkDirty();
        }

        private void InputAxisDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditConsideration.Input;

            var axis = InputAxisDropdown.SelectedItem as InputAxis;
            EditConsideration.Input = axis;

            foreach (Control c in ParamFlowPanel.Controls)
                c.Dispose();

            ParamFlowPanel.Controls.Clear();

            EditConsideration.GenerateParameterValuesFromInput();
            foreach (var param in EditConsideration.ParameterValues)
                ParamFlowPanel.Controls.Add(new EditWidgetParameterValue(param, EditProject));

            if (prev != EditConsideration.Input)
                EditProject.MarkDirty();
        }

        internal void Rebuild()
        {
            EditConsideration.DialogRebuildNeeded -= Rebuild;
            Attach(EditProject, EditConsideration);

            DialogRebuildNeeded?.Invoke();
        }
    }
}

