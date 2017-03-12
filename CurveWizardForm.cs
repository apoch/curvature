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
    public partial class CurveWizardForm : Form
    {
        private Consideration EditConsideration;
        private Project EditProject;
        
        public CurveWizardForm(Project project, Consideration consideration)
        {
            InitializeComponent();
            EditConsideration = consideration;
            EditProject = project;

            foreach (InputAxis axis in EditProject.Inputs)
            {
                InputComboBox.Items.Add(axis);
            }

            ResponseCurveEditor.AttachCurve(EditConsideration.Curve);
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            if (WizardTabs.SelectedIndex < WizardTabs.TabCount - 1)
                WizardTabs.SelectedIndex++;
        }
    }
}
