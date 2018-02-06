using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature.Forms
{
    public partial class EnumerationEditorForm : Form
    {
        private HashSet<string> ValidEntries;


        public static void ShowEditor(HashSet<string> entries)
        {
            var form = new EnumerationEditorForm(entries);
            form.ShowDialog();
        }


        private EnumerationEditorForm(HashSet<string> entries)
        {
            InitializeComponent();

            ValidEntries = entries;

            foreach (var v in ValidEntries)
                EntriesListView.Items.Add(v);
        }

        private void AddNewEntryButton_Click(object sender, EventArgs e)
        {
            EntriesListView.Items.Add("New enumerated value");
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            var items = new List<ListViewItem>();
            foreach (ListViewItem i in EntriesListView.SelectedItems)
                items.Add(i);

            foreach (var i in items)
                EntriesListView.Items.Remove(i);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            ValidEntries.Clear();
            foreach (ListViewItem i in EntriesListView.Items)
                ValidEntries.Add(i.Text);

            Close();
        }
    }
}
