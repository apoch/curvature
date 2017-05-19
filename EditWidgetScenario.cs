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


        internal void Attach(Scenario scenario)
        {
            Simulation = scenario;

            ScenarioNameLabel.Text = $"Scenario: {Simulation.ReadableName}";

            RefreshAgentTab();
            RefreshLocationTab();
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
    }
}
