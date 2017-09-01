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
    public partial class EditWidgetParameterValue : UserControl
    {
        private InputParameter Parameter;

        internal EditWidgetParameterValue(InputParameter param)
        {
            InitializeComponent();
            Parameter = param;

            ParamNameLabel.Text = Parameter.ReadableName;
            ValueUpDown.Minimum = (decimal)Parameter.MinimumValue;
            ValueUpDown.Maximum = (decimal)Parameter.MaximumValue;
        }

        private void ValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            // TODO - propagate input values back up to parent widgets
        }
    }
}
