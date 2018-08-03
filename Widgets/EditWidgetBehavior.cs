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
        private Behavior EditingBehavior;
        private Project EditingProject;


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
            if (EditingBehavior != null)
                EditingBehavior.DialogRebuildNeeded -= Rebuild;

            EditingProject = project;
            EditingBehavior = behavior;

            if (!string.IsNullOrEmpty(EditingBehavior.Payload))
                CustomPayload.Text = EditingBehavior.Payload;
            else
                CustomPayload.Text = "";

            EditingBehavior.DialogRebuildNeeded += Rebuild;

            BehaviorWeightEditBox.Value = (decimal)EditingBehavior.Weight;

            ActionComboBox.SelectedIndex = (int)EditingBehavior.Action;
            CanTargetSelfCheckBox.Checked = EditingBehavior.CanTargetSelf;
            CanTargetOthersCheckBox.Checked = EditingBehavior.CanTargetOthers;
        }


        internal void Rebuild()
        {
            Attach(EditingBehavior, EditingProject);
            DialogRebuildNeeded?.Invoke(EditingBehavior);
        }




        private void ActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditingBehavior != null)
            {
                var prev = EditingBehavior.Action;
                EditingBehavior.Action = (Behavior.ActionType)ActionComboBox.SelectedIndex;
                if (prev != EditingBehavior.Action)
                    EditingProject.MarkDirty();
            }
        }

        private void CustomPayload_TextChanged(object sender, EventArgs e)
        {
            if (EditingBehavior != null)
            {
                var prev = EditingBehavior.Payload;
                EditingBehavior.Payload = CustomPayload.Text;
                if (prev != EditingBehavior.Payload)
                    EditingProject.MarkDirty();
            }
        }

        private void BehaviorWeightEditBox_ValueChanged(object sender, EventArgs e)
        {
            if (EditingBehavior != null)
            {
                var prev = EditingBehavior.Weight;
                EditingBehavior.Weight = (double)BehaviorWeightEditBox.Value;
                if (prev != EditingBehavior.Weight)
                    EditingProject.MarkDirty();
            }
        }


        private void CanTargetSelfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditingBehavior != null)
            {
                var prev = EditingBehavior.CanTargetSelf;
                EditingBehavior.CanTargetSelf = CanTargetSelfCheckBox.Checked;
                if (prev != EditingBehavior.CanTargetSelf)
                    EditingProject.MarkDirty();
            }
        }

        private void CanTargetOthersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EditingBehavior != null)
            {
                var prev = EditingBehavior.CanTargetOthers;
                EditingBehavior.CanTargetOthers = CanTargetOthersCheckBox.Checked;
                if (EditingBehavior.CanTargetOthers != prev)
                    EditingProject.MarkDirty();
            }
        }
    }
}
