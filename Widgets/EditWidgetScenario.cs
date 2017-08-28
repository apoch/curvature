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
    public partial class EditWidgetScenario : UserControl
    {

        private Scenario Simulation;
        private Project EditProject;


        public EditWidgetScenario()
        {
            InitializeComponent();

            ScenarioRenderingBox.Paint += (obj, args) =>
            {
                if (Simulation == null)
                    return;

                Simulation.Render(args.Graphics, ScenarioRenderingBox.ClientRectangle);
            };

            AgentsListView.AfterLabelEdit += (obj, args) =>
            {
                if (string.IsNullOrEmpty(args.Label))
                    return;

                var agent = (AgentsListView.Items[args.Item].Tag as ScenarioAgent);
                agent.Name = args.Label;

                RefreshAgentTab();
            };
        }


        internal void Attach(Scenario scenario, Project project)
        {
            Simulation = scenario;
            EditProject = project;

            NameEditWidget.Attach("Scenario", Simulation);

            RefreshAgentTab();
            RefreshLocationTab();

            Simulation.SimulationAdvance += (e, args) =>
            {
                RefreshAgentTab();
            };
        }

        private void Advance100msButton_Click(object sender, EventArgs e)
        {
            Simulation.Advance(0.1f);
            ScenarioRenderingBox.Refresh();
        }


        private void RefreshAgentTab()
        {
            AgentsListView.Items.Clear();
            if (Simulation == null)
                return;

            foreach (var agent in Simulation.Agents)
            {
                string archetypename = "(unassigned)";
                if (agent.AgentArchetype != null)
                    archetypename = agent.AgentArchetype.ReadableName;

                var item = new ListViewItem(new string[] { agent.GetName(), agent.GetPosition().ToString(), archetypename });
                item.Tag = agent;
                AgentsListView.Items.Add(item);
            }

            AgentArchetypeComboBox.Items.Clear();
            foreach (var archetype in EditProject.Archetypes)
            {
                AgentArchetypeComboBox.Items.Add(archetype);
            }
        }

        private void RefreshLocationTab()
        {
            LocationsListView.Items.Clear();
            if (Simulation == null)
                return;

            foreach (var loc in Simulation.Locations)
            {
                var item = new ListViewItem(new string[] { loc.GetName(), loc.GetPosition().ToString() + $" R={loc.Radius}" });
                item.Tag = loc;
                LocationsListView.Items.Add(item);
            }
        }

        private void AddAgentButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            Simulation.Agents.Add(new ScenarioAgent("Untitled Agent", null));
            RefreshAgentTab();
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            Simulation.Locations.Add(new ScenarioLocation("Untitled Location"));
            RefreshLocationTab();
        }

        private void AgentXUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var agent = lvi.Tag as ScenarioAgent;
                agent.Position.X = (float)AgentXUpDown.Value;
                lvi.SubItems[1].Text = agent.GetPosition().ToString();
            }
        }

        private void AgentYUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var agent = lvi.Tag as ScenarioAgent;
                agent.Position.Y = (float)AgentYUpDown.Value;
                lvi.SubItems[1].Text = agent.GetPosition().ToString();
            }
        }

        private void AgentRadiusUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.Radius = (float)AgentRadiusUpDown.Value;
            }
        }

        private void AgentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AgentsListView.SelectedItems.Count <= 0)
                return;

            var agent = (AgentsListView.SelectedItems[0].Tag as ScenarioAgent);
            PopulateAgentTab(agent);
        }

        private void AgentArchetypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var archetype = AgentArchetypeComboBox.SelectedItem as Archetype;

            foreach (var item in AgentsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var agent = lvi.Tag as ScenarioAgent;
                agent.AgentArchetype = archetype;
                lvi.SubItems[2].Text = agent.AgentArchetype.ReadableName;
            }
        }

        private void AgentResetButton_Click(object sender, EventArgs e)
        {
            AgentXUpDown.Value = AgentStartXUpDown.Value;
            AgentYUpDown.Value = AgentStartYUpDown.Value;
        }

        private void AgentStartXUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.StartPosition.X = (float)AgentStartXUpDown.Value;
            }
        }

        private void AgentStartYUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.StartPosition.Y = (float)AgentStartYUpDown.Value;
            }
        }

        private void CopyCurrentAgentPositionButton_Click(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.StartPosition = agent.Position;
            }

            if (AgentsListView.SelectedItems.Count == 1)
                PopulateAgentTab((AgentsListView.SelectedItems[0] as ListViewItem).Tag as ScenarioAgent);
        }

        private void PopulateAgentTab(ScenarioAgent agent)
        {
            AgentXUpDown.Value = (decimal)(agent.Position.X);
            AgentYUpDown.Value = (decimal)(agent.Position.Y);
            AgentStartXUpDown.Value = (decimal)(agent.StartPosition.X);
            AgentStartYUpDown.Value = (decimal)(agent.StartPosition.Y);
            AgentRadiusUpDown.Value = (decimal)(agent.Radius);
            AgentArchetypeComboBox.SelectedItem = agent.AgentArchetype;
        }

        private void AutoAdvanceButton_Click(object sender, EventArgs e)
        {
            AutoAdvanceTimer.Enabled = !AutoAdvanceTimer.Enabled;
            if (AutoAdvanceTimer.Enabled)
                AutoAdvanceButton.Text = "Pause";
            else
                AutoAdvanceButton.Text = "Auto Advance";
        }

        private void AutoAdvanceTimer_Tick(object sender, EventArgs e)
        {
            Simulation.Advance((float)AutoAdvanceTimer.Interval / 1000.0f);
            ScenarioRenderingBox.Refresh();
        }

        private void ResetSimulationButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            foreach (var agent in Simulation.Agents)
                agent.Position = agent.StartPosition;

            ScenarioRenderingBox.Refresh();
        }
    }
}
