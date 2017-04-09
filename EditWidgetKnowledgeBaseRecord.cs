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
    public partial class EditWidgetKnowledgeBaseRecord : UserControl
    {
        private KnowledgeBase.Record EditRec;

        internal EditWidgetKnowledgeBaseRecord(KnowledgeBase.Record rec)
        {
            InitializeComponent();
            EditRec = rec;

            RecordTagEditBox.Text = EditRec.ReadableName;

            if (EditRec.Computed)
                OriginComboBox.SelectedIndex = 1;
            else
                OriginComboBox.SelectedIndex = 0;
        }

        private void RecordTagEditBox_TextChanged(object sender, EventArgs e)
        {
            EditRec.ReadableName = RecordTagEditBox.Text;
        }

        private void UpdateComputedMode()
        {
            if (OriginComboBox.SelectedIndex == 1)
                EditRec.Computed = true;
            else
                EditRec.Computed = false;
        }

        private void OriginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComputedMode();
        }
    }
}
