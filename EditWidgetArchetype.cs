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
            };
        }

        internal void Attach(Archetype archetype, Project project)
        {
            EditArchetype = archetype;
            ArchetypeNameLabel.Text = $"Archetype: {EditArchetype.ReadableName}";

            EnabledBehaviorSetsListBox.Items.Clear();
            foreach (var behaviorSet in project.BehaviorSets)
            {
                EnabledBehaviorSetsListBox.Items.Add(behaviorSet, EditArchetype.BehaviorSets.Contains(behaviorSet));
            }
        }
    }
}
