namespace Curvature
{
    partial class EditWidgetKnowledgeBase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KBDataGrid = new System.Windows.Forms.DataGridView();
            this.DataColumnTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataColumnMinValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataColumnMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KBDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // KBDataGrid
            // 
            this.KBDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KBDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KBDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataColumnTag,
            this.DataColumnMinValue,
            this.DataColumnMaximum});
            this.KBDataGrid.Location = new System.Drawing.Point(3, 3);
            this.KBDataGrid.Name = "KBDataGrid";
            this.KBDataGrid.Size = new System.Drawing.Size(372, 196);
            this.KBDataGrid.TabIndex = 0;
            // 
            // DataColumnTag
            // 
            this.DataColumnTag.HeaderText = "Tag";
            this.DataColumnTag.Name = "DataColumnTag";
            // 
            // DataColumnMinValue
            // 
            this.DataColumnMinValue.HeaderText = "Minimum";
            this.DataColumnMinValue.Name = "DataColumnMinValue";
            // 
            // DataColumnMaximum
            // 
            this.DataColumnMaximum.HeaderText = "Maximum";
            this.DataColumnMaximum.Name = "DataColumnMaximum";
            // 
            // EditWidgetKnowledgeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KBDataGrid);
            this.Name = "EditWidgetKnowledgeBase";
            this.Size = new System.Drawing.Size(378, 202);
            ((System.ComponentModel.ISupportInitialize)(this.KBDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KBDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumnTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumnMinValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumnMaximum;
    }
}
