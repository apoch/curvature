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
        private ResponseCurve EditCurve = null;
        private Project EditProject = null;


        public EditWidgetCurveAdvanced()
        {
            InitializeComponent();
        }

        internal void AttachCurve(ResponseCurve curve, Project project)
        {
            EditCurve = curve;
            EditProject = project;

            ResponseCurveEditor.AttachCurve(curve, project);
        }
    }
}
