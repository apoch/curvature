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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetKnowledgeBaseRecord));
            this.RecordTagEditBox = new System.Windows.Forms.TextBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.OriginComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.ClampingBehaviorComboBox = new System.Windows.Forms.ComboBox();
            this.RangeConfigurationPanel = new System.Windows.Forms.Panel();
            this.RangeMaximum = new System.Windows.Forms.NumericUpDown();
            this.RangeToLabel = new System.Windows.Forms.Label();
            this.RangeMinimum = new System.Windows.Forms.NumericUpDown();
            this.RangeValidValuesLabel = new System.Windows.Forms.Label();
            this.EnumerationPanel = new System.Windows.Forms.Panel();
            this.EditEnumerationButton = new System.Windows.Forms.Button();
            this.EnumerationValidComboBox = new System.Windows.Forms.ComboBox();
            this.PrefabPanel = new System.Windows.Forms.Panel();
            this.PrefabComboBox = new System.Windows.Forms.ComboBox();
            this.RangeConfigurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeMinimum)).BeginInit();
            this.EnumerationPanel.SuspendLayout();
            this.PrefabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordTagEditBox
            // 
            this.RecordTagEditBox.Location = new System.Drawing.Point(47, 3);
            this.RecordTagEditBox.Name = "RecordTagEditBox";
            this.RecordTagEditBox.Size = new System.Drawing.Size(217, 20);
            this.RecordTagEditBox.TabIndex = 1;
            this.RecordTagEditBox.TextChanged += new System.EventHandler(this.RecordTagEditBox_TextChanged);
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(11, 6);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(30, 13);
            this.TagLabel.TabIndex = 0;
            this.TagLabel.Text = "Title:";
            // 
            // OriginComboBox
            // 
            this.OriginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginComboBox.FormattingEnabled = true;
            this.OriginComboBox.Items.AddRange(new object[] {
            "is a property of every agent",
            "is computed using a prefab equation"});
            this.OriginComboBox.Location = new System.Drawing.Point(270, 3);
            this.OriginComboBox.Name = "OriginComboBox";
            this.OriginComboBox.Size = new System.Drawing.Size(198, 21);
            this.OriginComboBox.TabIndex = 2;
            this.OriginComboBox.SelectedIndexChanged += new System.EventHandler(this.OriginComboBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.ImageIndex = 0;
            this.DeleteButton.ImageList = this.IconImageList;
            this.DeleteButton.Location = new System.Drawing.Point(672, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 22);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "DeleteItemIcon.png");
            // 
            // ClampingBehaviorComboBox
            // 
            this.ClampingBehaviorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClampingBehaviorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClampingBehaviorComboBox.FormattingEnabled = true;
            this.ClampingBehaviorComboBox.Items.AddRange(new object[] {
            "and must be in a fixed range",
            "and must be in a configurable range",
            "and must be a predefined value"});
            this.ClampingBehaviorComboBox.Location = new System.Drawing.Point(474, 3);
            this.ClampingBehaviorComboBox.Name = "ClampingBehaviorComboBox";
            this.ClampingBehaviorComboBox.Size = new System.Drawing.Size(192, 21);
            this.ClampingBehaviorComboBox.TabIndex = 3;
            this.ClampingBehaviorComboBox.SelectedIndexChanged += new System.EventHandler(this.ClampingBehaviorComboBox_SelectedIndexChanged);
            // 
            // RangeConfigurationPanel
            // 
            this.RangeConfigurationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RangeConfigurationPanel.Controls.Add(this.RangeMaximum);
            this.RangeConfigurationPanel.Controls.Add(this.RangeToLabel);
            this.RangeConfigurationPanel.Controls.Add(this.RangeMinimum);
            this.RangeConfigurationPanel.Location = new System.Drawing.Point(84, 29);
            this.RangeConfigurationPanel.Name = "RangeConfigurationPanel";
            this.RangeConfigurationPanel.Size = new System.Drawing.Size(384, 31);
            this.RangeConfigurationPanel.TabIndex = 6;
            // 
            // RangeMaximum
            // 
            this.RangeMaximum.DecimalPlaces = 3;
            this.RangeMaximum.Location = new System.Drawing.Point(208, 3);
            this.RangeMaximum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.RangeMaximum.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.RangeMaximum.Name = "RangeMaximum";
            this.RangeMaximum.Size = new System.Drawing.Size(173, 20);
            this.RangeMaximum.TabIndex = 2;
            this.RangeMaximum.ValueChanged += new System.EventHandler(this.RangeMaximum_ValueChanged);
            // 
            // RangeToLabel
            // 
            this.RangeToLabel.AutoSize = true;
            this.RangeToLabel.Location = new System.Drawing.Point(186, 5);
            this.RangeToLabel.Name = "RangeToLabel";
            this.RangeToLabel.Size = new System.Drawing.Size(16, 13);
            this.RangeToLabel.TabIndex = 1;
            this.RangeToLabel.Text = "to";
            // 
            // RangeMinimum
            // 
            this.RangeMinimum.DecimalPlaces = 3;
            this.RangeMinimum.Location = new System.Drawing.Point(3, 3);
            this.RangeMinimum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.RangeMinimum.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.RangeMinimum.Name = "RangeMinimum";
            this.RangeMinimum.Size = new System.Drawing.Size(177, 20);
            this.RangeMinimum.TabIndex = 0;
            this.RangeMinimum.ValueChanged += new System.EventHandler(this.RangeMinimum_ValueChanged);
            // 
            // RangeValidValuesLabel
            // 
            this.RangeValidValuesLabel.AutoSize = true;
            this.RangeValidValuesLabel.Location = new System.Drawing.Point(11, 35);
            this.RangeValidValuesLabel.Name = "RangeValidValuesLabel";
            this.RangeValidValuesLabel.Size = new System.Drawing.Size(67, 13);
            this.RangeValidValuesLabel.TabIndex = 5;
            this.RangeValidValuesLabel.Text = "Valid values:";
            // 
            // EnumerationPanel
            // 
            this.EnumerationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationPanel.Controls.Add(this.EditEnumerationButton);
            this.EnumerationPanel.Controls.Add(this.EnumerationValidComboBox);
            this.EnumerationPanel.Location = new System.Drawing.Point(84, 29);
            this.EnumerationPanel.Name = "EnumerationPanel";
            this.EnumerationPanel.Size = new System.Drawing.Size(384, 31);
            this.EnumerationPanel.TabIndex = 7;
            this.EnumerationPanel.Visible = false;
            // 
            // EditEnumerationButton
            // 
            this.EditEnumerationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditEnumerationButton.Location = new System.Drawing.Point(321, 3);
            this.EditEnumerationButton.Name = "EditEnumerationButton";
            this.EditEnumerationButton.Size = new System.Drawing.Size(63, 21);
            this.EditEnumerationButton.TabIndex = 1;
            this.EditEnumerationButton.Text = "Edit...";
            this.EditEnumerationButton.UseVisualStyleBackColor = true;
            this.EditEnumerationButton.Click += new System.EventHandler(this.EditEnumerationButton_Click);
            // 
            // EnumerationValidComboBox
            // 
            this.EnumerationValidComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationValidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnumerationValidComboBox.FormattingEnabled = true;
            this.EnumerationValidComboBox.Location = new System.Drawing.Point(0, 3);
            this.EnumerationValidComboBox.Name = "EnumerationValidComboBox";
            this.EnumerationValidComboBox.Size = new System.Drawing.Size(315, 21);
            this.EnumerationValidComboBox.TabIndex = 0;
            // 
            // PrefabPanel
            // 
            this.PrefabPanel.Controls.Add(this.PrefabComboBox);
            this.PrefabPanel.Location = new System.Drawing.Point(471, 29);
            this.PrefabPanel.Name = "PrefabPanel";
            this.PrefabPanel.Size = new System.Drawing.Size(201, 31);
            this.PrefabPanel.TabIndex = 4;
            this.PrefabPanel.Visible = false;
            // 
            // PrefabComboBox
            // 
            this.PrefabComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrefabComboBox.FormattingEnabled = true;
            this.PrefabComboBox.Items.AddRange(new object[] {
            "Use distance prefab",
            "Use wall-clock prefab"});
            this.PrefabComboBox.Location = new System.Drawing.Point(3, 3);
            this.PrefabComboBox.Name = "PrefabComboBox";
            this.PrefabComboBox.Size = new System.Drawing.Size(192, 21);
            this.PrefabComboBox.TabIndex = 0;
            this.PrefabComboBox.SelectedIndexChanged += new System.EventHandler(this.PrefabComboBox_SelectedIndexChanged);
            // 
            // EditWidgetKnowledgeBaseRecord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.PrefabPanel);
            this.Controls.Add(this.RangeValidValuesLabel);
            this.Controls.Add(this.ClampingBehaviorComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OriginComboBox);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.RecordTagEditBox);
            this.Controls.Add(this.EnumerationPanel);
            this.Controls.Add(this.RangeConfigurationPanel);
            this.Name = "EditWidgetKnowledgeBaseRecord";
            this.Size = new System.Drawing.Size(753, 63);
            this.RangeConfigurationPanel.ResumeLayout(false);
            this.RangeConfigurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeMinimum)).EndInit();
            this.EnumerationPanel.ResumeLayout(false);
            this.PrefabPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecordTagEditBox;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.ComboBox OriginComboBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox ClampingBehaviorComboBox;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Panel RangeConfigurationPanel;
        private System.Windows.Forms.NumericUpDown RangeMinimum;
        private System.Windows.Forms.Label RangeToLabel;
        private System.Windows.Forms.Label RangeValidValuesLabel;
        private System.Windows.Forms.NumericUpDown RangeMaximum;
        private System.Windows.Forms.Panel EnumerationPanel;
        private System.Windows.Forms.Panel PrefabPanel;
        private System.Windows.Forms.ComboBox PrefabComboBox;
        private System.Windows.Forms.ComboBox EnumerationValidComboBox;
        private System.Windows.Forms.Button EditEnumerationButton;
    }
}
