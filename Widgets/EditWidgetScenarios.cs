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
            ScenarioEditWidget.DialogRebuildNeeded += RefreshScenarioControls;
        }


        public void Attach(Project project)
        {
            EditingProject = project;
            RefreshScenarioControls(null);
        }


        private void RefreshScenarioControls(Scenario editedScenario)
        {
            ScenariosListView.Items.Clear();

            foreach (var scenario in EditingProject.Scenarios)
            {
                var item = new ListViewItem(scenario.ReadableName)
                {
                    Tag = scenario
                };
                ScenariosListView.Items.Add(item);
            }


            if (ScenariosListView.Items.Count <= 0)
            {
                ScenarioEditWidget.Visible = false;
                return;
            }

            ScenarioEditWidget.Visible = true;

            if (editedScenario != null)
            {
                foreach(ListViewItem item in ScenariosListView.Items)
                {
                    if (item.Tag == editedScenario)
                    {
                        ScenariosListView.SelectedIndices.Add(item.Index);
                        break;
                    }
                }
            }
            else
                ScenariosListView.SelectedIndices.Add(0);
        }

        private void ScenariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScenariosListView.SelectedItems.Count <= 0)
            {
                ScenarioEditWidget.Visible = false;
                return;
            }

            ScenarioEditWidget.Visible = true;
            ScenarioEditWidget.Attach(ScenariosListView.SelectedItems[0].Tag as Scenario, EditingProject);
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

            EditingProject.MarkDirty();
        }

        private void CreateScenarioButton_Click(object sender, EventArgs e)
        {
            var scenario = new Scenario("Untitled Scenario");
            EditingProject.Scenarios.Add(scenario);
            EditingProject.MarkDirty();
            RefreshScenarioControls(scenario);
        }
    }
}
