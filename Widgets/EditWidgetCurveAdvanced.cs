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
    public partial class EditWidgetCurveAdvanced : UserControl
    {
        public EditWidgetCurveAdvanced()
        {
            InitializeComponent();
        }

        internal void AttachCurve(ResponseCurve curve, Project project)
        {
            ResponseCurveEditor.AttachCurve(curve, project);
        }
    }
}
