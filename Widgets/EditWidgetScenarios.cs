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
            ScenarioEditWidget.DialogRebuildNeeded += RefreshScenarioControls;
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


            if (ScenariosListView.Items.Count <= 0)
            {
                ScenarioEditWidget.Visible = false;
                return;
            }

            ScenarioEditWidget.Visible = true;

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
        }

        private void CreateScenarioButton_Click(object sender, EventArgs e)
        {
            EditingProject.Scenarios.Add(new Scenario("Untitled Scenario"));
            EditingProject.MarkDirty();
            RefreshScenarioControls();
        }
    }
}
