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
        private Project EditingProject;


        internal EditWidgetParameterValue(InputParameterValue param, Project project)
        {
            InitializeComponent();

            EditingProject = project;
            Parameter = param;

            ParamNameLabel.Text = Parameter.ControllingParameter.ReadableName;
            ValueUpDown.Minimum = (decimal)Parameter.ControllingParameter.MinimumValue;
            ValueUpDown.Maximum = (decimal)Parameter.ControllingParameter.MaximumValue;
            ValueUpDown.Value = (decimal)Parameter.Value;
        }

        private void ValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            var prev = Parameter.Value;

            Parameter.Value = (float)ValueUpDown.Value;

            if (prev != Parameter.Value)
                EditingProject.MarkDirty();
        }
    }
}
