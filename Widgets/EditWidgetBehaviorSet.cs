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
        }

        public void Attach(BehaviorSet set, Project project)
        {
            EditSet = set;

            NameEditWidget.Attach("Behavior Set", set);

            EnabledBehaviorsListBox.Items.Clear();
            foreach (Behavior b in project.Behaviors)
            {
                EnabledBehaviorsListBox.Items.Add(b, EditSet.EnabledBehaviors.Contains(b));
            }

            RefreshInputControls();

            BehaviorScoresListView.MouseDoubleClick += (e, args) =>
            {
                var item = BehaviorScoresListView.GetItemAt(args.Location.X, args.Location.Y);
                if (item == null)
                    return;

                // TODO - activate UI for editing the relevant behavior
            };
        }

        public double GetInputValue(InputAxis axis)
        {
            foreach (EditWidgetConsiderationInput input in InputFlowPanel.Controls)
            {
                if (input.Tag == axis)
                    return input.GetNormalizedValue();
            }

            return 0.0;
        }

        public double GetInputValue(InputAxis axis, Scenario.Context context)
        {
            if (context == null)
                return GetInputValue(axis);

            // TODO - figure out what input this should link to and retrieve the corresponding value
            return 0.0;
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


            var inputs = new HashSet<InputAxis>();

            foreach (Behavior b in EnabledBehaviorsListBox.CheckedItems)
            {
                foreach (Consideration c in b.Considerations)
                {
                    if (c.Input == null || c.Input.KBRecord == null)
                        continue;

                    if (!inputs.Contains(c.Input))
                        inputs.Add(c.Input);
                }
            }

            foreach (var rec in inputs)
            {
                var ctl = new EditWidgetConsiderationInput(rec, this);
                ctl.Tag = rec;
                InputFlowPanel.Controls.Add(ctl);
            }

            RefreshInputs();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshInputControls();
            RefreshTimer.Enabled = false;
        }
    }
}
