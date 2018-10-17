namespace Curvature
{
    partial class EditWidgetBehavior
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
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WhenActiveLabel = new System.Windows.Forms.Label();
            this.CustomPayload = new System.Windows.Forms.TextBox();
            this.CustomPayloadLabel = new System.Windows.Forms.Label();
            this.CanTargetOthersCheckBox = new System.Windows.Forms.CheckBox();
            this.CanTargetSelfCheckBox = new System.Windows.Forms.CheckBox();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.BehaviorWeightEditBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorWeightEditBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(32, 58);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(44, 13);
            this.WeightLabel.TabIndex = 15;
            this.WeightLabel.Text = "Weight:";
            // 
            // WhenActiveLabel
            // 
            this.WhenActiveLabel.AutoSize = true;
            this.WhenActiveLabel.Location = new System.Drawing.Point(5, 6);
            this.WhenActiveLabel.Name = "WhenActiveLabel";
            this.WhenActiveLabel.Size = new System.Drawing.Size(71, 13);
            this.WhenActiveLabel.TabIndex = 9;
            this.WhenActiveLabel.Text = "When active:";
            // 
            // CustomPayload
            // 
            this.CustomPayload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomPayload.Location = new System.Drawing.Point(82, 30);
            this.CustomPayload.Name = "CustomPayload";
            this.CustomPayload.Size = new System.Drawing.Size(607, 20);
            this.CustomPayload.TabIndex = 12;
            this.CustomPayload.TextChanged += new System.EventHandler(this.CustomPayload_TextChanged);
            // 
            // CustomPayloadLabel
            // 
            this.CustomPayloadLabel.AutoSize = true;
            this.CustomPayloadLabel.Location = new System.Drawing.Point(7, 33);
            this.CustomPayloadLabel.Name = "CustomPayloadLabel";
            this.CustomPayloadLabel.Size = new System.Drawing.Size(69, 13);
            this.CustomPayloadLabel.TabIndex = 11;
            this.CustomPayloadLabel.Text = "Custom Text:";
            // 
            // CanTargetOthersCheckBox
            // 
            this.CanTargetOthersCheckBox.AutoSize = true;
            this.CanTargetOthersCheckBox.Location = new System.Drawing.Point(92, 105);
            this.CanTargetOthersCheckBox.Name = "CanTargetOthersCheckBox";
            this.CanTargetOthersCheckBox.Size = new System.Drawing.Size(113, 17);
            this.CanTargetOthersCheckBox.TabIndex = 14;
            this.CanTargetOthersCheckBox.Text = "Can Target Others";
            this.CanTargetOthersCheckBox.UseVisualStyleBackColor = true;
            this.CanTargetOthersCheckBox.CheckedChanged += new System.EventHandler(this.CanTargetOthersCheckBox_CheckedChanged);
            // 
            // CanTargetSelfCheckBox
            // 
            this.CanTargetSelfCheckBox.AutoSize = true;
            this.CanTargetSelfCheckBox.Location = new System.Drawing.Point(92, 82);
            this.CanTargetSelfCheckBox.Name = "CanTargetSelfCheckBox";
            this.CanTargetSelfCheckBox.Size = new System.Drawing.Size(100, 17);
            this.CanTargetSelfCheckBox.TabIndex = 13;
            this.CanTargetSelfCheckBox.Text = "Can Target Self";
            this.CanTargetSelfCheckBox.UseVisualStyleBackColor = true;
            this.CanTargetSelfCheckBox.CheckedChanged += new System.EventHandler(this.CanTargetSelfCheckBox_CheckedChanged);
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(82, 3);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(607, 21);
            this.ActionComboBox.TabIndex = 10;
            this.ActionComboBox.SelectedIndexChanged += new System.EventHandler(this.ActionComboBox_SelectedIndexChanged);
            // 
            // BehaviorWeightEditBox
            // 
            this.BehaviorWeightEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorWeightEditBox.DecimalPlaces = 3;
            this.BehaviorWeightEditBox.Location = new System.Drawing.Point(82, 56);
            this.BehaviorWeightEditBox.Name = "BehaviorWeightEditBox";
            this.BehaviorWeightEditBox.Size = new System.Drawing.Size(607, 20);
            this.BehaviorWeightEditBox.TabIndex = 16;
            this.BehaviorWeightEditBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BehaviorWeightEditBox.ValueChanged += new System.EventHandler(this.BehaviorWeightEditBox_ValueChanged);
            // 
            // EditWidgetBehavior
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.WhenActiveLabel);
            this.Controls.Add(this.CustomPayload);
            this.Controls.Add(this.CustomPayloadLabel);
            this.Controls.Add(this.CanTargetOthersCheckBox);
            this.Controls.Add(this.CanTargetSelfCheckBox);
            this.Controls.Add(this.ActionComboBox);
            this.Controls.Add(this.BehaviorWeightEditBox);
            this.Name = "EditWidgetBehavior";
            this.Size = new System.Drawing.Size(692, 136);
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorWeightEditBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label WhenActiveLabel;
        private System.Windows.Forms.TextBox CustomPayload;
        private System.Windows.Forms.Label CustomPayloadLabel;
        private System.Windows.Forms.CheckBox CanTargetOthersCheckBox;
        private System.Windows.Forms.CheckBox CanTargetSelfCheckBox;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.NumericUpDown BehaviorWeightEditBox;
    }
}
