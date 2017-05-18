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

            EditingProject = new Project();
            SetUpProject();
        }


        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                EditingProject.SaveToFile(SaveFileDialogBox.FileName);
                EditingFileName = SaveFileDialogBox.FileName;

                SetUpProject();
            }
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
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
            ProjectEditWidget.Attach(EditingProject);
            KnowledgeBaseEditWidget.Attach(EditingProject.KB);
            InputsEditWidget.Attach(EditingProject, EditingProject.Inputs);

            RefreshBehaviorControls();
            RefreshBehaviorSetControls();

            EditingProject.Navigate += (e, args) =>
            {
                if (args.Editable == null)
                    return;
                
                // TODO
            };

            if (string.IsNullOrEmpty(EditingFileName))
                Text = "Curvature Studio";
            else
                Text = $"Curvature Studio - [{EditingFileName}]";
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EditingFileName))
            {
                saveProjectAsToolStripMenuItem_Click(null, null);
                return;
            }

            EditingProject.SaveToFile(EditingFileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditingProject = new Project();
            EditingFileName = null;
            SetUpProject();
        }

        private void CreateBehaviorButton_Click(object sender, EventArgs e)
        {
            EditingProject.Behaviors.Add(new Behavior("New behavior"));
            RefreshBehaviorControls();
        }

        private void RefreshBehaviorControls()
        {
            BehaviorsListView.Items.Clear();

            foreach (var behavior in EditingProject.Behaviors)
            {
                var item = new ListViewItem(behavior.ReadableName);
                item.Tag = behavior;
                BehaviorsListView.Items.Add(item);
            }
        }

        private void RefreshBehaviorSetControls()
        {
            BehaviorSetsListView.Items.Clear();

            foreach (var behaviorSet in EditingProject.BehaviorSets)
            {
                var item = new ListViewItem(behaviorSet.ReadableName);
                item.Tag = behaviorSet;
                BehaviorSetsListView.Items.Add(item);
            }
        }

        private void RefreshScenarioControls()
        {
            ScenariosListView.Items.Clear();

            foreach (var scenario in EditingProject.Scenarios)
            {
                var item = new ListViewItem(scenario.ReadableName);
                item.Tag = scenario;
                ScenariosListView.Items.Add(item);
            }
        }

        private void RefreshConsiderationControls()
        {
            ConsiderationsListView.Items.Clear();

            if (BehaviorsListView.SelectedItems.Count <= 0)
                return;

            var behavior = BehaviorsListView.SelectedItems[0].Tag as Behavior;
            foreach (var consideration in behavior.Considerations)
            {
                var item = new ListViewItem(consideration.ReadableName);
                item.Tag = consideration;
                ConsiderationsListView.Items.Add(item);
            }
        }

        private void BehaviorsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BehaviorsListView.SelectedItems.Count <= 0)
            {
                BehaviorEditWidget.Visible = false;
                return;
            }

            BehaviorEditWidget.Attach(BehaviorsListView.SelectedItems[0].Tag as Behavior);
            BehaviorEditWidget.Visible = true;

            RefreshConsiderationControls();
        }

        private void AddConsiderationButton_Click(object sender, EventArgs e)
        {
            if (BehaviorsListView.SelectedItems.Count <= 0)
                return;

            var behavior = BehaviorsListView.SelectedItems[0].Tag as Behavior;
            var consideration = new Consideration("New consideration");
            if ((new CurveWizardForm(EditingProject, consideration)).ShowDialog() == DialogResult.OK)
                behavior.Considerations.Add(consideration);

            RefreshConsiderationControls();
        }

        private void ConsiderationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsiderationsListView.SelectedItems.Count <= 0)
            {
                ConsiderationEditWidget.Visible = false;
                return;
            }

            ConsiderationEditWidget.Attach(EditingProject, ConsiderationsListView.SelectedItems[0].Tag as Consideration);
            ConsiderationEditWidget.Visible = true;
        }

        private void CreateScenarioButton_Click(object sender, EventArgs e)
        {
            EditingProject.Scenarios.Add(new Scenario("Untitled Scenario"));

            RefreshScenarioControls();
        }

        private void BehaviorSetsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BehaviorSetsListView.SelectedItems.Count <= 0)
            {
                BehaviorSetEditWidget.Visible = false;
                return;
            }

            BehaviorSetEditWidget.Attach(BehaviorSetsListView.SelectedItems[0].Tag as BehaviorSet, EditingProject);
            BehaviorSetEditWidget.Visible = true;
        }

        private void ScenariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ctl in ScenarioPanel.Controls)
                ctl.Dispose();

            ScenarioPanel.Controls.Clear();

            if (ScenariosListView.SelectedItems.Count <= 0)
                return;

            var widget = new EditWidgetScenario();
            widget.Attach(ScenariosListView.SelectedItems[0].Tag as Scenario);
            widget.Dock = DockStyle.Fill;
            ScenarioPanel.Controls.Add(widget);
        }
    }
}
