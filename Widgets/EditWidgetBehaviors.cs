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
    public partial class EditWidgetBehaviors : UserControl
    {
        private Project EditingProject;


        public EditWidgetBehaviors()
        {
            InitializeComponent();
        }


        public void Attach(Project project)
        {
            EditingProject = project;
            RefreshBehaviorControls();

            BehaviorEditWidget.DialogRebuildNeeded += RefreshBehaviorControls;
            ConsiderationEditWidget.DialogRebuildNeeded += RefreshConsiderationControls;
        }


        internal void NavigateTo(Behavior behavior)
        {
            foreach (ListViewItem item in BehaviorsListView.Items)
            {
                if ((item.Tag as Behavior) == behavior)
                {
                    BehaviorsListView.SelectedIndices.Clear();
                    BehaviorsListView.SelectedIndices.Add(item.Index);
                    return;
                }
            }
        }


        private void RefreshBehaviorControls()
        {
            BehaviorsListView.Items.Clear();

            foreach (var behavior in EditingProject.Behaviors)
            {
                var item = new ListViewItem(behavior.ReadableName);
                item.Tag = behavior;
                BehaviorsListView.Items.Add(item);
            }

            BehaviorTabs.Visible = false;
            BehaviorNameEditWidget.Visible = false;

            if (BehaviorsListView.Items.Count <= 0)
                return;

            BehaviorsListView.SelectedIndices.Add(0);
        }

        private void RefreshConsiderationControls()
        {
            ConsiderationsListView.Items.Clear();

            if (BehaviorsListView.SelectedItems.Count <= 0)
                return;

            var behavior = BehaviorsListView.SelectedItems[0].Tag as Behavior;
            foreach (var consideration in behavior.Considerations)
            {
                var item = new ListViewItem(consideration.ReadableName);
                item.Tag = consideration;
                ConsiderationsListView.Items.Add(item);
            }
        }

        private void ConsiderationsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConsiderationsListView.SelectedItems.Count <= 0)
            {
                ConsiderationEditWidget.Visible = false;
                return;
            }

            ConsiderationEditWidget.Attach(EditingProject, ConsiderationsListView.SelectedItems[0].Tag as Consideration);
            ConsiderationEditWidget.Visible = true;
        }

        private void CreateBehaviorButton_Click(object sender, EventArgs e)
        {
            EditingProject.Behaviors.Add(new Behavior("New behavior"));
            EditingProject.MarkDirty();
            RefreshBehaviorControls();
        }

        private void BehaviorsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BehaviorsListView.SelectedItems.Count <= 0)
            {
                BehaviorTabs.Visible = false;
                BehaviorNameEditWidget.Visible = false;
                return;
            }

            var b = BehaviorsListView.SelectedItems[0].Tag as Behavior;
            BehaviorNameEditWidget.Attach("Behavior", b, EditingProject);
            BehaviorEditWidget.Attach(b, EditingProject);
            BehaviorScoringWidget.Attach(b, EditingProject);
            BehaviorTabs.Visible = true;
            BehaviorNameEditWidget.Visible = true;

            RefreshConsiderationControls();
        }

        private void AddConsiderationButton_Click(object sender, EventArgs e)
        {
            if (BehaviorsListView.SelectedItems.Count <= 0)
                return;

            var behavior = BehaviorsListView.SelectedItems[0].Tag as Behavior;
            var consideration = new Consideration("New consideration");
            if ((new CurveWizardForm(EditingProject, consideration)).ShowDialog() == DialogResult.OK)
            {
                behavior.Considerations.Add(consideration);
                EditingProject.MarkDirty();
            }

            RefreshConsiderationControls();
            RefreshBehaviorControls();
        }

        private void DeleteSelectedBehaviorsButton_Click(object sender, EventArgs e)
        {
            var selection = new List<Behavior>();
            foreach (var item in BehaviorsListView.SelectedItems)
            {
                selection.Add((item as ListViewItem).Tag as Behavior);
            }

            foreach (var behavior in selection)
            {
                EditingProject.Delete(behavior);
            }
        }

        private void DeleteConsiderationButton_Click(object sender, EventArgs e)
        {
            var selection = new List<Consideration>();
            foreach (var item in ConsiderationsListView.SelectedItems)
            {
                selection.Add((item as ListViewItem).Tag as Consideration);
            }

            foreach (var consideration in selection)
            {
                EditingProject.Delete(consideration);
            }
        }
    }
}