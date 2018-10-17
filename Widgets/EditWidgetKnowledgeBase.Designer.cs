namespace Curvature
{
    partial class EditWidgetKnowledgeBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetKnowledgeBase));
            this.KnowledgeBaseFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // KnowledgeBaseFlowPanel
            // 
            this.KnowledgeBaseFlowPanel.AutoScroll = true;
            this.KnowledgeBaseFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KnowledgeBaseFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.KnowledgeBaseFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.KnowledgeBaseFlowPanel.Name = "KnowledgeBaseFlowPanel";
            this.KnowledgeBaseFlowPanel.Size = new System.Drawing.Size(474, 202);
            this.KnowledgeBaseFlowPanel.TabIndex = 0;
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            // 
            // EditWidgetKnowledgeBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.KnowledgeBaseFlowPanel);
            this.Name = "EditWidgetKnowledgeBase";
            this.Size = new System.Drawing.Size(474, 202);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel KnowledgeBaseFlowPanel;
        private System.Windows.Forms.ImageList IconImageList;
    }
}
