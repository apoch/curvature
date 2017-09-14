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

        public EditWidgetName()
        {
            InitializeComponent();
        }

        internal void Attach(string objectType, INameable editedObject)
        {
            EditedObject = editedObject;

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
                if (args.KeyChar == '\r' || args.KeyChar == '\n')
                {
                    EditedObject.Rename(edit.Text);
                    ObjectNameLabel.Text = edit.Text;
                    edit.Dispose();
                    ObjectNameLabel.Visible = true;
                    EditIcon.Visible = true;
                }
                else if (args.KeyChar == '\u001b')        // Escape
                {
                    edit.Text = ObjectNameLabel.Text;
                    edit.Dispose();
                    ObjectNameLabel.Visible = true;
                    EditIcon.Visible = true;
                }
            };

            edit.LostFocus += (o, args) =>
            {
                EditedObject.Rename(edit.Text);
                ObjectNameLabel.Text = edit.Text;
                edit.Dispose();
                ObjectNameLabel.Visible = true;
                EditIcon.Visible = true;
            };

            EditIcon.Parent = null;
            FlowPanel.Controls.Add(edit);
            FlowPanel.Controls.Add(EditIcon);

            edit.SelectAll();
            edit.Focus();
        }
    }
}
