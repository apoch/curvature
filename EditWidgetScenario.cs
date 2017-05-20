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
        }


        internal void Attach(Scenario scenario, Project project)
        {
            Simulation = scenario;
            EditProject = project;

            ScenarioNameLabel.Text = $"Scenario: {Simulation.ReadableName}";

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

            AgentXUpDown.Value = (decimal)(agent.Position.X);
            AgentYUpDown.Value = (decimal)(agent.Position.Y);
            AgentRadiusUpDown.Value = (decimal)(agent.Radius);
            AgentArchetypeComboBox.SelectedItem = agent.AgentArchetype;
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
    }
}
