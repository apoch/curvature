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


        internal EditWidgetBehavior(Behavior behavior)
        {
            InitializeComponent();
            EditBehavior = behavior;

            BehaviorNameLabel.Text = "Behavior: " + EditBehavior.ReadableName;

            var inputs = new HashSet<InputAxis>();
            foreach (var consideration in EditBehavior.Considerations)
            {
                inputs.Add(consideration.Input);

                ScoreLayoutPanel.Controls.Add(new EditWidgetConsiderationScore(consideration));
            }

            foreach (var input in inputs)
            {
                InputFlowPanel.Controls.Add(new EditWidgetConsiderationInput(input));
            }
        }
    }
}
