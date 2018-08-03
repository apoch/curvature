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
    public partial class EditWidgetArchetypes : UserControl
    {
        private Project EditingProject;


        public EditWidgetArchetypes()
        {
            InitializeComponent();

            ArchetypeEditWidget.DialogRebuildNeeded += RefreshArchetypeControls;
        }

        public void Attach(Project project)
        {
            EditingProject = project;
            RefreshArchetypeControls(null);
        }

        private void RefreshArchetypeControls(Archetype editedContent)
        {
            ArchetypesListView.Items.Clear();

            foreach (var archetype in EditingProject.Archetypes)
            {
                var item = new ListViewItem(archetype.ReadableName)
                {
                    Tag = archetype
                };
                ArchetypesListView.Items.Add(item);
            }

            ArchetypeEditWidget.Visible = false;

            if (ArchetypesListView.Items.Count <= 0)
                return;

            if (editedContent != null)
            {
                foreach (ListViewItem item in ArchetypesListView.Items)
                {
                    if (item.Tag == editedContent)
                    {
                        ArchetypesListView.SelectedIndices.Add(item.Index);
                        break;
                    }
                }
            }
            else
                ArchetypesListView.SelectedIndices.Add(0);
        }

        private void AddArchetypeButton_Click(object sender, EventArgs e)
        {
            var archetype = new Archetype("Untitled Archetype");
            EditingProject.Archetypes.Add(archetype);
            EditingProject.MarkDirty();
            RefreshArchetypeControls(archetype);
        }

        private void ArchetypesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArchetypesListView.SelectedItems.Count <= 0)
            {
                ArchetypeEditWidget.Visible = false;
                return;
            }

            ArchetypeEditWidget.Attach(ArchetypesListView.SelectedItems[0].Tag as Archetype, EditingProject);
            ArchetypeEditWidget.Visible = true;
        }

        private void DeleteArchetypesButton_Click(object sender, EventArgs e)
        {
            var selection = new List<Archetype>();
            foreach (var item in ArchetypesListView.SelectedItems)
            {
                selection.Add((item as ListViewItem).Tag as Archetype);
            }

            foreach (var archetype in selection)
            {
                EditingProject.Delete(archetype);
            }
        }
    }
}
