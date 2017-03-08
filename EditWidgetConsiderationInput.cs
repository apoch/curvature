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

        internal EditWidgetConsiderationInput(InputAxis axis)
        {
            InitializeComponent();
            EditInputAxis = axis;

            InputCaption.Text = EditInputAxis.ReadableName;
        }
    }
}
