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
    public partial class EditWidgetScenarios : UserControl
    {

        private Project EditingProject;



        public EditWidgetScenarios()
        {
            InitializeComponent();
        }


        public void Attach(Project project)
        {
            EditingProject = project;
            RefreshScenarioControls();
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

            if (ScenariosListView.Items.Count <= 0)
                return;

            ScenariosListView.SelectedIndices.Add(0);
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
            widget.DialogRebuildNeeded += () => { RefreshScenarioControls(); };
            ScenarioPanel.Controls.Add(widget);
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

        private void CreateScenarioButton_Click(object sender, EventArgs e)
        {
            EditingProject.Scenarios.Add(new Scenario("Untitled Scenario"));
            EditingProject.MarkDirty();
            RefreshScenarioControls();
        }
    }
}
