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
    public partial class EditWidgetInputAxis : UserControl
    {
        private InputAxis EditedAxis;

        internal EditWidgetInputAxis(InputAxis axis)
        {
            InitializeComponent();
            EditedAxis = axis;

            InputAxisNameLabel.Text = "Input Axis: " + axis.ReadableName;
        }
    }
}
