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
        private InputParameterValue Parameter;

        internal EditWidgetParameterValue(InputParameterValue param)
        {
            InitializeComponent();
            Parameter = param;

            ParamNameLabel.Text = Parameter.ControllingParameter.ReadableName;
            ValueUpDown.Minimum = (decimal)Parameter.ControllingParameter.MinimumValue;
            ValueUpDown.Maximum = (decimal)Parameter.ControllingParameter.MaximumValue;
        }

        private void ValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            Parameter.Value = (float)ValueUpDown.Value;
        }
    }
}
