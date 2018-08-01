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
    public partial class EditWidgetBehavior : UserControl
    {
        private Behavior EditBehavior;
        private Project EditProject;


        internal delegate void DialogRebuildNeededHandler(Behavior editedContent);
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetBehavior()
        {
            InitializeComponent();

            foreach (Behavior.ActionType e in Enum.GetValues(typeof(Behavior.ActionType)))
            {
                ActionComboBox.Items.Add(e.GetDescription());
            }

            ActionComboBox.SelectedIndex = 0;
        }

        internal void Attach(Behavior behavior, Project project)
        {
            if (EditBehavior != null)
                EditBehavior.DialogRebuildNeeded -= Rebuild;

            EditProject = project;
            EditBehavior = behavior;

            if (!string.IsNullOrEmpty(EditBehavior.Payload))
                CustomPayload.Text = EditBehavior.Payload;
            else
                CustomPayload.Text = "";

            EditBehavior.DialogRebuildNeeded += Rebuild;

            BehaviorWeightEditBox.Value = (decimal)EditBehavior.Weight;

            ActionComboBox.SelectedIndex = (int)EditBehavior.Action;
            CanTargetSelfCheckBox.Checked = EditBehavior.CanTargetSelf;
            CanTargetOthersCheckBox.Checked = EditBehavior.CanTargetOthers;
        }


        internal void Rebuild()
        {
            EditBehavior.DialogRebuildNeeded -= Rebuild;
            Attach(EditBehavior, EditProject);

            DialogRebuildNeeded?.Invoke(EditBehavior);
        }




        private void ActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditBehavior != null)
            {
                var prev = EditBehavior.Action;
                EditBehavior.Action = (Behavior.ActionType)ActionComboBox.SelectedIndex;
                if (prev != EditBehavior.Action)
                    EditProject.MarkDirty();
            }
        }

        private void CustomPayload_TextChanged(object sender, EventArgs e)
        {
            if (EditBehavior != null)
            {
                var prev = EditBehavior.Payload;
                EditBehavior.Payload = CustomPayload.Text;
                if (prev != EditBehavior.Payload)
                    EditProject.MarkDirty();
            }
        }

        private void BehaviorWeightEditBox_ValueChanged(object sender, EventArgs e)
        {
            if (EditBehavior != null)
            {
                var prev = EditBehavior.Weight;
                EditBehavior.Weight = (double)BehaviorWeightEditBox.Value;
                if (prev != EditBehavior.Weight)
                    EditProject.MarkDirty();
            }
        }


        private void CanTargetSelfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditBehavior != null)
            {
                var prev = EditBehavior.CanTargetSelf;
                EditBehavior.CanTargetSelf = CanTargetSelfCheckBox.Checked;
                if (prev != EditBehavior.CanTargetSelf)
                    EditProject.MarkDirty();
            }
        }

        private void CanTargetOthersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditBehavior != null)
            {
                var prev = EditBehavior.CanTargetOthers;
                EditBehavior.CanTargetOthers = CanTargetOthersCheckBox.Checked;
                if (EditBehavior.CanTargetOthers != prev)
                    EditProject.MarkDirty();
            }
        }
    }
}
