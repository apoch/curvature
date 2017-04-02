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

            RefreshKBControls();
        }


        private void RefreshKBControls()
        {
            foreach (Control c in KnowledgeBaseFlowPanel.Controls)
                c.Dispose();

            KnowledgeBaseFlowPanel.Controls.Clear();


            foreach (var rec in MyKB.Records)
            {
                KnowledgeBaseFlowPanel.Controls.Add(new EditWidgetKnowledgeBaseRecord(rec));
            }

            var newRecordButton = new Button();
            newRecordButton.Text = "Add New Knowledge";
            newRecordButton.AutoSize = true;
            newRecordButton.Click += (e, args) =>
            {
                MyKB.Records.Add(new KnowledgeBase.Record("New knowledge", 0.0, 1.0, false));
                RefreshKBControls();
            };

            KnowledgeBaseFlowPanel.Controls.Add(newRecordButton);
            KnowledgeBaseFlowPanel.ScrollControlIntoView(newRecordButton);
        }
    }
}
