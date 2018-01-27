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
        private Project EditProject;

        public EditWidgetKnowledgeBase()
        {
            InitializeComponent();
        }

        internal void Attach(KnowledgeBase kb, Project project)
        {
            MyKB = kb;
            EditProject = project;
            RefreshKBControls();
        }


        private void RefreshKBControls()
        {
            foreach (Control c in KnowledgeBaseFlowPanel.Controls)
                c.Dispose();

            KnowledgeBaseFlowPanel.Controls.Clear();


            foreach (var rec in MyKB.Records)
            {
                KnowledgeBaseFlowPanel.Controls.Add(new EditWidgetKnowledgeBaseRecord(rec, EditProject));
            }

            var newRecordButton = new Button
            {
                ImageList = IconImageList,
                ImageIndex = 0,
                ImageAlign = ContentAlignment.MiddleRight,
                TextImageRelation = TextImageRelation.ImageBeforeText,

                Text = "Create Knowledge",
                AutoSize = true
            };

            newRecordButton.Click += (e, args) =>
            {
                MyKB.Records.Add(new KnowledgeBase.Record("New knowledge", false, KnowledgeBase.Record.Parameterization.FixedRange));
                EditProject.MarkDirty();
                RefreshKBControls();
            };

            KnowledgeBaseFlowPanel.Controls.Add(newRecordButton);
            KnowledgeBaseFlowPanel.ScrollControlIntoView(newRecordButton);
        }
    }
}
