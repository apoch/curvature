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
            this.KnowledgeBaseFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            // EditWidgetKnowledgeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KnowledgeBaseFlowPanel);
            this.Name = "EditWidgetKnowledgeBase";
            this.Size = new System.Drawing.Size(474, 202);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel KnowledgeBaseFlowPanel;
    }
}
