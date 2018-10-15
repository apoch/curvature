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
    public partial class MainForm : Form
    {
        private Project EditingProject;
        private string EditingFileName;

        public MainForm()
        {
            InitializeComponent();

            FormClosing += (e, args) =>
            {
                if (EditingProject == null)
                    return;

                if (!EditingProject.IsDirty)
                    return;

                var response = MessageBox.Show("The current project has unsaved changes.\r\nWould you like to save first?", "Curvature Studio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (response == DialogResult.Cancel)
                {
                    args.Cancel = true;
                    return;
                }

                if (response == DialogResult.Yes)
                    SaveProjectAsToolStripMenuItem_Click(null, null);
            };

            EditingProject = new Project();
            SetUpProject();

            ProjectEditWidget.GuidanceBehaviors += (obj, args) =>
            {
                MainTabs.SelectTab(BehaviorsTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");                        // TODO - #45 - wiki documentation
            };

            ProjectEditWidget.GuidanceInputs += (obj, args) =>
            {
                MainTabs.SelectTab(InputsTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");                        // TODO - #45 - wiki documentation
            };

            ProjectEditWidget.GuidanceKnowledgeBase += (obj, args) =>
            {
                MainTabs.SelectTab(KnowledgeTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki/Knowledge-Base");
            };

            ProjectEditWidget.GuidanceScenarios += (obj, args) =>
            {
                MainTabs.SelectTab(ScenariosTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");                        // TODO - #45 - wiki documentation
            };

            ProjectEditWidget.GuidanceTour += (obj, args) =>
            {
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");                        // TODO - #45 - wiki documentation
            };

            ProjectEditWidget.DialogRebuildNeeded += RefreshControls;


            BehaviorSetsEditWidget.AutoNavigationRequested += AutoNavigationRequestedFromChild;
        }


        private void SaveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                EditingProject.SaveToFile(SaveFileDialogBox.FileName);
                EditingFileName = SaveFileDialogBox.FileName;

                RefreshControls();
            }
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                var project = Project.Deserialize(OpenFileDialogBox.FileName);
                if (project != null)
                {
                    EditingProject = project;
                    EditingFileName = OpenFileDialogBox.FileName;
                    SetUpProject();
                }
            }
        }

        private void SetUpProject()
        {
            RefreshControls();

            EditingProject.ItemDelete += (e, args) =>
            {
                RefreshControls();
            };

            EditingProject.ProjectDirtied += (dirty) =>
            {
                SetWindowCaption(dirty);
                ProjectEditWidget.Attach(EditingProject);
            };
        }


        private void RefreshControls()
        {
            ProjectEditWidget.Attach(EditingProject);
            KnowledgeBaseEditWidget.Attach(EditingProject.KB, EditingProject);
            InputsEditWidget.Attach(EditingProject, EditingProject.Inputs);
            BehaviorsEditWidget.Attach(EditingProject);
            BehaviorSetsEditWidget.Attach(EditingProject);
            ArchetypesEditWidget.Attach(EditingProject);
            ScenariosEditWidget.Attach(EditingProject);

            SetWindowCaption(EditingProject.IsDirty);
        }

        private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EditingFileName))
            {
                SaveProjectAsToolStripMenuItem_Click(null, null);
                return;
            }

            EditingProject.SaveToFile(EditingFileName);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditingProject = new Project();
            EditingFileName = null;
            SetUpProject();
        }

        internal void AutoNavigationRequestedFromChild(Behavior behavior)
        {
            MainTabs.SelectTab(BehaviorsTab);
            BehaviorsEditWidget.NavigateTo(behavior);
        }

        private void SetWindowCaption(bool dirty)
        {
            if (string.IsNullOrEmpty(EditingFileName))
            {
                if (dirty)
                {
                    Text = "Curvature Studio - [Unsaved Project] (*)";
                }
                else
                {
                    Text = "Curvature Studio";
                }
            }
            else
            {
                if (dirty)
                    Text = $"Curvature Studio - [{EditingFileName}] (*)";
                else
                    Text = $"Curvature Studio - [{EditingFileName}]";
            }
        }

        private void UIDiagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var output = new StringBuilder();

            output.AppendLine($"Window font face: {Font.Name}");
            output.AppendLine($"Window font size: {Font.Size}");

            output.AppendLine($"Autoscale factor X: {AutoScaleFactor.Width}");
            output.AppendLine($"Autoscale factor Y: {AutoScaleFactor.Height}");

            output.AppendLine($"Autoscale basis X: {AutoScaleDimensions.Width}");
            output.AppendLine($"Autoscale basis Y: {AutoScaleDimensions.Height}");

            output.AppendLine($"Autoscale current X: {CurrentAutoScaleDimensions.Width}");
            output.AppendLine($"Autoscale current Y: {CurrentAutoScaleDimensions.Height}");

            output.AppendLine($"Scenarios Autoscale basis X: {ScenariosEditWidget.AutoScaleDimensions.Width}");
            output.AppendLine($"Scenarios Autoscale basis Y: {ScenariosEditWidget.AutoScaleDimensions.Height}");

            output.AppendLine($"Scenarios Autoscale current X: {ScenariosEditWidget.CurrentAutoScaleDimensions.Width}");
            output.AppendLine($"Scenarios Autoscale current Y: {ScenariosEditWidget.CurrentAutoScaleDimensions.Height}");

            Clipboard.SetText(output.ToString());
            MessageBox.Show("Copied diagnostic data to clipboard");
        }
    }
}
