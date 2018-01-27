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
    public partial class EditWidgetKnowledgeBaseParameter : UserControl
    {
        public EditWidgetKnowledgeBaseParameter(double initialValue, double minimum, double maximum)
        {
            InitializeComponent();

            ValueUpDown.Minimum = (decimal)minimum;
            ValueUpDown.Maximum = (decimal)maximum;
            ValueUpDown.Value = (decimal)initialValue;


            ValueSlider.Minimum = (int)(minimum * 100.0);
            ValueSlider.Maximum = (int)(maximum * 100.0);
            ValueSlider.Value = (int)(initialValue * 100.0);

            int range = ValueSlider.Maximum - ValueSlider.Minimum;
            ValueSlider.SmallChange = range / 10;
            ValueSlider.LargeChange = range / 4;
            ValueSlider.TickFrequency = range / 25;

            ValueSlider.ValueChanged += (e, args) =>
            {
                ValueUpDown.Value = (decimal)ValueSlider.Value / 100;
            };

            ValueUpDown.ValueChanged += (e, args) =>
            {
                int newval = (int)(ValueUpDown.Value * 100);
                if (ValueSlider.Value != newval)
                    ValueSlider.Value = newval;
            };
        }

        public double GetValue()
        {
            return (double)ValueUpDown.Value;
        }
    }
}
