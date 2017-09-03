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
        private Consideration EditConsideration;
        private IInputBroker InputBroker;

        internal EditWidgetConsiderationInput(Consideration consideration, IInputBroker broker)
        {
            InitializeComponent();
            EditConsideration = consideration;
            InputBroker = broker;

            InputValueTrackBar.Minimum = 0;
            InputValueTrackBar.Maximum = 100;

            if ((EditConsideration != null) && (EditConsideration.Input != null))
            {
                if (EditConsideration.Input.Parameters.Count == 0)
                {
                    InputValueTrackBar.Visible = false;
                }
                else if (EditConsideration.Input.Parameters.Count == 1)
                {
                    InputValueTrackBar.Minimum = (int)(EditConsideration.Input.Parameters[0].MinimumValue * 100.0f);
                    InputValueTrackBar.Maximum = (int)(EditConsideration.Input.Parameters[0].MaximumValue * 100.0f);
                }
                else if (EditConsideration.Input.Parameters.Count == 2)
                {
                    if (EditConsideration.ParameterValues == null)
                        EditConsideration.GenerateParameterValuesFromInput();

                    InputValueTrackBar.Minimum = (int)(EditConsideration.ParameterValues[0].Value * 100.0f);
                    InputValueTrackBar.Maximum = (int)(EditConsideration.ParameterValues[1].Value * 100.0f);
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

        public double GetNormalizedValue()
        {
            return ((double)InputValueTrackBar.Value - (double)InputValueTrackBar.Minimum) / ((double)InputValueTrackBar.Maximum - (double)InputValueTrackBar.Minimum);
        }

        private void InputValueTrackBar_Scroll(object sender, EventArgs e)
        {
            string name = EditConsideration.Input?.ReadableName;
            float value = (float)InputValueTrackBar.Value / 100.0f;
            InputCaption.Text = $"{name} ({value:f3})";
            InputBroker.RefreshInputs();
        }
    }
}
