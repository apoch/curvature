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
    public partial class EditWidgetProject : UserControl
    {
        private Project EditedProject;


        internal delegate void GuidanceEventHandler(object sender, EventArgs args);
        internal event GuidanceEventHandler GuidanceKnowledgeBase;
        internal event GuidanceEventHandler GuidanceInputs;
        internal event GuidanceEventHandler GuidanceBehaviors;
        internal event GuidanceEventHandler GuidanceScenarios;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetProject()
        {
            InitializeComponent();
        }


        internal void Attach(Project editedProject)
        {
            EditedProject = editedProject;
            NameEditWidget.Attach("Project", EditedProject);

            EditedProject.DialogRebuildNeeded += Rebuild;

            int considerationCount = 0;
            foreach (var behavior in EditedProject.Behaviors)
            {
                considerationCount += behavior.Considerations.Count;
            }

            KnowledgeBaseEntriesLabel.Text = $"Knowledge Base Entries: {EditedProject.KB.Records.Count}";
            InputAxesLabel.Text = $"Input Axes: {EditedProject.Inputs.Count}";
            ConsiderationsLabel.Text = $"Considerations: {considerationCount}";
            BehaviorsLabel.Text = $"Behaviors: {EditedProject.Behaviors.Count}";
            BehaviorSetsLabel.Text = $"Behavior Sets: {EditedProject.BehaviorSets.Count}";
            ArchetypesLabel.Text = $"Archetypes: {EditedProject.Archetypes.Count}";
            ScenariosLabel.Text = $"Scenarios: {EditedProject.Scenarios.Count}";
        }

        private void WikiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki");
        }

        private void UtilityCrashCourseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/apoch/curvature/wiki/Utility-Theory-Crash-Course");
        }

        private void CreateKnowledgeButton_Click(object sender, EventArgs e)
        {
            GuidanceKnowledgeBase(this, null);
        }

        private void DefineInputsButton_Click(object sender, EventArgs e)
        {
            GuidanceInputs(this, null);
        }

        private void SpecifyBehaviorsButton_Click(object sender, EventArgs e)
        {
            GuidanceBehaviors(this, null);
        }

        private void ScenariosButton_Click(object sender, EventArgs e)
        {
            GuidanceScenarios(this, null);
        }

        internal void Rebuild()
        {
            EditedProject.DialogRebuildNeeded -= Rebuild;
            Attach(EditedProject);

            DialogRebuildNeeded?.Invoke();
        }
    }
}
