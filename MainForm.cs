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
        private string EditingFileName;
        private TreeNode RightClickedNode;

        public MainForm()
        {
            InitializeComponent();

            EditingProject = new Project();
            SetUpProject();

            ContentTree.NodeMouseClick += (e, args) =>
            {
                if (args.Node == null)
                    return;

                RightClickedNode = args.Node;

                if (args.Button != MouseButtons.Right)
                    return;

                if (args.Node.Tag == null)
                {
                    if (args.Node.Text == "Behaviors")
                    {
                        deleteBehaviorSetToolStripMenuItem.Enabled = false;
                        renameBehaviorSetToolStripMenuItem.Enabled = false;
                        ContextMenuBehaviorSet.Show(ContentTree.PointToScreen(args.Location));
                    }
                    else if (args.Node.Text == "Inputs")
                    {
                        ContextMenuInputs.Show(ContentTree.PointToScreen(args.Location));
                    }

                    return;
                }

                if (RightClickedNode.Tag is Behavior)
                {
                    ContextMenuBehavior.Show(ContentTree.PointToScreen(args.Location));
                }
                else if (RightClickedNode.Tag is Consideration)
                {
                    ContextMenuConsideration.Show(ContentTree.PointToScreen(args.Location));
                }
                else if (RightClickedNode.Tag is BehaviorSet)
                {
                    deleteBehaviorSetToolStripMenuItem.Enabled = true;
                    renameBehaviorSetToolStripMenuItem.Enabled = true;
                    ContextMenuBehaviorSet.Show(ContentTree.PointToScreen(args.Location));
                }
            };

            ContentTree.BeforeLabelEdit += (e, args) =>
            {
                if (args.Node.Tag == null || !(args.Node.Tag is INameable))
                {
                    args.CancelEdit = true;
                }
            };

            ContentTree.AfterLabelEdit += (e, args) =>
            {
                if (args.Node.Tag == null || string.IsNullOrEmpty(args.Label))
                    return;

                if (args.Node.Tag is INameable)
                {
                    var nameable = args.Node.Tag as INameable;
                    nameable.Rename(args.Label);
                }
            };
        }

        private void ContentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearEditorPanel();

            if (e.Node == null)
                return;

            if (e.Node.Tag == null)
            {
                if (e.Node.Text == "Behaviors")
                    SetEditorPanel(new EditWidgetBehaviorSet(EditingProject, "(All Behaviors)", new HashSet<Behavior>()));

                return;
            }

            var editable = e.Node.Tag as IUserEditable;
            if (editable == null)
                return;

            SetEditorPanel(editable.CreateEditorUI(EditingProject));
        }

        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialogBox.ShowDialog() == DialogResult.OK)
            {
                EditingProject.SaveToFile(SaveFileDialogBox.FileName);
                EditingFileName = SaveFileDialogBox.FileName;

                SetUpProject();
            }
        }

        private void createNewConsiderationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consideration = new Consideration("New consideration");
            if ((new CurveWizardForm(EditingProject, consideration)).ShowDialog() == DialogResult.OK)
            {
                var behavior = RightClickedNode.Tag as Behavior;
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
                    EditingFileName = OpenFileDialogBox.FileName;
                    SetUpProject();
                }
            }
        }

        private void SetUpProject()
        {
            EditingProject.PopulateUI(ContentTree);
            EditingProject.Navigate += (e, args) =>
            {
                ClearEditorPanel();

                if (args.Editable == null)
                    return;

                SetEditorPanel(args.Editable.CreateEditorUI(EditingProject));
            };

            if (string.IsNullOrEmpty(EditingFileName))
                Text = "Curvature Studio";
            else
                Text = $"Curvature Studio - [{EditingFileName}]";
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EditingFileName))
            {
                saveProjectAsToolStripMenuItem_Click(null, null);
                return;
            }

            EditingProject.SaveToFile(EditingFileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditingProject = new Project();
            EditingFileName = null;
            SetUpProject();
            ContentTree.SelectedNode = ContentTree.Nodes[0];
        }

        private void ClearEditorPanel()
        {
            foreach (Control c in EditorPanel.Controls)
                c.Dispose();
        }

        private void SetEditorPanel(Control c)
        {
            EditorPanel.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }

        private void runWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consideration = RightClickedNode.Tag as Consideration;
            (new CurveWizardForm(EditingProject, consideration)).ShowDialog();
        }

        private void deleteConsiderationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consideration = RightClickedNode.Tag as Consideration;
            var promptText = $"Are you sure you wish to delete this consideration?\r\n\r\n{consideration.ReadableName}";
            var promptResult = MessageBox.Show(promptText, "Curvature Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (promptResult == DialogResult.Yes)
            {
                var behavior = RightClickedNode.Parent.Tag as Behavior;
                behavior.Considerations.Remove(consideration);

                SetUpProject();
            }
        }

        private void deleteBehaviorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var behavior = RightClickedNode.Tag as Behavior;
            var promptText = $"Are you sure you wish to delete this behavior?\r\n\r\n{behavior.ReadableName}";
            var promptResult = MessageBox.Show(promptText, "Curvature Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (promptResult == DialogResult.Yes)
            {
                EditingProject.Behaviors.Remove(behavior);

                SetUpProject();
            }
        }

        private void createNewBehaviorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var behavior = new Behavior("New behavior");
            EditingProject.Behaviors.Add(behavior);

            var behaviorSet = RightClickedNode.Tag as BehaviorSet;
            if (behaviorSet != null)
                behaviorSet.EnabledBehaviors.Add(behavior);

            SetUpProject();
        }

        private void createNewInputAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var axis = new InputAxis("New input", InputAxis.OriginType.PropertyOfSelf);
            EditingProject.RegisterInput(axis);

            SetUpProject();
        }

        private void deleteBehaviorSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var behaviorSet = RightClickedNode.Tag as BehaviorSet;
            if (behaviorSet == null)
                return;

            var promptText = $"Are you sure you wish to delete this behavior set?\r\n\r\n{behaviorSet.ReadableName}";
            var promptResult = MessageBox.Show(promptText, "Curvature Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (promptResult == DialogResult.Yes)
            {
                EditingProject.BehaviorSets.Remove(behaviorSet);

                SetUpProject();
            }
        }

        private void renameBehaviorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContentTree.SelectedNode == null)
                return;

            ContentTree.SelectedNode.BeginEdit();
        }

        private void renameConsiderationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContentTree.SelectedNode == null)
                return;

            ContentTree.SelectedNode.BeginEdit();
        }

        private void renameBehaviorSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContentTree.SelectedNode == null)
                return;

            ContentTree.SelectedNode.BeginEdit();
        }

        private void curvePresetSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consideration = RightClickedNode.Tag as Consideration;
            (new CurvePresetForm(consideration.Curve)).ShowDialog();

            if (RightClickedNode.IsSelected)
            {
                ClearEditorPanel();
                SetEditorPanel(consideration.CreateEditorUI(EditingProject));
            }
        }
    }
}
