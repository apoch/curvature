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

            ProjectEditWidget.GuidanceBehaviors += (obj, args) =>
            {
                MainTabs.SelectTab(BehaviorsTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");
            };

            ProjectEditWidget.GuidanceInputs += (obj, args) =>
            {
                MainTabs.SelectTab(InputsTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");
            };

            ProjectEditWidget.GuidanceKnowledgeBase += (obj, args) =>
            {
                MainTabs.SelectTab(KnowledgeTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki/Knowledge-Base");
            };

            ProjectEditWidget.GuidanceScenarios += (obj, args) =>
            {
                MainTabs.SelectTab(ScenariosTab);
                System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");
            };

            ProjectEditWidget.DialogRebuildNeeded += () => { SetUpProject(); };
            ArchetypeEditWidget.DialogRebuildNeeded += () => { SetUpProject(); };
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
            RefreshControls();

            EditingProject.ItemDelete += (e, args) =>
            {
                RefreshControls();
            };

            if (string.IsNullOrEmpty(EditingFileName))
                Text = "Curvature Studio";
            else
                Text = $"Curvature Studio - [{EditingFileName}]";
        }


        private void RefreshControls()
        {
            ProjectEditWidget.Attach(EditingProject);
            KnowledgeBaseEditWidget.Attach(EditingProject.KB, EditingProject);
            InputsEditWidget.Attach(EditingProject, EditingProject.Inputs);
            BehaviorsEditWidget.Attach(EditingProject);
            BehaviorSetsEditWidget.Attach(EditingProject);
            
            RefreshArchetypeControls();
            RefreshScenarioControls();
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

        private void RefreshScenarioControls()
        {
            ScenariosListView.Items.Clear();

            foreach (var scenario in EditingProject.Scenarios)
            {
                var item = new ListViewItem(scenario.ReadableName);
                item.Tag = scenario;
                ScenariosListView.Items.Add(item);
            }

            foreach (Control ctl in ScenarioPanel.Controls)
                ctl.Dispose();

            ScenarioPanel.Controls.Clear();
        }

        private void RefreshArchetypeControls()
        {
            ArchetypesListView.Items.Clear();

            foreach (var archetype in EditingProject.Archetypes)
            {
                var item = new ListViewItem(archetype.ReadableName);
                item.Tag = archetype;
                ArchetypesListView.Items.Add(item);
            }

            ArchetypeEditWidget.Visible = false;
        }

        private void CreateScenarioButton_Click(object sender, EventArgs e)
        {
            EditingProject.Scenarios.Add(new Scenario("Untitled Scenario"));
            RefreshScenarioControls();
        }

        private void ScenariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ctl in ScenarioPanel.Controls)
                ctl.Dispose();

            ScenarioPanel.Controls.Clear();

            if (ScenariosListView.SelectedItems.Count <= 0)
                return;

            var widget = new EditWidgetScenario();
            widget.Attach(ScenariosListView.SelectedItems[0].Tag as Scenario, EditingProject);
            widget.Dock = DockStyle.Fill;
            widget.DialogRebuildNeeded += () => { SetUpProject(); };
            ScenarioPanel.Controls.Add(widget);
        }

        private void ArchetypesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArchetypesListView.SelectedItems.Count <= 0)
            {
                ArchetypeEditWidget.Visible = false;
                return;
            }

            ArchetypeEditWidget.Attach(ArchetypesListView.SelectedItems[0].Tag as Archetype, EditingProject);
            ArchetypeEditWidget.Visible = true;
        }

        private void AddArchetypeButton_Click(object sender, EventArgs e)
        {
            EditingProject.Archetypes.Add(new Archetype("Untitled Archetype"));
            RefreshArchetypeControls();
        }

        private void DeleteArchetypesButton_Click(object sender, EventArgs e)
        {
            var selection = new List<Archetype>();
            foreach (var item in ArchetypesListView.SelectedItems)
            {
                selection.Add((item as ListViewItem).Tag as Archetype);
            }

            foreach (var archetype in selection)
            {
                EditingProject.Delete(archetype);
            }
        }

        private void DeleteScenariosButton_Click(object sender, EventArgs e)
        {
            var selection = new List<Scenario>();
            foreach (var item in ScenariosListView.SelectedItems)
            {
                selection.Add((item as ListViewItem).Tag as Scenario);
            }

            foreach (var scenario in selection)
            {
                EditingProject.Delete(scenario);
            }
        }
    }
}
