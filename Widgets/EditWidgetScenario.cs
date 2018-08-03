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
        private Project EditingProject;

        private float AbsoluteTime;


        internal delegate void DialogRebuildNeededHandler(Scenario editedScenario);
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetScenario()
        {
            InitializeComponent();

            AbsoluteTime = 0.0f;

            ScenarioRenderingBox.Paint += (obj, args) =>
            {
                if (Simulation == null)
                    return;

                Simulation.Render(args.Graphics, ScenarioRenderingBox.ClientRectangle);
            };

            ScenarioRenderingBox.LostFocus += (obj, args) =>
            {
                SimulationInspectionTooltip.Hide(ScenarioRenderingBox);
            };

            ScenarioRenderingBox.MouseClick += (obj, args) =>
            {
                ScenarioRenderingBox.Focus();

                if (args.Button != MouseButtons.Right)
                {
                    SimulationInspectionTooltip.Hide(ScenarioRenderingBox);
                    return;
                }

                if (Simulation == null)
                {
                    SimulationInspectionTooltip.Hide(ScenarioRenderingBox);
                    return;
                }

                var text = Simulation.GetInspectionText(ScenarioRenderingBox.ClientRectangle, args.Location);
                if (text == null || string.IsNullOrEmpty(text.Caption))
                {
                    SimulationInspectionTooltip.Hide(ScenarioRenderingBox);
                    return;
                }

                SimulationInspectionTooltip.ToolTipIcon = text.Icon;
                SimulationInspectionTooltip.ToolTipTitle = text.Caption;
                SimulationInspectionTooltip.Show(text.Description, ScenarioRenderingBox, args.X + 18, args.Y + 18);
            };

            ScenarioRenderingBox.MouseDoubleClick += (obj, args) =>
            {
                ScenarioRenderingBox.Focus();

                if (Simulation == null)
                    return;

                var agent = Simulation.GetAgentAtLocation(ScenarioRenderingBox.ClientRectangle, args.Location);
                if (agent == null)
                    return;

                for (int i = 0; i < AgentsListView.Items.Count; ++i)
                {
                    if ((AgentsListView.Items[i].Tag as ScenarioAgent) == agent)
                    {
                        AgentsListView.SelectedItems.Clear();
                        AgentsListView.SelectedIndices.Add(i);

                        ScenarioEditorTabs.SelectTab(AgentsTab);

                        return;
                    }
                }
            };

            AgentsListView.AfterLabelEdit += (obj, args) =>
            {
                if (string.IsNullOrEmpty(args.Label))
                    return;

                var agent = (AgentsListView.Items[args.Item].Tag as ScenarioAgent);
                agent.Name = args.Label;

                RefreshAgentTab();
                EditingProject.MarkDirty();
            };

            LocationsListView.AfterLabelEdit += (obj, args) =>
            {
                if (string.IsNullOrEmpty(args.Label))
                    return;

                var location = LocationsListView.Items[args.Item].Tag as ScenarioLocation;
                location.Name = args.Label;

                RefreshLocationTab();
                EditingProject.MarkDirty();
            };

            LogsTreeView.NodeMouseClick += (obj, args) =>
            {
                LogDetailTextBox.Text = "";
                BuildLogText(args.Node);
            };
        }


        private void BuildLogText(TreeNode node)
        {
            if (node == null)
                return;

            if (node.Tag == null)
                return;

            BuildLogText(node.Parent);

            LogDetailTextBox.Text += node.Tag.ToString();
        }


        internal void Attach(Scenario scenario, Project project)
        {
            if (Simulation != null)
            {
                Simulation.DialogRebuildNeeded -= Rebuild;
                Simulation.SimulationAdvance -= ScenarioAdvance;
            }

            Simulation = scenario;
            EditingProject = project;

            Simulation.DialogRebuildNeeded += Rebuild;
            Simulation.SimulationAdvance += ScenarioAdvance;

            NameEditWidget.Attach("Scenario", Simulation, EditingProject);

            RefreshAgentTab();
            RefreshLocationTab();

            AbsoluteTime = 0.0f;
        }

        private void ScenarioAdvance(object sender, Scenario.ScenarioEventArgs args)
        {
            RefreshAgentTab();
            CreateLogDetails(args);
            AbsoluteTime += args.DeltaTime;
        }

        private void CreateLogDetails(Scenario.ScenarioEventArgs args)
        {
            if (Simulation == null)
                return;

            var rootnode = LogsTreeView.Nodes.Add($"Tick at {AbsoluteTime}s");
            rootnode.Tag = $"Simulation {Simulation.GetName()} at time {AbsoluteTime}s\r\n";

            foreach (var agent in Simulation.Agents)
            {
                var agentnode = rootnode.Nodes.Add(agent.GetName());
                if (agent.AgentArchetype == null)
                {
                    agentnode.Tag = "(No archetype set for this agent)";
                    continue;
                }

                var winctx = args.AgentDecisions[agent].WinningContext;

                string decisionLog = (winctx == null) ? "(stalled!)" : $"{winctx.ChosenBehavior.GetName()} [{winctx.ChosenBehavior.Action}]";
                string contextLog = (winctx == null) ? "(N/A)" : $"{winctx.Target.GetName()}";
                string position = agent.GetPosition().ToString();
                agentnode.Tag = $"Agent: {agent.GetName()} (running archetype {agent.AgentArchetype.GetName()})\r\nDecision: {decisionLog}\r\nContext: {contextLog}\r\nPosition: {position}\r\n";

                foreach (var behaviorset in agent.AgentArchetype.BehaviorSets)
                {
                    var setnode = agentnode.Nodes.Add(behaviorset.GetName());
                    setnode.Tag = $"Behavior set: {setnode.Text}\r\n";

                    foreach (var behavior in behaviorset.EnabledBehaviors)
                    {
                        var behaviornode = setnode.Nodes.Add(behavior.GetName());
                        behaviornode.Tag = $"Behavior: {behaviornode.Text}\r\n\r\n";

                        foreach (var ctx in args.AgentDecisions[agent].ScoredContexts)
                        {
                            if (ctx.ChosenBehavior != behavior)
                                continue;

                            var contextnode = behaviornode.Nodes.Add(ctx.Target.GetName());
                            contextnode.Tag = ctx;

                            if (ctx == winctx)
                                contextnode.Text = "(*) " + contextnode.Text;
                        }
                    }
                }
            }
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
            foreach (var archetype in EditingProject.Archetypes)
            {
                AgentArchetypeComboBox.Items.Add(archetype);
            }
        }

        private void RefreshLocationTab()
        {
            AgentStartLocationCombo.Items.Clear();
            AgentStartLocationCombo.Items.Add("(Manual)");

            LocationsListView.Items.Clear();
            if (Simulation == null)
                return;

            foreach (var loc in Simulation.Locations)
            {
                var item = new ListViewItem(new string[] { loc.GetName(), GetLocationCoordsDescription(loc) });
                item.Tag = loc;
                LocationsListView.Items.Add(item);

                AgentStartLocationCombo.Items.Add(loc);
            }
        }

        private void AddAgentButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            Simulation.Agents.Add(new ScenarioAgent("Untitled Agent", null));
            RefreshAgentTab();
            EditingProject.MarkDirty();
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            Simulation.Locations.Add(new ScenarioLocation("Untitled Location"));
            RefreshLocationTab();
            EditingProject.MarkDirty();
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

            EditingProject.MarkDirty();
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

            EditingProject.MarkDirty();
        }

        private void AgentRadiusUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.Radius = (float)AgentRadiusUpDown.Value;
            }

            EditingProject.MarkDirty();
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
            string archetypename = "(unassigned)";
            if (archetype != null)
                archetypename = archetype.ReadableName;

            foreach (var item in AgentsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var agent = lvi.Tag as ScenarioAgent;
                agent.AgentArchetype = archetype;
                lvi.SubItems[2].Text = archetypename;
            }

            EditingProject.MarkDirty();
        }

        private void AgentResetButton_Click(object sender, EventArgs e)
        {
            AgentXUpDown.Value = AgentStartXUpDown.Value;
            AgentYUpDown.Value = AgentStartYUpDown.Value;

            EditingProject.MarkDirty();
        }

        private void AgentStartXUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.StartPosition.X = (float)AgentStartXUpDown.Value;
            }

            EditingProject.MarkDirty();
        }

        private void AgentStartYUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.StartPosition.Y = (float)AgentStartYUpDown.Value;
            }

            EditingProject.MarkDirty();
        }

        private void CopyCurrentAgentPositionButton_Click(object sender, EventArgs e)
        {
            foreach (var item in AgentsListView.SelectedItems)
            {
                var agent = (item as ListViewItem).Tag as ScenarioAgent;
                agent.StartPosition = agent.Position;
                agent.StartLocation = null;
            }

            if (AgentsListView.SelectedItems.Count == 1)
                PopulateAgentTab((AgentsListView.SelectedItems[0] as ListViewItem).Tag as ScenarioAgent);

            EditingProject.MarkDirty();
        }

        private void PopulateAgentTab(ScenarioAgent agent)
        {
            AgentXUpDown.Value = (decimal)(agent.Position.X);
            AgentYUpDown.Value = (decimal)(agent.Position.Y);
            AgentStartXUpDown.Value = (decimal)(agent.StartPosition.X);
            AgentStartYUpDown.Value = (decimal)(agent.StartPosition.Y);
            AgentRadiusUpDown.Value = (decimal)(agent.Radius);
            AgentArchetypeComboBox.SelectedItem = agent.AgentArchetype;
            ColorSwatch.BackColor = agent.Color;
            AgentRandomStartPositionCheckBox.Checked = agent.StartFuzzed;

            AgentStartLocationCombo.SelectedItem = agent.StartLocation;
            if (AgentStartLocationCombo.SelectedIndex < 0)
                AgentStartLocationCombo.SelectedIndex = 0;

            agent.GenerateStartProperties(EditingProject.KB);

            AgentProperties.SelectedObject = new AgentPropertyAdapter(agent.StartProperties);
        }

        private void PopulateLocationTab(ScenarioLocation location)
        {
            LocationCenterX.Value = (decimal)(location.Position.X);
            LocationCenterY.Value = (decimal)(location.Position.Y);
            LocationRadius.Value = (decimal)(location.Radius);

            location.GenerateStartProperties(EditingProject.KB);

            LocationPropertyGrid.SelectedObject = new AgentPropertyAdapter(location.StartProperties);
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

            if (int.TryParse(RandomSeedCombo.Text, out int seed))
                Simulation.ReseedRandoms(seed);
            else
                Simulation.ReseedRandoms();

            Simulation.ResetAgents(EditingProject.KB);

            ScenarioRenderingBox.Refresh();

            LogsTreeView.Nodes.Clear();
            LogDetailTextBox.Text = "";

            AbsoluteTime = 0.0f;
        }

        internal void Rebuild()
        {
            Attach(Simulation, EditingProject);
            DialogRebuildNeeded?.Invoke(Simulation);
        }

        private void DeleteSelectedAgentsButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            foreach (var selected in AgentsListView.SelectedItems)
            {
                var agent = (selected as ListViewItem).Tag as ScenarioAgent;
                Simulation.Agents.Remove(agent);
            }

            EditingProject.MarkDirty();
            DialogRebuildNeeded?.Invoke(Simulation);
        }

        private void ColorSwatch_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                ColorSwatch.BackColor = ColorPicker.Color;

                foreach (var item in AgentsListView.SelectedItems)
                {
                    var agent = (item as ListViewItem).Tag as ScenarioAgent;
                    agent.Color = ColorPicker.Color;
                }

                EditingProject.MarkDirty();
            }
        }

        private void AgentRandomStartPositionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var selected in AgentsListView.SelectedItems)
            {
                var agent = (selected as ListViewItem).Tag as ScenarioAgent;
                agent.StartFuzzed = AgentRandomStartPositionCheckBox.Checked;
            }

            EditingProject.MarkDirty();
        }

        private string GetLocationCoordsDescription(ScenarioLocation loc)
        {
            return $"{loc.GetPosition()} R={loc.Radius}";
        }

        private void LocationCenterX_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in LocationsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var location = lvi.Tag as ScenarioLocation;
                location.Position.X = (float)LocationCenterX.Value;
                lvi.SubItems[1].Text = GetLocationCoordsDescription(location);
            }

            EditingProject.MarkDirty();
        }

        private void LocationCenterY_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in LocationsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var location = lvi.Tag as ScenarioLocation;
                location.Position.Y = (float)LocationCenterY.Value;
                lvi.SubItems[1].Text = GetLocationCoordsDescription(location);
            }

            EditingProject.MarkDirty();
        }

        private void LocationRadius_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in LocationsListView.SelectedItems)
            {
                var lvi = (item as ListViewItem);
                var location = lvi.Tag as ScenarioLocation;
                location.Radius = (float)LocationRadius.Value;
                lvi.SubItems[1].Text = GetLocationCoordsDescription(location);
            }

            EditingProject.MarkDirty();
        }

        private void LocationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocationsListView.SelectedItems.Count <= 0)
                return;

            var location = (LocationsListView.SelectedItems[0].Tag as ScenarioLocation);
            PopulateLocationTab(location);
        }

        private void DeleteLocationButton_Click(object sender, EventArgs e)
        {
            if (Simulation == null)
                return;

            foreach (var selected in LocationsListView.SelectedItems)
            {
                var location = (selected as ListViewItem).Tag as ScenarioLocation;
                Simulation.Locations.Remove(location);
            }

            EditingProject.MarkDirty();
            DialogRebuildNeeded?.Invoke(Simulation);
        }

        private void AgentStartLocationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool madechange = false;

            if (AgentStartLocationCombo.SelectedIndex <= 0)
            {
                foreach (var selected in AgentsListView.SelectedItems)
                {
                    var agent = (selected as ListViewItem).Tag as ScenarioAgent;

                    if (agent.StartLocation != null)
                        madechange = true;

                    agent.StartLocation = null;
                    agent.StartPosition = new PointF { X = 0.0f, Y = 0.0f };
                }
            }
            else
            {
                var location = AgentStartLocationCombo.SelectedItem as ScenarioLocation;

                foreach (var selected in AgentsListView.SelectedItems)
                {
                    var agent = (selected as ListViewItem).Tag as ScenarioAgent;

                    if (agent.StartLocation != location)
                        madechange = true;

                    agent.StartLocation = location;
                }
            }

            if (madechange && AgentsListView.SelectedItems.Count == 1)
                PopulateAgentTab((AgentsListView.SelectedItems[0] as ListViewItem).Tag as ScenarioAgent);

            EditingProject.MarkDirty();
        }
    }
}
