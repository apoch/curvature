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
            this.ClampingBehaviorComboBox = new System.Windows.Forms.ComboBox();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
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
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.ClampingBehaviorComboBox.TabIndex = 4;
            this.ClampingBehaviorComboBox.SelectedIndexChanged += new System.EventHandler(this.ClampingBehaviorComboBox_SelectedIndexChanged);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "DeleteItemIcon.png");
            // 
            // EditWidgetKnowledgeBaseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClampingBehaviorComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OriginComboBox);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.RecordTagEditBox);
            this.Name = "EditWidgetKnowledgeBaseRecord";
            this.Size = new System.Drawing.Size(753, 33);
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
    }
}
