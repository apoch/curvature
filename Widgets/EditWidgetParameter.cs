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

                NumericPanel.Visible = true;
                EnumerationPanel.Visible = false;
            }
            else if (EditParameter is InputParameterEnumeration)
            {
                var p = EditParameter as InputParameterEnumeration;

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

        private void EnumerationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = EditParameter as InputParameterEnumeration;
            if (p == null)
                return;

            var prev = p.ScoreOnMatch;

            p.ScoreOnMatch = (EnumerationDropDown.SelectedIndex == 0);

            if (prev != p.ScoreOnMatch)
                EditProject.MarkDirty();
        }
    }
}
