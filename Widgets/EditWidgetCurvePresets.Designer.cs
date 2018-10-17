namespace Curvature.Widgets
{
    partial class EditWidgetCurvePresets
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
            this.SuggestedPresetList = new System.Windows.Forms.ListView();
            this.PresetNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurveTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncreasingDecreasingLabel = new System.Windows.Forms.Label();
            this.IncreasingDecreasingComboBox = new System.Windows.Forms.ComboBox();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.AccelerationComboBox = new System.Windows.Forms.ComboBox();
            this.SuggestionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SuggestedPresetList
            // 
            this.SuggestedPresetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuggestedPresetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PresetNameColumn,
            this.CurveTypeColumn});
            this.SuggestedPresetList.FullRowSelect = true;
            this.SuggestedPresetList.Location = new System.Drawing.Point(6, 92);
            this.SuggestedPresetList.Name = "SuggestedPresetList";
            this.SuggestedPresetList.Size = new System.Drawing.Size(378, 183);
            this.SuggestedPresetList.TabIndex = 16;
            this.SuggestedPresetList.UseCompatibleStateImageBehavior = false;
            this.SuggestedPresetList.View = System.Windows.Forms.View.Details;
            // 
            // PresetNameColumn
            // 
            this.PresetNameColumn.Text = "Preset Name";
            this.PresetNameColumn.Width = 230;
            // 
            // CurveTypeColumn
            // 
            this.CurveTypeColumn.Text = "Curve Type";
            this.CurveTypeColumn.Width = 100;
            // 
            // IncreasingDecreasingLabel
            // 
            this.IncreasingDecreasingLabel.AutoSize = true;
            this.IncreasingDecreasingLabel.Location = new System.Drawing.Point(3, 9);
            this.IncreasingDecreasingLabel.Name = "IncreasingDecreasingLabel";
            this.IncreasingDecreasingLabel.Size = new System.Drawing.Size(245, 13);
            this.IncreasingDecreasingLabel.TabIndex = 11;
            this.IncreasingDecreasingLabel.Text = "As input values grow towards 1, this consideration:";
            // 
            // IncreasingDecreasingComboBox
            // 
            this.IncreasingDecreasingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreasingDecreasingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IncreasingDecreasingComboBox.FormattingEnabled = true;
            this.IncreasingDecreasingComboBox.Items.AddRange(new object[] {
            "becomes steadily more appealing",
            "becomes steadily less appealing",
            "stays constant",
            "fluctuates"});
            this.IncreasingDecreasingComboBox.Location = new System.Drawing.Point(263, 6);
            this.IncreasingDecreasingComboBox.Name = "IncreasingDecreasingComboBox";
            this.IncreasingDecreasingComboBox.Size = new System.Drawing.Size(304, 21);
            this.IncreasingDecreasingComboBox.TabIndex = 12;
            this.IncreasingDecreasingComboBox.SelectedIndexChanged += new System.EventHandler(this.IncreasingDecreasingComboBox_SelectedIndexChanged);
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(387, 76);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(48, 13);
            this.PreviewLabel.TabIndex = 17;
            this.PreviewLabel.Text = "Preview:";
            // 
            // PreviewBox
            // 
            this.PreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewBox.BackColor = System.Drawing.Color.White;
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviewBox.Location = new System.Drawing.Point(390, 92);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(176, 183);
            this.PreviewBox.TabIndex = 20;
            this.PreviewBox.TabStop = false;
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.AutoSize = true;
            this.AccelerationLabel.Location = new System.Drawing.Point(3, 36);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(247, 13);
            this.AccelerationLabel.TabIndex = 13;
            this.AccelerationLabel.Text = "The rate of change of this consideration should be:";
            // 
            // AccelerationComboBox
            // 
            this.AccelerationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccelerationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccelerationComboBox.FormattingEnabled = true;
            this.AccelerationComboBox.Items.AddRange(new object[] {
            "constant/linear",
            "slow at first, fast later",
            "fast at first, slow later",
            "more dynamic",
            "slow at either end, fast in the middle",
            "fast at either end, slow in the middle"});
            this.AccelerationComboBox.Location = new System.Drawing.Point(263, 33);
            this.AccelerationComboBox.Name = "AccelerationComboBox";
            this.AccelerationComboBox.Size = new System.Drawing.Size(304, 21);
            this.AccelerationComboBox.TabIndex = 14;
            this.AccelerationComboBox.SelectedIndexChanged += new System.EventHandler(this.AccelerationComboBox_SelectedIndexChanged);
            // 
            // SuggestionsLabel
            // 
            this.SuggestionsLabel.AutoSize = true;
            this.SuggestionsLabel.Location = new System.Drawing.Point(3, 72);
            this.SuggestionsLabel.Name = "SuggestionsLabel";
            this.SuggestionsLabel.Size = new System.Drawing.Size(68, 13);
            this.SuggestionsLabel.TabIndex = 15;
            this.SuggestionsLabel.Text = "Suggestions:";
            // 
            // EditWidgetCurvePresets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.SuggestedPresetList);
            this.Controls.Add(this.IncreasingDecreasingLabel);
            this.Controls.Add(this.IncreasingDecreasingComboBox);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.AccelerationLabel);
            this.Controls.Add(this.AccelerationComboBox);
            this.Controls.Add(this.SuggestionsLabel);
            this.Name = "EditWidgetCurvePresets";
            this.Size = new System.Drawing.Size(575, 284);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SuggestedPresetList;
        private System.Windows.Forms.ColumnHeader PresetNameColumn;
        private System.Windows.Forms.ColumnHeader CurveTypeColumn;
        private System.Windows.Forms.Label IncreasingDecreasingLabel;
        private System.Windows.Forms.ComboBox IncreasingDecreasingComboBox;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Label AccelerationLabel;
        private System.Windows.Forms.ComboBox AccelerationComboBox;
        private System.Windows.Forms.Label SuggestionsLabel;
    }
}
