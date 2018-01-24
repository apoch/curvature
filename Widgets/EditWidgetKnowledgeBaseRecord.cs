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
        }
    }
}
