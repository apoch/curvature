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

            if (EditParameter is InputParameterNumeric)
            {
                var p = EditParameter as InputParameterNumeric;

                MinimumValue.Minimum = (decimal)p.MinimumValue;
                MaximumValue.Maximum = (decimal)p.MaximumValue;

                MinimumValue.Value = (decimal)p.MinimumValue;
                MaximumValue.Value = (decimal)p.MaximumValue;
            }
            else if (EditParameter is InputParameterEnumeration)
            {
                MinimumValue.Visible = false;
                MaximumValue.Visible = false;

                MinLabel.Visible = false;
                MaxLabel.Visible = false;

                // TODO - #46 - finish enumerations
                // Add controls for "score 1 when value matches/doesn't match [dropdown]"
            }
        }

        private void MinimumValue_ValueChanged(object sender, EventArgs e)
        {
            var p = EditParameter as InputParameterNumeric;
            if (p == null)
                return;

            var prev = p.MinimumValue;

            p.MinimumValue = (float)MinimumValue.Value;

            if (prev != p.MinimumValue)
                EditProject.MarkDirty();
        }

        private void MaximumValue_ValueChanged(object sender, EventArgs e)
        {
            var p = EditParameter as InputParameterNumeric;
            if (p == null)
                return;

            var prev = p.MaximumValue;

            p.MaximumValue = (float)MaximumValue.Value;

            if (prev != p.MaximumValue)
                EditProject.MarkDirty();
        }
    }
}
