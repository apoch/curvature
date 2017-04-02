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
        }
    }
}
