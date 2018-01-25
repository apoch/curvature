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
    public partial class EditWidgetBehaviorSets : UserControl
    {

        private Project EditingProject;


        internal delegate void AutoNavigationRequestedHandler(Behavior behavior);
        internal event AutoNavigationRequestedHandler AutoNavigationRequested;


        public EditWidgetBehaviorSets()
        {
            InitializeComponent();
            BehaviorSetEditWidget.AutoNavigationRequested += AutoNavigationRequestedFromChild;
        }

        public void Attach(Project project)
        {
            EditingProject = project;
            RefreshBehaviorSetControls();

            BehaviorSetEditWidget.DialogRebuildNeeded += RefreshBehaviorSetControls;
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

            BehaviorSetEditWidget.Visible = false;

            if (BehaviorSetsListView.Items.Count <= 0)
                return;

            BehaviorSetsListView.SelectedIndices.Add(0);
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

        private void DeleteBehaviorSetButton_Click(object sender, EventArgs e)
        {
            var selection = new List<BehaviorSet>();
            foreach (var item in BehaviorSetsListView.SelectedItems)
            {
                selection.Add((item as ListViewItem).Tag as BehaviorSet);
            }

            foreach (var behaviorset in selection)
            {
                EditingProject.Delete(behaviorset);
            }
        }

        private void AddBehaviorSetButton_Click(object sender, EventArgs e)
        {
            EditingProject.BehaviorSets.Add(new BehaviorSet("Untitled Behavior Set"));
            EditingProject.MarkDirty();
            RefreshBehaviorSetControls();
        }

        internal void AutoNavigationRequestedFromChild(Behavior behavior)
        {
            AutoNavigationRequested?.Invoke(behavior);
        }
    }
}
