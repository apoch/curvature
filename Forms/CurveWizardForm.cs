using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curvature.Widgets;

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

            InputComboBox.SelectedItem = EditConsideration.Input;

            ConsiderationNameEditBox.Text = EditConsideration.ReadableName;

            AdvancedCurvesWidget.AttachCurve(EditConsideration.Curve, EditProject);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            CopyControlsToConsideration();
            Close();
        }

        private void CopyControlsToConsideration()
        {
            EditConsideration.Rename(ConsiderationNameEditBox.Text);
            EditConsideration.Input = InputComboBox.SelectedItem as InputAxis;

            if (ResponseCurveAdvancedTabs.SelectedTab == ResponseCurvePresetsTab)
            {
                PresetCurvesWidget.Apply(EditConsideration.Curve);
            }
        }

        private void InputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var axis = InputComboBox.SelectedItem as InputAxis;
            EditConsideration.Input = axis;

            ParameterInputHintLabel.Text = "The input being configured is: " + axis.ReadableName;

            foreach (Control c in ParamFlowPanel.Controls)
                c.Dispose();

            ParamFlowPanel.Controls.Clear();

            EditConsideration.GenerateParameterValuesFromInput();
            foreach (var param in EditConsideration.ParameterValues)
                ParamFlowPanel.Controls.Add(new EditWidgetParameterValue(param, EditProject));

            if (EditConsideration.ParameterValues.Count == 0)
                ParameterHintSpecificsLabel.Text = "This input has no parameters, so go ahead and click Next to move on.";
            else if (EditConsideration.ParameterValues.Count == 1)
            {
                if (EditConsideration.ParameterValues[0] is InputParameterValueNumeric)
                    ParameterHintSpecificsLabel.Text = "This input has one parameter. By default, input numbers are divided by this value before being processed through a response curve.";
                else
                {
                    if ((EditConsideration.Input.Parameters[0] as InputParameterEnumeration).ScoreOnMatch)
                        ParameterHintSpecificsLabel.Text = "This input must have a predefined value; if the subject has the same value assigned, the input will score 1.0.";
                    else
                        ParameterHintSpecificsLabel.Text = "This input must have a predefined value; if the subject has any other value assigned, the input will score 1.0.";
                }
            }
            else if (EditConsideration.ParameterValues.Count == 2)
                ParameterHintSpecificsLabel.Text = "This input controls a range. Input numbers will be normalized to 0-1 using this lower and upper bound.";
            else
                ParameterHintSpecificsLabel.Text = "This input has multiple parameters. Nobody knows what they do.";
        }

        private void NamingWikiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");            // TODO - #45 - wiki documentation
        }
    }
}
