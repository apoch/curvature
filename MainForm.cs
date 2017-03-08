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

        public MainForm()
        {
            InitializeComponent();

            EditingProject = new Project();
            EditingProject.PopulateUI(ContentTree);
        }

        private void ContentTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (Control c in EditorPanel.Controls)
                c.Dispose();

            if (e.Node == null || e.Node.Tag == null)
                return;

            var editable = e.Node.Tag as IUserEditable;
            if (editable == null)
                return;

            var ctl = editable.CreateEditorUI(EditingProject);
            EditorPanel.Controls.Add(ctl);
            ctl.Dock = DockStyle.Fill;
        }
    }
}
