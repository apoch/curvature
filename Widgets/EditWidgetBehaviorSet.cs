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
    public partial class EditWidgetBehaviorSet : UserControl, IInputBroker
    {
        private BehaviorSet EditSet;
        private Project EditProject;

        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        internal delegate void AutoNavigationRequestedHandler(Behavior behavior);
        internal event AutoNavigationRequestedHandler AutoNavigationRequested;


        public EditWidgetBehaviorSet()
        {
            InitializeComponent();

            EnabledBehaviorsListBox.ItemCheck += (e, args) =>
            {
                RefreshTimer.Enabled = true;
                if (EditSet != null)
                {
                    var behavior = EnabledBehaviorsListBox.Items[args.Index] as Behavior;

                    if (args.NewValue == CheckState.Checked)
                        EditSet.EnabledBehaviors.Add(behavior);
                    else
                        EditSet.EnabledBehaviors.Remove(behavior);
                }
            };

            BehaviorScoresListView.MouseDoubleClick += (e, args) =>
            {
                var item = BehaviorScoresListView.GetItemAt(args.Location.X, args.Location.Y);
                if (item == null)
                    return;

                AutoNavigationRequested?.Invoke(item.Tag as Behavior);
            };
        }

        public void Attach(BehaviorSet set, Project project)
        {
            EditSet = set;
            EditProject = project;

            EditSet.DialogRebuildNeeded += Rebuild;

            NameEditWidget.Attach("Behavior Set", set);

            EnabledBehaviorsListBox.Items.Clear();
            foreach (Behavior b in project.Behaviors)
            {
                EnabledBehaviorsListBox.Items.Add(b, EditSet.EnabledBehaviors.Contains(b));
            }

            RefreshInputControls();
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
            if (context == null)
                return GetInputValue(axis);

            throw new NotImplementedException();
        }

        public void RefreshInputs()
        {
            double winscore = 0.0;
            Behavior winbehavior = null;

            BehaviorScoresListView.Items.Clear();
            foreach (Behavior b in EnabledBehaviorsListBox.CheckedItems)
            {
                var score = b.Score(this, null);
                if (score.FinalScore > winscore)
                {
                    winscore = score.FinalScore;
                    winbehavior = b;
                }

                var item = new ListViewItem(new string[] { b.ReadableName, $"{b.Weight:f3}", $"{score.FinalScore:f3}" });
                item.Tag = b;
                BehaviorScoresListView.Items.Add(item);
            }

            if (winbehavior != null)
            {
                WinningBehaviorLabel.Text = $"Winner: {winbehavior.ReadableName} ({winscore:f3})";
            }
            else
            {
                WinningBehaviorLabel.Text = "";
            }
        }

        private void RefreshInputControls()
        {
            foreach (Control ctl in InputFlowPanel.Controls)
                ctl.Dispose();

            InputFlowPanel.Controls.Clear();

            var inputs = new Dictionary<InputAxis, List<InputAxis>>();

            foreach (Behavior b in EnabledBehaviorsListBox.CheckedItems)
            {
                foreach (Consideration c in b.Considerations)
                {
                    if (c.Input == null || c.Input.KBRec == null)
                        continue;

                    if (!inputs.ContainsKey(c.Input))
                        inputs.Add(c.Input, new List<InputAxis>());

                    var clamped = c.Input.Clamp(c.ParameterValues);
                    inputs[c.Input].Add(clamped);
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

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshInputControls();
            RefreshTimer.Enabled = false;
        }


        internal void Rebuild()
        {
            EditSet.DialogRebuildNeeded -= Rebuild;
            Attach(EditSet, EditProject);

            DialogRebuildNeeded?.Invoke();
        }
    }
}
