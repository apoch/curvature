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
        private Project EditedProject;

        internal EditWidgetInputAxis(Project project, InputAxis axis)
        {
            InitializeComponent();
            EditedAxis = axis;
            EditedProject = project;

            InputAxisNameLabel.Text = "Input Axis: " + axis.ReadableName;
            InputTypeComboBox.SelectedIndex = (int)axis.Origin;
        }

        private void InputTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectComputedProperties = false;
            DataSourceComboBox.Items.Clear();

            if (InputTypeComboBox.SelectedIndex == 0 || InputTypeComboBox.SelectedIndex == 1)
            {
                selectComputedProperties = false;
            }
            else if (InputTypeComboBox.SelectedIndex == 2)
            {
                selectComputedProperties = true;
            }

            foreach (var rec in EditedProject.KB.Records)
            {
                if (rec.Computed == selectComputedProperties)
                    DataSourceComboBox.Items.Add(rec);
            }

            DataSourceComboBox.SelectedItem = EditedAxis.KBRecord;
        }
    }
}
