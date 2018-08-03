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
        private Consideration EditingConsideration;
        private Project EditingProject;


        internal delegate void DialogRebuildNeededHandler(Consideration editedContent);
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetConsideration()
        {
            InitializeComponent();
        }

        internal void Attach(Project project, Consideration editConsideration)
        {
            if (EditingConsideration != null)
                EditingConsideration.DialogRebuildNeeded -= Rebuild;

            EditingConsideration = editConsideration;
            EditingProject = project;

            EditingConsideration.DialogRebuildNeeded += Rebuild;

            NameEditWidget.Attach("Consideration", EditingConsideration, project);

            InputAxisDropdown.Items.Clear();
            foreach (InputAxis axis in project.Inputs)
            {
                InputAxisDropdown.Items.Add(axis);
            }

            InputAxisDropdown.SelectedItem = EditingConsideration.Input;
            ResponseCurveEditor.AttachCurve(EditingConsideration.Curve, EditingProject);

            WrapInputCheckBox.Checked = EditingConsideration.WrapInput;
        }

        private void CurveWizardButton_Click(object sender, EventArgs e)
        {
            var prev = new Consideration(EditingConsideration.GetName());
            prev.CopyFrom(EditingConsideration);

            var result = (new CurveWizardForm(EditingProject, EditingConsideration)).ShowDialog();
            if (result == DialogResult.OK)
            {
                EditingProject.MarkDirty();
                Rebuild();
            }
            else
                EditingConsideration.CopyFrom(prev);
        }

        private void InputAxisDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditingConsideration.Input;

            var axis = InputAxisDropdown.SelectedItem as InputAxis;
            EditingConsideration.Input = axis;

            foreach (Control c in ParamFlowPanel.Controls)
                c.Dispose();

            ParamFlowPanel.Controls.Clear();

            EditingConsideration.GenerateParameterValuesFromInput();
            foreach (var param in EditingConsideration.ParameterValues)
                ParamFlowPanel.Controls.Add(new EditWidgetParameterValue(param, EditingProject));

            if (prev != EditingConsideration.Input)
                EditingProject.MarkDirty();
        }

        internal void Rebuild()
        {
            Attach(EditingProject, EditingConsideration);
            DialogRebuildNeeded?.Invoke(EditingConsideration);
        }

        private void WrapInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var prev = EditingConsideration.WrapInput;

            EditingConsideration.WrapInput = WrapInputCheckBox.Checked;

            if (prev != EditingConsideration.WrapInput)
                EditingProject.MarkDirty();
        }
    }
}

