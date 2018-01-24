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
        private Archetype EditArchetype;
        private Project EditProject;

        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public EditWidgetArchetype()
        {
            InitializeComponent();

            EnabledBehaviorSetsListBox.ItemCheck += (e, args) =>
            {
                if (EditArchetype == null)
                    return;

                var set = EnabledBehaviorSetsListBox.Items[args.Index] as BehaviorSet;

                if (args.NewValue == CheckState.Checked)
                {
                    if (EditArchetype.BehaviorSets.Contains(set))
                        return;

                    EditArchetype.BehaviorSets.Add(set);
                }
                else
                {
                    EditArchetype.BehaviorSets.Remove(set);
                }

                EditProject.MarkDirty();
            };
        }

        internal void Attach(Archetype archetype, Project project)
        {
            EditArchetype = archetype;
            NameEditWidget.Attach("Archetype", EditArchetype, project);
            EditArchetype.DialogRebuildNeeded += Rebuild;
            EditProject = project;

            EnabledBehaviorSetsListBox.Items.Clear();
            foreach (var behaviorSet in project.BehaviorSets)
            {
                EnabledBehaviorSetsListBox.Items.Add(behaviorSet, EditArchetype.BehaviorSets.Contains(behaviorSet));
            }
        }

        internal void Rebuild()
        {
            EditArchetype.DialogRebuildNeeded -= Rebuild;
            Attach(EditArchetype, EditProject);

            DialogRebuildNeeded?.Invoke();
        }
    }
}
