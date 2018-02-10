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
    public partial class EditWidgetConsiderationInput : UserControl
    {
        private InputAxis EditingAxis;
        private IInputBroker InputBroker;

        internal EditWidgetConsiderationInput(InputAxis axis, IInputBroker broker)
        {
            InitializeComponent();
            EditingAxis = axis;
            InputBroker = broker;

            InputValueTrackBar.Minimum = 0;
            InputValueTrackBar.Maximum = 100;

            InputValueDropDown.Visible = false;

            if ((EditingAxis != null) && (EditingAxis.Parameters != null))
            {
                if (EditingAxis.Parameters.Count == 1)
                {
                    var rawparam = EditingAxis.Parameters[0];
                    if (rawparam is InputParameterNumeric)
                    {
                        var numericparam = rawparam as InputParameterNumeric;
                        InputValueTrackBar.Minimum = (int)(numericparam.MinimumValue * 100.0f);
                        InputValueTrackBar.Maximum = (int)(numericparam.MaximumValue * 100.0f);
                    }
                    else if (rawparam is InputParameterEnumeration)
                    {
                        InputValueTrackBar.Visible = false;
                        InputValueDropDown.Visible = true;
                        InputValueDropDown.Items.Clear();

                        var penum = rawparam as InputParameterEnumeration;
                        foreach (var valid in penum.ValidValues)
                            InputValueDropDown.Items.Add(valid);

                        if (penum.ValidValues.Count > 0)
                            InputValueDropDown.SelectedIndex = 0;
                    }
                }
                else if (EditingAxis.Parameters.Count == 2)
                {
                    InputValueTrackBar.Minimum = (int)((EditingAxis.Parameters[0] as InputParameterNumeric).MinimumValue * 100.0f);
                    InputValueTrackBar.Maximum = (int)((EditingAxis.Parameters[1] as InputParameterNumeric).MaximumValue * 100.0f);
                }
                else
                {
                    InputValueTrackBar.Visible = false;
                }
            }

            if (InputValueTrackBar.Visible)
            {
                int range = InputValueTrackBar.Maximum - InputValueTrackBar.Minimum;
                InputValueTrackBar.SmallChange = range / 10;
                InputValueTrackBar.LargeChange = range / 4;
                InputValueTrackBar.TickFrequency = range / 25;

                InputValueTrackBar.Value = InputValueTrackBar.Minimum + (range / 2);
                InputValueTrackBar_Scroll(null, null);
            }
        }

        public double GetRawValue()
        {
            if ((EditingAxis.Parameters.Count == 1) && (EditingAxis.Parameters[0] is InputParameterEnumeration))
                throw new Exception();

            return (double)InputValueTrackBar.Value / 100.0;
        }

        public string GetStringValue()
        {
            if ((EditingAxis.Parameters.Count != 1) || !(EditingAxis.Parameters[0] is InputParameterEnumeration))
                return null;

            if (InputValueDropDown.SelectedIndex < 0)
                return null;

            return InputValueDropDown.SelectedItem as string;
        }

        private void InputValueTrackBar_Scroll(object sender, EventArgs e)
        {
            InputCaption.Text = $"{EditingAxis.ReadableName} ({GetRawValue():f3})";
            InputBroker.RefreshInputs();
        }

        private void InputValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputCaption.Text = $"{EditingAxis.ReadableName}";
            InputBroker.RefreshInputs();
        }
    }
}
