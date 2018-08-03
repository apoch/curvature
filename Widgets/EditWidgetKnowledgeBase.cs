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
        private KnowledgeBase EditingKB;
        private Project EditingProject;

        public EditWidgetKnowledgeBase()
        {
            InitializeComponent();
        }

        internal void Attach(KnowledgeBase kb, Project project)
        {
            EditingKB = kb;
            EditingProject = project;
            RefreshKBControls();
        }


        private void RefreshKBControls()
        {
            foreach (Control c in KnowledgeBaseFlowPanel.Controls)
                c.Dispose();

            KnowledgeBaseFlowPanel.Controls.Clear();


            foreach (var rec in EditingKB.Records)
            {
                KnowledgeBaseFlowPanel.Controls.Add(new EditWidgetKnowledgeBaseRecord(rec, EditingProject));
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
                EditingKB.Records.Add(new KnowledgeBase.Record("New knowledge", false, KnowledgeBase.Record.Parameterization.FixedRange));
                EditingProject.MarkDirty();
                RefreshKBControls();
            };

            KnowledgeBaseFlowPanel.Controls.Add(newRecordButton);
            KnowledgeBaseFlowPanel.ScrollControlIntoView(newRecordButton);
        }
    }
}
