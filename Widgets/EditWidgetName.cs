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
    public partial class EditWidgetName : UserControl
    {
        private INameable EditingObject;
        private Project EditingProject;

        public EditWidgetName()
        {
            InitializeComponent();
        }

        internal void Attach(string objectType, INameable editedObject, Project project)
        {
            EditingObject = editedObject;
            EditingProject = project;

            ObjectTypeLabel.Text = $"{objectType}:";
            ObjectNameLabel.Text = EditingObject.GetName();
        }

        private void EditIcon_Click(object sender, EventArgs e)
        {
            ObjectNameLabel.Visible = false;
            EditIcon.Visible = false;

            var edit = new TextBox
            {
                MinimumSize = new Size(85, 0),
                Size = ObjectNameLabel.Size,
                Location = ObjectNameLabel.Location,
                Text = ObjectNameLabel.Text
            };

            edit.KeyPress += (o, args) =>
            {
                if (ObjectNameLabel.Visible)
                    return;

                if (args.KeyChar == '\r' || args.KeyChar == '\n')
                {
                    ObjectNameLabel.Text = edit.Text;
                    ObjectNameLabel.Visible = true;
                    EditIcon.Visible = true;
                    EditingObject.Rename(edit.Text);
                    EditingProject.MarkDirty();
                    edit.Dispose();
                }
                else if (args.KeyChar == '\u001b')        // Escape
                {
                    ObjectNameLabel.Visible = true;
                    EditIcon.Visible = true;
                    edit.Dispose();
                }
            };

            edit.LostFocus += (o, args) =>
            {
                if (ObjectNameLabel.Visible)
                    return;

                EditingObject.Rename(edit.Text);
                EditingProject.MarkDirty();
                ObjectNameLabel.Text = edit.Text;
                ObjectNameLabel.Visible = true;
                EditIcon.Visible = true;
                edit.Dispose();
            };

            EditIcon.Parent = null;
            FlowPanel.Controls.Add(edit);
            FlowPanel.Controls.Add(EditIcon);

            edit.SelectAll();
            edit.Focus();
        }
    }
}
