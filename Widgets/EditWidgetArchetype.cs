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
    public partial class EditWidgetArchetype : UserControl
    {
        private Archetype EditingArchetype;
        private Project EditingProject;

        internal delegate void DialogRebuildNeededHandler(Archetype editedContent);
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetArchetype()
        {
            InitializeComponent();

            EnabledBehaviorSetsListBox.ItemCheck += (e, args) =>
            {
                if (EditingArchetype == null)
                    return;

                var set = EnabledBehaviorSetsListBox.Items[args.Index] as BehaviorSet;

                if (args.NewValue == CheckState.Checked)
                {
                    if (EditingArchetype.BehaviorSets.Contains(set))
                        return;

                    EditingArchetype.BehaviorSets.Add(set);
                }
                else
                {
                    EditingArchetype.BehaviorSets.Remove(set);
                }

                EditingProject.MarkDirty();
            };
        }

        internal void Attach(Archetype archetype, Project project)
        {
            if (EditingArchetype != null)
                EditingArchetype.DialogRebuildNeeded -= Rebuild;

            EditingArchetype = archetype;
            NameEditWidget.Attach("Archetype", EditingArchetype, project);
            EditingArchetype.DialogRebuildNeeded += Rebuild;
            EditingProject = project;

            EnabledBehaviorSetsListBox.Items.Clear();
            foreach (var behaviorSet in project.BehaviorSets)
            {
                EnabledBehaviorSetsListBox.Items.Add(behaviorSet, EditingArchetype.BehaviorSets.Contains(behaviorSet));
            }
        }

        internal void Rebuild()
        {
            Attach(EditingArchetype, EditingProject);
            DialogRebuildNeeded?.Invoke(EditingArchetype);
        }
    }
}
