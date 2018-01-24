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
        private Project EditProject;


        internal EditWidgetParameter(InputParameter param, Project project)
        {
            InitializeComponent();

            EditProject = project;
            EditParameter = param;

            ParameterNameLabel.Text = EditParameter.ReadableName;

            MinimumValue.Minimum = (decimal)EditParameter.MinimumValue;
            MaximumValue.Maximum = (decimal)EditParameter.MaximumValue;

            MinimumValue.Value = (decimal)EditParameter.MinimumValue;
            MaximumValue.Value = (decimal)EditParameter.MaximumValue;
        }

        private void MinimumValue_ValueChanged(object sender, EventArgs e)
        {
            var prev = EditParameter.MinimumValue;

            EditParameter.MinimumValue = (float)MinimumValue.Value;

            if (prev != EditParameter.MinimumValue)
                EditProject.MarkDirty();
        }

        private void MaximumValue_ValueChanged(object sender, EventArgs e)
        {
            var prev = EditParameter.MaximumValue;

            EditParameter.MaximumValue = (float)MaximumValue.Value;

            if (prev != EditParameter.MaximumValue)
                EditProject.MarkDirty();
        }
    }
}
