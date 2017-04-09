namespace Curvature
{
    partial class EditWidgetKnowledgeBaseRecord
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
            this.RecordTagEditBox = new System.Windows.Forms.TextBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.OriginComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RecordTagEditBox
            // 
            this.RecordTagEditBox.Location = new System.Drawing.Point(47, 3);
            this.RecordTagEditBox.Name = "RecordTagEditBox";
            this.RecordTagEditBox.Size = new System.Drawing.Size(217, 20);
            this.RecordTagEditBox.TabIndex = 0;
            this.RecordTagEditBox.TextChanged += new System.EventHandler(this.RecordTagEditBox_TextChanged);
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(11, 6);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(30, 13);
            this.TagLabel.TabIndex = 1;
            this.TagLabel.Text = "Title:";
            // 
            // OriginComboBox
            // 
            this.OriginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginComboBox.FormattingEnabled = true;
            this.OriginComboBox.Items.AddRange(new object[] {
            "Stored as a property on an agent",
            "Computed using a known equation"});
            this.OriginComboBox.Location = new System.Drawing.Point(270, 3);
            this.OriginComboBox.Name = "OriginComboBox";
            this.OriginComboBox.Size = new System.Drawing.Size(244, 21);
            this.OriginComboBox.TabIndex = 2;
            this.OriginComboBox.SelectedIndexChanged += new System.EventHandler(this.OriginComboBox_SelectedIndexChanged);
            // 
            // EditWidgetKnowledgeBaseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OriginComboBox);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.RecordTagEditBox);
            this.Name = "EditWidgetKnowledgeBaseRecord";
            this.Size = new System.Drawing.Size(517, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecordTagEditBox;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.ComboBox OriginComboBox;
    }
}
