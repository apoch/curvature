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
        private INameable EditedObject;
        private Project EditedProject;

        public EditWidgetName()
        {
            InitializeComponent();
        }

        internal void Attach(string objectType, INameable editedObject, Project project)
        {
            EditedObject = editedObject;
            EditedProject = project;

            ObjectTypeLabel.Text = $"{objectType}:";
            ObjectNameLabel.Text = EditedObject.GetName();
        }

        private void EditIcon_Click(object sender, EventArgs e)
        {
            ObjectNameLabel.Visible = false;
            EditIcon.Visible = false;

            var edit = new TextBox();
            edit.MinimumSize = new Size(85, 0);
            edit.Size = ObjectNameLabel.Size;
            edit.Location = ObjectNameLabel.Location;
            edit.Text = ObjectNameLabel.Text;

            edit.KeyPress += (o, args) =>
            {
                if (ObjectNameLabel.Visible)
                    return;

                if (args.KeyChar == '\r' || args.KeyChar == '\n')
                {
                    ObjectNameLabel.Text = edit.Text;
                    ObjectNameLabel.Visible = true;
                    EditIcon.Visible = true;
                    EditedObject.Rename(edit.Text);
                    EditedProject.MarkDirty();
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

                EditedObject.Rename(edit.Text);
                EditedProject.MarkDirty();
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
