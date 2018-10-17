namespace Curvature
{
    partial class EditWidgetInputs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetInputs));
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.NewInputButton = new System.Windows.Forms.Button();
            this.ScrollablePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            // 
            // NewInputButton
            // 
            this.NewInputButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewInputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewInputButton.ImageIndex = 0;
            this.NewInputButton.ImageList = this.IconImageList;
            this.NewInputButton.Location = new System.Drawing.Point(0, 225);
            this.NewInputButton.Name = "NewInputButton";
            this.NewInputButton.Size = new System.Drawing.Size(426, 30);
            this.NewInputButton.TabIndex = 1;
            this.NewInputButton.Text = "Create Input Axis";
            this.NewInputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewInputButton.UseVisualStyleBackColor = true;
            // 
            // ScrollablePanel
            // 
            this.ScrollablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollablePanel.AutoScroll = true;
            this.ScrollablePanel.Location = new System.Drawing.Point(3, 3);
            this.ScrollablePanel.Name = "ScrollablePanel";
            this.ScrollablePanel.Size = new System.Drawing.Size(420, 216);
            this.ScrollablePanel.TabIndex = 2;
            // 
            // EditWidgetInputs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ScrollablePanel);
            this.Controls.Add(this.NewInputButton);
            this.Name = "EditWidgetInputs";
            this.Size = new System.Drawing.Size(426, 255);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Button NewInputButton;
        private System.Windows.Forms.Panel ScrollablePanel;
    }
}
