using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public partial class CurvePresetForm : Form
    {
        private ResponseCurve EditingCurve;

        public CurvePresetForm(ResponseCurve editcurve)
        {
            InitializeComponent();
            EditingCurve = editcurve;
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            CurvePresetsWidget.Apply(EditingCurve);
            Close();
        }
    }
}
