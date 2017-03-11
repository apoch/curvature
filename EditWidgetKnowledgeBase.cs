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
    public partial class EditWidgetKnowledgeBase : UserControl
    {
        private KnowledgeBase MyKB;

        internal EditWidgetKnowledgeBase(KnowledgeBase kb)
        {
            InitializeComponent();
            MyKB = kb;

            foreach (var rec in MyKB.Records)
            {
                var row = new DataGridViewRow();
                row.CreateCells(KBDataGrid);
                row.Tag = rec;
                row.SetValues(rec.ReadableName, rec.Computed ? "Yes" : "No", $"{rec.MinimumValue:f3}", $"{rec.MaximumValue:f3}");

                KBDataGrid.Rows.Add(row);
            }
        }
    }
}
