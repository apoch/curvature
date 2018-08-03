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
    public partial class EditWidgetInputAxis : UserControl
    {
        private InputAxis EditingAxis;
        private Project EditingProject;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        internal EditWidgetInputAxis(Project project, InputAxis axis)
        {
            InitializeComponent();
            EditingAxis = axis;
            EditingProject = project;

            EditingAxis.DialogRebuildNeeded += Rebuild;

            NameEditWidget.Attach("Input Axis", axis, project);

            InputTypeComboBox.SelectedIndex = (int)axis.Origin;

            EditingAxis.ParametersChanged += (obj, args) =>
            {
                GenerateParameterControls();
                EditingProject.MarkDirty();
            };
        }

        private void InputTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectComputedProperties = false;
            DataSourceComboBox.Items.Clear();

            if (InputTypeComboBox.SelectedIndex == 0 || InputTypeComboBox.SelectedIndex == 1)
            {
                selectComputedProperties = false;
            }
            else if (InputTypeComboBox.SelectedIndex == 2)
            {
                selectComputedProperties = true;
            }

            foreach (var rec in EditingProject.KB.Records)
            {
                if (rec.Computed == selectComputedProperties)
                    DataSourceComboBox.Items.Add(rec);
            }

            var prev = EditingAxis.Origin;

            DataSourceComboBox.SelectedItem = EditingAxis.KBRec;
            EditingAxis.Origin = (InputAxis.OriginType)InputTypeComboBox.SelectedIndex;

            GenerateParameterControls();


            if (prev != EditingAxis.Origin)
                EditingProject.MarkDirty();
        }

        private void DataSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditingAxis.KBRec;

            EditingAxis.KBRec = DataSourceComboBox.SelectedItem as KnowledgeBase.Record;

            if (prev != EditingAxis.KBRec)
                EditingProject.MarkDirty();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EditingProject.Delete(EditingAxis);
        }

        private void GenerateParameterControls()
        {
            foreach (Control ctl in ParamFlowPanel.Controls)
                ctl.Dispose();

            ParamFlowPanel.Controls.Clear();

            foreach (InputParameter param in EditingAxis.Parameters)
            {
                ParamFlowPanel.Controls.Add(new EditWidgetParameter(param, EditingProject));
            }
        }


        internal void Rebuild()
        {
            NameEditWidget.Attach("Input Axis", EditingAxis, EditingProject);
            DialogRebuildNeeded?.Invoke();
        }
    }
}
