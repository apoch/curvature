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


        internal EditWidgetBehavior(Behavior behavior)
        {
            InitializeComponent();
            EditBehavior = behavior;

            BehaviorNameLabel.Text = "Behavior: " + EditBehavior.ReadableName;

            var inputs = new HashSet<InputAxis>();
            foreach (var consideration in EditBehavior.Considerations)
            {
                inputs.Add(consideration.Input);

                ScoreLayoutPanel.Controls.Add(new EditWidgetConsiderationScore(consideration, this));
            }

            foreach (var input in inputs)
            {
                var widget = new EditWidgetConsiderationInput(input, this);
                widget.Tag = input;
                InputFlowPanel.Controls.Add(widget);
            }
        }

        public float GetInputValue(InputAxis axis)
        {
            foreach (EditWidgetConsiderationInput input in InputFlowPanel.Controls)
            {
                if (input.Tag == axis)
                    return input.GetNormalizedValue();
            }

            return 0.0f;
        }

        public void RefreshInputs()
        {
            foreach (EditWidgetConsiderationScore score in ScoreLayoutPanel.Controls)
            {
                score.Refresh();
            }
        }
    }
}
