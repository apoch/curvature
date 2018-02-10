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
    public partial class EditWidgetKnowledgeBaseRecord : UserControl
    {
        private KnowledgeBase.Record EditRec;
        private Project EditProject;

        internal EditWidgetKnowledgeBaseRecord(KnowledgeBase.Record rec, Project project)
        {
            InitializeComponent();
            EditRec = rec;
            EditProject = project;

            RecordTagEditBox.Text = EditRec.ReadableName;

            if (EditRec.Computed)
                OriginComboBox.SelectedIndex = 1;
            else
                OriginComboBox.SelectedIndex = 0;

            ClampingBehaviorComboBox.SelectedIndex = (int)EditRec.Params;

            if (EditRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
            {
                UpdateEnumeration();
            }
            else
            {
                RangeMinimum.Value = (decimal)EditRec.MinimumValue;
                RangeMaximum.Value = (decimal)EditRec.MaximumValue;
            }

            if (EditRec.Prefab != KnowledgeBase.Record.Prefabs.NoPrefab)
                PrefabComboBox.SelectedIndex = (int)(EditRec.Prefab) - 1;
            else
                PrefabPanel.Visible = false;
        }

        private void RecordTagEditBox_TextChanged(object sender, EventArgs e)
        {
            if (EditRec.ReadableName.Equals(RecordTagEditBox.Text))
                return;

            EditRec.ReadableName = RecordTagEditBox.Text;
            EditProject.MarkDirty();
        }

        private void UpdateComputedMode()
        {
            var prev = EditRec.Computed;

            if (OriginComboBox.SelectedIndex == 1)
                EditRec.Computed = true;
            else
                EditRec.Computed = false;

            if (prev != EditRec.Computed)
                EditProject.MarkDirty();

            PrefabPanel.Visible = EditRec.Computed;
        }

        private void OriginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComputedMode();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EditProject.Delete(EditRec);
        }

        private void ClampingBehaviorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditRec.Params;

            EditRec.Params = (KnowledgeBase.Record.Parameterization)ClampingBehaviorComboBox.SelectedIndex;

            if (prev != EditRec.Params)
                EditProject.MarkDirty();

            if (EditRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
            {
                RangeConfigurationPanel.Visible = false;
                EnumerationPanel.Visible = true;
            }
            else
            {
                RangeConfigurationPanel.Visible = true;
                EnumerationPanel.Visible = false;
            }
        }

        private void RangeMinimum_ValueChanged(object sender, EventArgs e)
        {
            var prev = EditRec.MinimumValue;

            EditRec.MinimumValue = (double)RangeMinimum.Value;

            if (prev != EditRec.MinimumValue)
                EditProject.MarkDirty();
        }

        private void RangeMaximum_ValueChanged(object sender, EventArgs e)
        {
            var prev = EditRec.MaximumValue;

            EditRec.MaximumValue = (double)RangeMaximum.Value;

            if (prev != EditRec.MaximumValue)
                EditProject.MarkDirty();
        }

        private void PrefabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditRec.Prefab;

            EditRec.Prefab = (KnowledgeBase.Record.Prefabs)(PrefabComboBox.SelectedIndex + 1);

            if (prev != EditRec.Prefab)
                EditProject.MarkDirty();
        }

        private void UpdateEnumeration()
        {
            EnumerationValidComboBox.Items.Clear();

            foreach (var v in EditRec.EnumerationValues)
                EnumerationValidComboBox.Items.Add(v);

            if (EnumerationValidComboBox.Items.Count > 0)
                EnumerationValidComboBox.SelectedIndex = 0;
        }

        private void EditEnumerationButton_Click(object sender, EventArgs e)
        {
            Forms.EnumerationEditorForm.ShowEditor(EditRec.EnumerationValues);
            UpdateEnumeration();
        }
    }
}
