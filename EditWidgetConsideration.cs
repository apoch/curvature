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
    public partial class EditWidgetConsideration : UserControl
    {
        private Consideration EditConsideration;

        internal EditWidgetConsideration(Project project, Consideration editConsideration)
        {
            InitializeComponent();
            EditConsideration = editConsideration;

            ConsiderationNameLabel.Text = "Consideration: " + EditConsideration.ReadableName;

            foreach (InputAxis axis in project.Inputs)
            {
                InputAxisDropdown.Items.Add(axis);
            }

            InputAxisDropdown.SelectedItem = EditConsideration.Input;
            ResponseCurveEditor.AttachCurve(EditConsideration.Curve);
        }
    }
}
