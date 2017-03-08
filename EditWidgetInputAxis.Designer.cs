namespace Curvature
{
    partial class EditWidgetInputAxis
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
            this.InputAxisNameLabel = new System.Windows.Forms.Label();
            this.ParameterGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // InputAxisNameLabel
            // 
            this.InputAxisNameLabel.AutoSize = true;
            this.InputAxisNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAxisNameLabel.Location = new System.Drawing.Point(3, 0);
            this.InputAxisNameLabel.Name = "InputAxisNameLabel";
            this.InputAxisNameLabel.Size = new System.Drawing.Size(157, 20);
            this.InputAxisNameLabel.TabIndex = 0;
            this.InputAxisNameLabel.Text = "Input Axis: (Name)";
            // 
            // ParameterGroupBox
            // 
            this.ParameterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterGroupBox.Location = new System.Drawing.Point(7, 23);
            this.ParameterGroupBox.Name = "ParameterGroupBox";
            this.ParameterGroupBox.Size = new System.Drawing.Size(390, 178);
            this.ParameterGroupBox.TabIndex = 1;
            this.ParameterGroupBox.TabStop = false;
            this.ParameterGroupBox.Text = "Parameters";
            // 
            // EditWidgetInputAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParameterGroupBox);
            this.Controls.Add(this.InputAxisNameLabel);
            this.Name = "EditWidgetInputAxis";
            this.Size = new System.Drawing.Size(400, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputAxisNameLabel;
        private System.Windows.Forms.GroupBox ParameterGroupBox;
    }
}
