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
                FormulaModeRadioButton.Checked = true;
            else
                PropertyModeRadioButton.Checked = true;
        }

        private void RecordTagEditBox_TextChanged(object sender, EventArgs e)
        {
            EditRec.ReadableName = RecordTagEditBox.Text;
        }

        private void PropertyModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComputedMode();
        }

        private void FormulaModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComputedMode();
        }

        private void UpdateComputedMode()
        {
            if (FormulaModeRadioButton.Checked)
                EditRec.Computed = true;
            else
                EditRec.Computed = false;
        }
    }
}
