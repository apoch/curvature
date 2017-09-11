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

            if ((EditingAxis != null) && (EditingAxis.Parameters != null))
            {
                if (EditingAxis.Parameters.Count == 0)
                {
                    InputValueTrackBar.Visible = false;
                }
                else if (EditingAxis.Parameters.Count == 1)
                {
                    InputValueTrackBar.Minimum = (int)(EditingAxis.Parameters[0].MinimumValue * 100.0f);
                    InputValueTrackBar.Maximum = (int)(EditingAxis.Parameters[0].MaximumValue * 100.0f);
                }
                else if (EditingAxis.Parameters.Count == 2)
                {
                    InputValueTrackBar.Minimum = (int)(EditingAxis.Parameters[0].MinimumValue * 100.0f);
                    InputValueTrackBar.Maximum = (int)(EditingAxis.Parameters[1].MaximumValue * 100.0f);
                }
                else
                {
                    // TODO - handle this?
                }
            }

            int range = InputValueTrackBar.Maximum - InputValueTrackBar.Minimum;
            InputValueTrackBar.SmallChange = range / 10;
            InputValueTrackBar.LargeChange = range / 4;
            InputValueTrackBar.TickFrequency = range / 25;

            InputValueTrackBar.Value = InputValueTrackBar.Minimum + (range / 2);
            InputValueTrackBar_Scroll(null, null);
        }

        public double GetRawValue()
        {
            return (double)InputValueTrackBar.Value / 100.0;
        }

        private void InputValueTrackBar_Scroll(object sender, EventArgs e)
        {
            string name = EditingAxis.ReadableName;
            float value = (float)InputValueTrackBar.Value / 100.0f;
            InputCaption.Text = $"{name} ({value:f3})";
            InputBroker.RefreshInputs();
        }
    }
}
