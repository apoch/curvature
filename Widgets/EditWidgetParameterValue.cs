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

            ParamNameLabel.Text = Parameter.GetControllingParameter().ReadableName;

            if (param is InputParameterValueNumeric)
            {
                var pnum = param as InputParameterValueNumeric;

                ValueUpDown.Minimum = (decimal)pnum.ControllingParameter.MinimumValue;
                ValueUpDown.Maximum = (decimal)pnum.ControllingParameter.MaximumValue;
                ValueUpDown.Value = (decimal)pnum.Value;

                InputValueDropDown.Visible = false;
            }
            else if (param is InputParameterValueEnumeration)
            {
                var penum = param as InputParameterValueEnumeration;

                foreach (var valid in penum.ControllingParameter.ValidValues)
                    InputValueDropDown.Items.Add(valid);


                InputValueDropDown.SelectedItem = penum.Key;

                ValueUpDown.Visible = false;
            }
        }

        private void ValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!(Parameter is InputParameterValueNumeric))
                return;

            var param = Parameter as InputParameterValueNumeric;
            var prev = param.Value;

            param.Value = (float)ValueUpDown.Value;

            if (prev != param.Value)
                EditingProject.MarkDirty();
        }

        private void InputValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(Parameter is InputParameterValueEnumeration))
                return;

            var param = Parameter as InputParameterValueEnumeration;
            var prev = param.Key;

            param.Key = InputValueDropDown.SelectedItem as string;

            if (prev != param.Key)
                EditingProject.MarkDirty();
        }
    }
}
