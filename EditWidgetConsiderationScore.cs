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
    public partial class EditWidgetConsiderationScore : UserControl
    {
        private Consideration EditConsideration;

        internal EditWidgetConsiderationScore(Consideration consideration)
        {
            InitializeComponent();
            EditConsideration = consideration;

            ConsiderationNameLabel.Text = EditConsideration.ReadableName + " (0.0) x";
        }
    }
}
