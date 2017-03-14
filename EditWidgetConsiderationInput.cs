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
        private InputAxis EditInputAxis;
        private IInputBroker InputBroker;

        internal EditWidgetConsiderationInput(InputAxis axis, IInputBroker broker)
        {
            InitializeComponent();
            EditInputAxis = axis;
            InputBroker = broker;

            InputValueTrackBar.Minimum = (int)(EditInputAxis.Parameters[0].MinimumValue * 100.0f);
            InputValueTrackBar.Maximum = (int)(EditInputAxis.Parameters[0].MaximumValue * 100.0f);

            int range = InputValueTrackBar.Maximum - InputValueTrackBar.Minimum;
            InputValueTrackBar.SmallChange = range / 10;
            InputValueTrackBar.LargeChange = range / 4;
            InputValueTrackBar.TickFrequency = range / 25;

            InputValueTrackBar.Value = InputValueTrackBar.Minimum + (range / 2);
            InputValueTrackBar_Scroll(null, null);
        }

        public double GetNormalizedValue()
        {
            return ((double)InputValueTrackBar.Value) / ((double)InputValueTrackBar.Maximum - (double)InputValueTrackBar.Minimum);
        }

        private void InputValueTrackBar_Scroll(object sender, EventArgs e)
        {
            string name = EditInputAxis.ReadableName;
            float value = (float)InputValueTrackBar.Value / 100.0f;
            InputCaption.Text = $"{name} ({value:f3})";
            InputBroker.RefreshInputs();
        }
    }
}
