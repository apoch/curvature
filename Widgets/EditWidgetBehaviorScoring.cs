using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature.Widgets
{
    public partial class EditWidgetBehaviorScoring : UserControl, IInputBroker
    {
        private Behavior EditBehavior;
        private Project EditProject;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetBehaviorScoring()
        {
            InitializeComponent();
        }


        internal void Attach(Behavior behavior, Project project)
        {
            if (EditBehavior != null)
                EditBehavior.DialogRebuildNeeded -= Rebuild;

            EditProject = project;

            foreach (Control ctl in ScoreLayoutPanel.Controls)
                ctl.Dispose();

            ScoreLayoutPanel.Controls.Clear();


            foreach (Control ctl in InputFlowPanel.Controls)
                ctl.Dispose();

            InputFlowPanel.Controls.Clear();


            EditBehavior = behavior;
            EditBehavior.DialogRebuildNeeded += Rebuild;


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

        internal void Rebuild()
        {
            EditBehavior.DialogRebuildNeeded -= Rebuild;
            Attach(EditBehavior, EditProject);

            DialogRebuildNeeded?.Invoke();
        }


        public void RefreshInputs()
        {
            ScoreListView.Items.Clear();

            double finalScore = EditBehavior.Weight;
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

        public double GetInputValue(Consideration consideration)
        {
            foreach (EditWidgetConsiderationInput input in InputFlowPanel.Controls)
            {
                if (input.Tag == consideration.Input)
                {
                    if (consideration.Input.KBRec.Params == KnowledgeBase.Record.Parameterization.Enumeration)
                    {
                        var p = consideration.Input.Parameters[0] as InputParameterEnumeration;
                        var v = consideration.ParameterValues[0] as InputParameterValueEnumeration;
                        var comparison = string.Compare(v.Key, input.GetStringValue(), StringComparison.CurrentCultureIgnoreCase);

                        if (p.ScoreOnMatch)
                        {
                            if (comparison == 0)
                                return 1.0;

                            return 0.0;
                        }
                        else
                        {
                            if (comparison != 0)
                                return 1.0;

                            return 0.0;
                        }
                    }

                    return input.GetRawValue();
                }
            }

            return 0.0;
        }

        public double GetInputValue(Consideration consideration, Scenario.Context context)
        {
            return 0.0;
        }
    }
}
