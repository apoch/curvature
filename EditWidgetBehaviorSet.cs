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
    public partial class EditWidgetBehaviorSet : UserControl
    {
        private BehaviorSet EditSet;

        public EditWidgetBehaviorSet(Project project, BehaviorSet set)
        {
            InitializeComponent();
            EditSet = set;

            BehaviorSetNameLabel.Text = $"Behavior Set: {EditSet.ReadableName}";

            foreach (Behavior b in project.Behaviors)
            {
                EnabledBehaviorsListBox.Items.Add(b, EditSet.EnabledBehaviors.Contains(b));
            }
        }
    }
}
