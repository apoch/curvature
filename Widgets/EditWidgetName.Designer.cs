namespace Curvature
{
    partial class EditWidgetName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetName));
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ObjectTypeLabel = new System.Windows.Forms.Label();
            this.ObjectNameLabel = new System.Windows.Forms.Label();
            this.EditIcon = new System.Windows.Forms.Label();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.RenameWidgetTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.FlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanel.Controls.Add(this.ObjectTypeLabel);
            this.FlowPanel.Controls.Add(this.ObjectNameLabel);
            this.FlowPanel.Controls.Add(this.EditIcon);
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(398, 141);
            this.FlowPanel.TabIndex = 0;
            this.FlowPanel.WrapContents = false;
            // 
            // ObjectTypeLabel
            // 
            this.ObjectTypeLabel.AutoSize = true;
            this.ObjectTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.ObjectTypeLabel.Name = "ObjectTypeLabel";
            this.ObjectTypeLabel.Size = new System.Drawing.Size(127, 20);
            this.ObjectTypeLabel.TabIndex = 0;
            this.ObjectTypeLabel.Text = "Named Object:";
            // 
            // ObjectNameLabel
            // 
            this.ObjectNameLabel.AutoSize = true;
            this.ObjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ObjectNameLabel.Location = new System.Drawing.Point(136, 0);
            this.ObjectNameLabel.Name = "ObjectNameLabel";
            this.ObjectNameLabel.Size = new System.Drawing.Size(55, 20);
            this.ObjectNameLabel.TabIndex = 1;
            this.ObjectNameLabel.Text = "Name";
            // 
            // EditIcon
            // 
            this.EditIcon.ImageIndex = 0;
            this.EditIcon.ImageList = this.IconImageList;
            this.EditIcon.Location = new System.Drawing.Point(197, 0);
            this.EditIcon.Name = "EditIcon";
            this.EditIcon.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.EditIcon.Size = new System.Drawing.Size(18, 18);
            this.EditIcon.TabIndex = 2;
            this.RenameWidgetTooltip.SetToolTip(this.EditIcon, "Rename this item");
            this.EditIcon.Click += new System.EventHandler(this.EditIcon_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "RenameItemIcon.png");
            // 
            // EditWidgetName
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.FlowPanel);
            this.Name = "EditWidgetName";
            this.Size = new System.Drawing.Size(398, 141);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label ObjectTypeLabel;
        private System.Windows.Forms.Label ObjectNameLabel;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Label EditIcon;
        private System.Windows.Forms.ToolTip RenameWidgetTooltip;
    }
}
