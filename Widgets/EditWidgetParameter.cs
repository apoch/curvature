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
    public partial class EditWidgetParameter : UserControl
    {
        private InputParameter EditParameter;

        internal EditWidgetParameter(InputParameter param)
        {
            InitializeComponent();
            EditParameter = param;

            ParameterNameLabel.Text = EditParameter.ReadableName;

            MinimumValue.Minimum = (decimal)EditParameter.MinimumValue;
            MaximumValue.Maximum = (decimal)EditParameter.MaximumValue;

            MinimumValue.Value = (decimal)EditParameter.MinimumValue;
            MaximumValue.Value = (decimal)EditParameter.MaximumValue;
        }

        private void MinimumValue_ValueChanged(object sender, EventArgs e)
        {
            EditParameter.MinimumValue = (float)MinimumValue.Value;
        }

        private void MaximumValue_ValueChanged(object sender, EventArgs e)
        {
            EditParameter.MaximumValue = (float)MaximumValue.Value;
        }
    }
}
