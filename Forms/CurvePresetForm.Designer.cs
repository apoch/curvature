namespace Curvature
{
    partial class CurvePresetForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IncreasingDecreasingComboBox = new System.Windows.Forms.ComboBox();
            this.IncreasingDecreasingLabel = new System.Windows.Forms.Label();
            this.SuggestedPresetList = new System.Windows.Forms.ListView();
            this.PresetNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurveTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuggestionsLabel = new System.Windows.Forms.Label();
            this.CancelPresetsButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.AccelerationComboBox = new System.Windows.Forms.ComboBox();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.PreviewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IncreasingDecreasingComboBox
            // 
            this.IncreasingDecreasingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IncreasingDecreasingComboBox.FormattingEnabled = true;
            this.IncreasingDecreasingComboBox.Items.AddRange(new object[] {
            "becomes steadily more appealing",
            "becomes steadily less appealing",
            "stays constant",
            "fluctuates"});
            this.IncreasingDecreasingComboBox.Location = new System.Drawing.Point(272, 12);
            this.IncreasingDecreasingComboBox.Name = "IncreasingDecreasingComboBox";
            this.IncreasingDecreasingComboBox.Size = new System.Drawing.Size(304, 21);
            this.IncreasingDecreasingComboBox.TabIndex = 1;
            this.IncreasingDecreasingComboBox.SelectedIndexChanged += new System.EventHandler(this.IncreasingDecreasingComboBox_SelectedIndexChanged);
            // 
            // IncreasingDecreasingLabel
            // 
            this.IncreasingDecreasingLabel.AutoSize = true;
            this.IncreasingDecreasingLabel.Location = new System.Drawing.Point(12, 15);
            this.IncreasingDecreasingLabel.Name = "IncreasingDecreasingLabel";
            this.IncreasingDecreasingLabel.Size = new System.Drawing.Size(245, 13);
            this.IncreasingDecreasingLabel.TabIndex = 0;
            this.IncreasingDecreasingLabel.Text = "As input values grow towards 1, this consideration:";
            // 
            // SuggestedPresetList
            // 
            this.SuggestedPresetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SuggestedPresetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PresetNameColumn,
            this.CurveTypeColumn});
            this.SuggestedPresetList.FullRowSelect = true;
            this.SuggestedPresetList.Location = new System.Drawing.Point(15, 98);
            this.SuggestedPresetList.Name = "SuggestedPresetList";
            this.SuggestedPresetList.Size = new System.Drawing.Size(378, 176);
            this.SuggestedPresetList.TabIndex = 5;
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
            // SuggestionsLabel
            // 
            this.SuggestionsLabel.AutoSize = true;
            this.SuggestionsLabel.Location = new System.Drawing.Point(12, 78);
            this.SuggestionsLabel.Name = "SuggestionsLabel";
            this.SuggestionsLabel.Size = new System.Drawing.Size(68, 13);
            this.SuggestionsLabel.TabIndex = 4;
            this.SuggestionsLabel.Text = "Suggestions:";
            // 
            // CancelPresetsButton
            // 
            this.CancelPresetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelPresetsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPresetsButton.Location = new System.Drawing.Point(501, 280);
            this.CancelPresetsButton.Name = "CancelPresetsButton";
            this.CancelPresetsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPresetsButton.TabIndex = 8;
            this.CancelPresetsButton.Text = "Cancel";
            this.CancelPresetsButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(420, 280);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AccelerationComboBox
            // 
            this.AccelerationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccelerationComboBox.FormattingEnabled = true;
            this.AccelerationComboBox.Items.AddRange(new object[] {
            "constant/linear",
            "slow at first, fast later",
            "fast at first, slow later",
            "more dynamic",
            "slow at either end, fast in the middle",
            "fast at either end, slow in the middle"});
            this.AccelerationComboBox.Location = new System.Drawing.Point(272, 39);
            this.AccelerationComboBox.Name = "AccelerationComboBox";
            this.AccelerationComboBox.Size = new System.Drawing.Size(304, 21);
            this.AccelerationComboBox.TabIndex = 3;
            this.AccelerationComboBox.SelectedIndexChanged += new System.EventHandler(this.AccelerationComboBox_SelectedIndexChanged);
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.AutoSize = true;
            this.AccelerationLabel.Location = new System.Drawing.Point(12, 42);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(247, 13);
            this.AccelerationLabel.TabIndex = 2;
            this.AccelerationLabel.Text = "The rate of change of this consideration should be:";
            // 
            // PreviewBox
            // 
            this.PreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewBox.BackColor = System.Drawing.Color.White;
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviewBox.Location = new System.Drawing.Point(399, 98);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(176, 176);
            this.PreviewBox.TabIndex = 10;
            this.PreviewBox.TabStop = false;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(396, 82);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(48, 13);
            this.PreviewLabel.TabIndex = 6;
            this.PreviewLabel.Text = "Preview:";
            // 
            // CurvePresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 315);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.AccelerationLabel);
            this.Controls.Add(this.AccelerationComboBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelPresetsButton);
            this.Controls.Add(this.SuggestionsLabel);
            this.Controls.Add(this.SuggestedPresetList);
            this.Controls.Add(this.IncreasingDecreasingLabel);
            this.Controls.Add(this.IncreasingDecreasingComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurvePresetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curve Preset Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IncreasingDecreasingComboBox;
        private System.Windows.Forms.Label IncreasingDecreasingLabel;
        private System.Windows.Forms.ListView SuggestedPresetList;
        private System.Windows.Forms.Label SuggestionsLabel;
        private System.Windows.Forms.Button CancelPresetsButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox AccelerationComboBox;
        private System.Windows.Forms.Label AccelerationLabel;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.ColumnHeader PresetNameColumn;
        private System.Windows.Forms.ColumnHeader CurveTypeColumn;
    }
}