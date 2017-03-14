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
        private HashSet<Behavior> EditBehaviors;

        public EditWidgetBehaviorSet(Project project, string setname, HashSet<Behavior> behaviors)
        {
            InitializeComponent();
            EditBehaviors = behaviors;

            EnabledBehaviorsListBox.ItemCheck += (e, args) =>
            {
                RefreshTimer.Enabled = true;
            };

            BehaviorSetNameLabel.Text = $"Behavior Set: {setname}";

            foreach (Behavior b in project.Behaviors)
            {
                EnabledBehaviorsListBox.Items.Add(b, EditBehaviors.Contains(b));
            }

            RefreshInputControls();
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

        public void RefreshInputs()
        {
            BehaviorScoresListView.Items.Clear();
            foreach (Behavior b in EnabledBehaviorsListBox.CheckedItems)
            {
                double score = b.Score(this);

                var item = new ListViewItem(new string[] { b.ReadableName, $"{score:f3}" });
                BehaviorScoresListView.Items.Add(item);
            }
        }

        private void RefreshInputControls()
        {
            foreach (Control ctl in InputFlowPanel.Controls)
                ctl.Dispose();

            InputFlowPanel.Controls.Clear();


            var inputs = new Dictionary<string, InputAxis>();

            foreach (Behavior b in EnabledBehaviorsListBox.CheckedItems)
            {
                foreach (Consideration c in b.Considerations)
                {
                    if (inputs.ContainsKey(c.Input.KBRecord.ReadableName))
                        inputs.Add(c.Input.KBRecord.ReadableName, c.Input.Union(inputs[c.Input.KBRecord.ReadableName]));
                    else
                        inputs.Add(c.Input.KBRecord.ReadableName, c.Input);
                }
            }

            foreach (var rec in inputs)
            {
                var ctl = new EditWidgetConsiderationInput(rec.Value, this);
                ctl.Tag = rec.Value;
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
