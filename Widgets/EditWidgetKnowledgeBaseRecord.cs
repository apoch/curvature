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
        private KnowledgeBase.Record EditingRec;
        private Project EditingProject;

        internal EditWidgetKnowledgeBaseRecord(KnowledgeBase.Record rec, Project project)
        {
            InitializeComponent();
            EditingRec = rec;
            EditingProject = project;

            RecordTagEditBox.Text = EditingRec.ReadableName;

            if (EditingRec.Computed)
                OriginComboBox.SelectedIndex = 1;
            else
                OriginComboBox.SelectedIndex = 0;

            ClampingBehaviorComboBox.SelectedIndex = (int)EditingRec.Params;

            if (EditingRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
            {
                UpdateEnumeration();
            }
            else
            {
                RangeMinimum.Value = (decimal)EditingRec.MinimumValue;
                RangeMaximum.Value = (decimal)EditingRec.MaximumValue;
            }

            if (EditingRec.Prefab != KnowledgeBase.Record.Prefabs.NoPrefab)
                PrefabComboBox.SelectedIndex = (int)(EditingRec.Prefab) - 1;
            else
                PrefabPanel.Visible = false;

            Paint += (obj, args) =>
            {
                args.Graphics.DrawLine(SystemPens.ButtonShadow, 0, Height - 1, Width, Height - 1);
            };
        }

        private void RecordTagEditBox_TextChanged(object sender, EventArgs e)
        {
            if (EditingRec.ReadableName.Equals(RecordTagEditBox.Text))
                return;

            EditingRec.ReadableName = RecordTagEditBox.Text;
            EditingProject.MarkDirty();
        }

        private void UpdateComputedMode()
        {
            var prev = EditingRec.Computed;

            if (OriginComboBox.SelectedIndex == 1)
                EditingRec.Computed = true;
            else
                EditingRec.Computed = false;

            if (prev != EditingRec.Computed)
                EditingProject.MarkDirty();

            PrefabPanel.Visible = EditingRec.Computed;
        }

        private void OriginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComputedMode();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EditingProject.Delete(EditingRec);
        }

        private void ClampingBehaviorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditingRec.Params;

            EditingRec.Params = (KnowledgeBase.Record.Parameterization)ClampingBehaviorComboBox.SelectedIndex;

            if (prev != EditingRec.Params)
                EditingProject.MarkDirty();

            if (EditingRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
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
            var prev = EditingRec.MinimumValue;

            EditingRec.MinimumValue = (double)RangeMinimum.Value;

            if (prev != EditingRec.MinimumValue)
                EditingProject.MarkDirty();
        }

        private void RangeMaximum_ValueChanged(object sender, EventArgs e)
        {
            var prev = EditingRec.MaximumValue;

            EditingRec.MaximumValue = (double)RangeMaximum.Value;

            if (prev != EditingRec.MaximumValue)
                EditingProject.MarkDirty();
        }

        private void PrefabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditingRec.Prefab;

            EditingRec.Prefab = (KnowledgeBase.Record.Prefabs)(PrefabComboBox.SelectedIndex + 1);

            if (prev != EditingRec.Prefab)
                EditingProject.MarkDirty();
        }

        private void UpdateEnumeration()
        {
            EnumerationValidComboBox.Items.Clear();

            foreach (var v in EditingRec.EnumerationValues)
                EnumerationValidComboBox.Items.Add(v);

            if (EnumerationValidComboBox.Items.Count > 0)
                EnumerationValidComboBox.SelectedIndex = 0;
        }

        private void EditEnumerationButton_Click(object sender, EventArgs e)
        {
            Forms.EnumerationEditorForm.ShowEditor(EditingRec.EnumerationValues);
            UpdateEnumeration();
        }
    }
}
