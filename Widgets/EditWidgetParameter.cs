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
        private InputParameter EditingParameter;
        private Project EditingProject;


        internal EditWidgetParameter(InputParameter param, Project project)
        {
            InitializeComponent();

            EditingProject = project;
            EditingParameter = param;

            ParameterNameLabel.Text = EditingParameter.ReadableName;

            if (EditingParameter is InputParameterNumeric)
            {
                var p = EditingParameter as InputParameterNumeric;

                MinimumValue.Minimum = (decimal)p.MinimumValue;
                MaximumValue.Maximum = (decimal)p.MaximumValue;

                MinimumValue.Value = (decimal)p.MinimumValue;
                MaximumValue.Value = (decimal)p.MaximumValue;

                NumericPanel.Visible = true;
                EnumerationPanel.Visible = false;
            }
            else if (EditingParameter is InputParameterEnumeration)
            {
                var p = EditingParameter as InputParameterEnumeration;

                if (p.ScoreOnMatch)
                    EnumerationDropDown.SelectedIndex = 0;
                else
                    EnumerationDropDown.SelectedIndex = 1;

                NumericPanel.Visible = false;
                EnumerationPanel.Visible = true;
            }
        }

        private void MinimumValue_ValueChanged(object sender, EventArgs e)
        {
            var p = EditingParameter as InputParameterNumeric;
            if (p == null)
                return;

            var prev = p.MinimumValue;

            p.MinimumValue = (float)MinimumValue.Value;

            if (prev != p.MinimumValue)
                EditingProject.MarkDirty();
        }

        private void MaximumValue_ValueChanged(object sender, EventArgs e)
        {
            var p = EditingParameter as InputParameterNumeric;
            if (p == null)
                return;

            var prev = p.MaximumValue;

            p.MaximumValue = (float)MaximumValue.Value;

            if (prev != p.MaximumValue)
                EditingProject.MarkDirty();
        }

        private void EnumerationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = EditingParameter as InputParameterEnumeration;
            if (p == null)
                return;

            var prev = p.ScoreOnMatch;

            p.ScoreOnMatch = (EnumerationDropDown.SelectedIndex == 0);

            if (prev != p.ScoreOnMatch)
                EditingProject.MarkDirty();
        }
    }
}
