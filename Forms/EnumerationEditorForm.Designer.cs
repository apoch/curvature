namespace Curvature.Forms
{
    partial class EnumerationEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnumerationEditorForm));
            this.EntriesListView = new System.Windows.Forms.ListView();
            this.EntryNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.AddNewEntryButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntriesListView
            // 
            this.EntriesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EntryNameHeader});
            this.EntriesListView.FullRowSelect = true;
            this.EntriesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EntriesListView.LabelEdit = true;
            this.EntriesListView.Location = new System.Drawing.Point(12, 12);
            this.EntriesListView.Name = "EntriesListView";
            this.EntriesListView.Size = new System.Drawing.Size(335, 178);
            this.EntriesListView.TabIndex = 0;
            this.EntriesListView.UseCompatibleStateImageBehavior = false;
            this.EntriesListView.View = System.Windows.Forms.View.Details;
            // 
            // EntryNameHeader
            // 
            this.EntryNameHeader.Text = "Entry";
            this.EntryNameHeader.Width = 260;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonOK.Location = new System.Drawing.Point(148, 207);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(93, 27);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(247, 207);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(93, 27);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // AddNewEntryButton
            // 
            this.AddNewEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEntryButton.ImageIndex = 0;
            this.AddNewEntryButton.ImageList = this.IconImageList;
            this.AddNewEntryButton.Location = new System.Drawing.Point(353, 12);
            this.AddNewEntryButton.Name = "AddNewEntryButton";
            this.AddNewEntryButton.Size = new System.Drawing.Size(124, 35);
            this.AddNewEntryButton.TabIndex = 3;
            this.AddNewEntryButton.Text = "Add Entry";
            this.AddNewEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewEntryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddNewEntryButton.UseVisualStyleBackColor = true;
            this.AddNewEntryButton.Click += new System.EventHandler(this.AddNewEntryButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            this.IconImageList.Images.SetKeyName(1, "DeleteItemIcon.png");
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEntryButton.ImageIndex = 1;
            this.DeleteEntryButton.ImageList = this.IconImageList;
            this.DeleteEntryButton.Location = new System.Drawing.Point(353, 53);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(124, 35);
            this.DeleteEntryButton.TabIndex = 4;
            this.DeleteEntryButton.Text = "Delete Selected";
            this.DeleteEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteEntryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteEntryButton.UseVisualStyleBackColor = true;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // EnumerationEditorForm
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.AddNewEntryButton);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.EntriesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnumerationEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enumeration Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EntriesListView;
        private System.Windows.Forms.ColumnHeader EntryNameHeader;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button AddNewEntryButton;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Button DeleteEntryButton;
    }
}