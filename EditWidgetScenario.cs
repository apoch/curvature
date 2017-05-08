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
        }

        private void Advance100msButton_Click(object sender, EventArgs e)
        {
            Simulation.Advance(0.1f);
            ScenarioRenderingBox.Refresh();
        }
    }
}
