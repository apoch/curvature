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
    public partial class EditWidgetBehavior : UserControl, IInputBroker
    {
        private Behavior EditBehavior;
        private Project EditProject;


        internal delegate void DialogRebuildNeededHandler();
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
            EditProject = project;

            foreach (Control ctl in ScoreLayoutPanel.Controls)
                ctl.Dispose();

            ScoreLayoutPanel.Controls.Clear();


            foreach (Control ctl in InputFlowPanel.Controls)
                ctl.Dispose();

            InputFlowPanel.Controls.Clear();


            EditBehavior = behavior;
            NameEditWidget.Attach("Behavior", EditBehavior, EditProject);
            if (!string.IsNullOrEmpty(EditBehavior.Payload))
                CustomPayload.Text = EditBehavior.Payload;
            else
                CustomPayload.Text = "";

            EditBehavior.DialogRebuildNeeded += Rebuild;

            BehaviorWeightEditBox.Value = (decimal)EditBehavior.Weight;

            ActionComboBox.SelectedIndex = (int)EditBehavior.Action;
            CanTargetSelfCheckBox.Checked = EditBehavior.CanTargetSelf;
            CanTargetOthersCheckBox.Checked = EditBehavior.CanTargetOthers;

            var inputs = new Dictionary<InputAxis, List<InputAxis>>();
            foreach (var consideration in EditBehavior.Considerations)
            {
                if (consideration.Input != null)
                {
                    if (!inputs.ContainsKey(consideration.Input))
                        inputs.Add(consideration.Input, new List<InputAxis>());

                    var clamped = consideration.Input.Clamp(consideration.ParameterValues);
                    inputs[consideration.Input].Add(clamped);

                    ScoreLayoutPanel.Controls.Add(new EditWidgetConsiderationScore(consideration, this));
                }
            }

            foreach (var kvp in inputs)
            {
                InputAxis union = null;
                foreach (var input in kvp.Value)
                    union = input.Union(union);

                if (union == null)
                    continue;

                var widget = new EditWidgetConsiderationInput(union, this);
                widget.Tag = kvp.Key;
                InputFlowPanel.Controls.Add(widget);
            }

            RefreshInputs();
        }

        public double GetInputValue(InputAxis axis)
        {
            foreach (EditWidgetConsiderationInput input in InputFlowPanel.Controls)
            {
                if (input.Tag == axis)
                    return input.GetRawValue();
            }

            return 0.0;
        }

        public double GetInputValue(InputAxis axis, Scenario.Context context)
        {
            return 0.0;
        }

        public void RefreshInputs()
        {
            ScoreListView.Items.Clear();

            double finalScore = (double)BehaviorWeightEditBox.Value;
            double compensationFactor = 1.0 - (1.0 / (double)ScoreLayoutPanel.Controls.Count);

            var weightItem = new ListViewItem(new string[] { $"{finalScore:f3}", "Behavior weight" });
            weightItem.Group = ScoreListView.Groups[1];

            ScoreListView.Items.Add(weightItem);
     
            foreach (EditWidgetConsiderationScore score in ScoreLayoutPanel.Controls)
            {
                score.Refresh();

                string considerationName = score.GetName();
                double considerationScore = score.GetValue();
                double modification = (1.0 - considerationScore) * compensationFactor;

                if (CompensationCheckBox.Checked)
                    considerationScore = considerationScore + (modification * considerationScore);

                var item = new ListViewItem(new string[] { $"{considerationScore:f3}", $"{considerationName}" });
                item.Group = ScoreListView.Groups[0];

                ScoreListView.Items.Add(item);
                finalScore *= considerationScore;
            }

            if (MomentumBonusCheckBox.Checked)
            {
                finalScore *= 1.25;

                var item = new ListViewItem(new string[] { "1.250", "Momentum bonus" });
                item.Group = ScoreListView.Groups[1];

                ScoreListView.Items.Add(item);
            }

            FinalScoreLabel.Text = $"Final Score = {finalScore:f3}";
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

        internal void Rebuild()
        {
            EditBehavior.DialogRebuildNeeded -= Rebuild;
            Attach(EditBehavior, EditProject);

            DialogRebuildNeeded?.Invoke();
        }

        private void MomentumBonusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshInputs();
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

            RefreshInputs();
        }

        private void CompensationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshInputs();
        }
    }
}
