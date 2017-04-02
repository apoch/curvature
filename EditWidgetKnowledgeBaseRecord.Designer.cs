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
            this.PropertyModeRadioButton = new System.Windows.Forms.RadioButton();
            this.FormulaModeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RecordTagEditBox
            // 
            this.RecordTagEditBox.Location = new System.Drawing.Point(47, 3);
            this.RecordTagEditBox.Name = "RecordTagEditBox";
            this.RecordTagEditBox.Size = new System.Drawing.Size(217, 20);
            this.RecordTagEditBox.TabIndex = 0;
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
            // PropertyModeRadioButton
            // 
            this.PropertyModeRadioButton.AutoSize = true;
            this.PropertyModeRadioButton.Location = new System.Drawing.Point(47, 29);
            this.PropertyModeRadioButton.Name = "PropertyModeRadioButton";
            this.PropertyModeRadioButton.Size = new System.Drawing.Size(192, 17);
            this.PropertyModeRadioButton.TabIndex = 2;
            this.PropertyModeRadioButton.TabStop = true;
            this.PropertyModeRadioButton.Text = "Stored as a property on each agent";
            this.PropertyModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormulaModeRadioButton
            // 
            this.FormulaModeRadioButton.AutoSize = true;
            this.FormulaModeRadioButton.Location = new System.Drawing.Point(47, 52);
            this.FormulaModeRadioButton.Name = "FormulaModeRadioButton";
            this.FormulaModeRadioButton.Size = new System.Drawing.Size(171, 17);
            this.FormulaModeRadioButton.TabIndex = 3;
            this.FormulaModeRadioButton.TabStop = true;
            this.FormulaModeRadioButton.Text = "Computed via a known formula";
            this.FormulaModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // EditWidgetKnowledgeBaseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormulaModeRadioButton);
            this.Controls.Add(this.PropertyModeRadioButton);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.RecordTagEditBox);
            this.Name = "EditWidgetKnowledgeBaseRecord";
            this.Size = new System.Drawing.Size(289, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecordTagEditBox;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.RadioButton PropertyModeRadioButton;
        private System.Windows.Forms.RadioButton FormulaModeRadioButton;
    }
}
