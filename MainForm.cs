using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public partial class MainForm : Form
    {
        private Project EditingProject;
        private object RightClickedNodeTag;

        public MainForm()
        {
            InitializeComponent();

            EditingProject = new Project();
            SetUpProject();

            ContentTree.NodeMouseClick += (e, args) =>
            {
                if (args.Node == null || args.Node.Tag == null)
                    return;

                RightClickedNodeTag = args.Node.Tag;

                if (args.Button == MouseButtons.Right)
                {
                    if (RightClickedNodeTag.GetType() == typeof(Behavior))
                    {
                        ContextMenuBehavior.Show(ContentTree.PointToScreen(args.Location));
                    }
                }
            };
        }

        private void ContentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (Control c in EditorPanel.Controls)
                c.Dispose();

            if (e.Node == null)
                return;

            if (e.Node.Tag == null)
            {
                if (e.Node.Text == "Behaviors")
                {
                    var behaviorCtl = new EditWidgetBehaviorSet(EditingProject, "(All Behaviors)", new HashSet<Behavior>());
                    EditorPanel.Controls.Add(behaviorCtl);
                    behaviorCtl.Dock = DockStyle.Fill;
                }

                return;
            }

            var editable = e.Node.Tag as IUserEditable;
            if (editable == null)
                return;

            var ctl = editable.CreateEditorUI(EditingProject);
            EditorPanel.Controls.Add(ctl);
            ctl.Dock = DockStyle.Fill;
        }

        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                EditingProject.SaveToFile(SaveFileDialogBox.FileName);
            }
        }

        private void createNewConsiderationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consideration = new Consideration("New consideration");
            if ((new CurveWizardForm(EditingProject, consideration)).ShowDialog() == DialogResult.OK)
            {
                var behavior = RightClickedNodeTag as Behavior;
                behavior.Considerations.Add(consideration);

                EditingProject.PopulateUI(ContentTree);
            }
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                var project = Project.Deserialize(OpenFileDialogBox.FileName);
                if (project != null)
                {
                    EditingProject = project;
                    SetUpProject();
                }
            }
        }

        private void SetUpProject()
        {
            EditingProject.PopulateUI(ContentTree);
            EditingProject.Navigate += (e, args) =>
            {
                foreach (Control c in EditorPanel.Controls)
                    c.Dispose();

                if (args.Editable == null)
                    return;

                var ctl = args.Editable.CreateEditorUI(EditingProject);
                EditorPanel.Controls.Add(ctl);
                ctl.Dock = DockStyle.Fill;
            };
        }
    }
}
