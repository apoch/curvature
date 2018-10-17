namespace Curvature
{
    partial class EditWidgetParameter
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
            this.ParameterNameLabel = new System.Windows.Forms.Label();
            this.EnumerationPanel = new System.Windows.Forms.Panel();
            this.EnumerationDropDown = new System.Windows.Forms.ComboBox();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.NumericPanel = new System.Windows.Forms.Panel();
            this.MaximumValue = new System.Windows.Forms.NumericUpDown();
            this.MinimumValue = new System.Windows.Forms.NumericUpDown();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.EnumerationPanel.SuspendLayout();
            this.NumericPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ParameterNameLabel
            // 
            this.ParameterNameLabel.AutoSize = true;
            this.ParameterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParameterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ParameterNameLabel.Name = "ParameterNameLabel";
            this.ParameterNameLabel.Size = new System.Drawing.Size(147, 18);
            this.ParameterNameLabel.TabIndex = 0;
            this.ParameterNameLabel.Text = "(Parameter Name)";
            // 
            // EnumerationPanel
            // 
            this.EnumerationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationPanel.Controls.Add(this.EnumerationDropDown);
            this.EnumerationPanel.Controls.Add(this.EnumerationLabel);
            this.EnumerationPanel.Location = new System.Drawing.Point(0, 21);
            this.EnumerationPanel.Name = "EnumerationPanel";
            this.EnumerationPanel.Size = new System.Drawing.Size(318, 35);
            this.EnumerationPanel.TabIndex = 5;
            // 
            // EnumerationDropDown
            // 
            this.EnumerationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnumerationDropDown.FormattingEnabled = true;
            this.EnumerationDropDown.Items.AddRange(new object[] {
            "match",
            "don\'t match"});
            this.EnumerationDropDown.Location = new System.Drawing.Point(107, 7);
            this.EnumerationDropDown.Name = "EnumerationDropDown";
            this.EnumerationDropDown.Size = new System.Drawing.Size(110, 21);
            this.EnumerationDropDown.TabIndex = 5;
            this.EnumerationDropDown.SelectedIndexChanged += new System.EventHandler(this.EnumerationDropDown_SelectedIndexChanged);
            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(6, 10);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(95, 13);
            this.EnumerationLabel.TabIndex = 4;
            this.EnumerationLabel.Text = "Score 1.0 if values";
            // 
            // NumericPanel
            // 
            this.NumericPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericPanel.Controls.Add(this.MaximumValue);
            this.NumericPanel.Controls.Add(this.MinimumValue);
            this.NumericPanel.Controls.Add(this.MaxLabel);
            this.NumericPanel.Controls.Add(this.MinLabel);
            this.NumericPanel.Location = new System.Drawing.Point(0, 21);
            this.NumericPanel.Name = "NumericPanel";
            this.NumericPanel.Size = new System.Drawing.Size(319, 36);
            this.NumericPanel.TabIndex = 8;
            // 
            // MaximumValue
            // 
            this.MaximumValue.DecimalPlaces = 3;
            this.MaximumValue.Location = new System.Drawing.Point(219, 8);
            this.MaximumValue.Name = "MaximumValue";
            this.MaximumValue.Size = new System.Drawing.Size(94, 20);
            this.MaximumValue.TabIndex = 11;
            // 
            // MinimumValue
            // 
            this.MinimumValue.DecimalPlaces = 3;
            this.MinimumValue.Location = new System.Drawing.Point(59, 8);
            this.MinimumValue.Name = "MinimumValue";
            this.MinimumValue.Size = new System.Drawing.Size(94, 20);
            this.MinimumValue.TabIndex = 10;
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(163, 10);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(54, 13);
            this.MaxLabel.TabIndex = 9;
            this.MaxLabel.Text = "Maximum:";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(6, 10);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(51, 13);
            this.MinLabel.TabIndex = 8;
            this.MinLabel.Text = "Minimum:";
            // 
            // EditWidgetParameter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ParameterNameLabel);
            this.Controls.Add(this.EnumerationPanel);
            this.Controls.Add(this.NumericPanel);
            this.Name = "EditWidgetParameter";
            this.Size = new System.Drawing.Size(319, 57);
            this.EnumerationPanel.ResumeLayout(false);
            this.EnumerationPanel.PerformLayout();
            this.NumericPanel.ResumeLayout(false);
            this.NumericPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParameterNameLabel;
        private System.Windows.Forms.Panel EnumerationPanel;
        private System.Windows.Forms.Label EnumerationLabel;
        private System.Windows.Forms.ComboBox EnumerationDropDown;
        private System.Windows.Forms.Panel NumericPanel;
        private System.Windows.Forms.NumericUpDown MaximumValue;
        private System.Windows.Forms.NumericUpDown MinimumValue;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
    }
}
