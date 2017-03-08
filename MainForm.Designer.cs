namespace Curvature
{
    partial class MainForm
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
            this.ContentTree = new System.Windows.Forms.TreeView();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ContentTree
            // 
            this.ContentTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContentTree.Location = new System.Drawing.Point(13, 13);
            this.ContentTree.Name = "ContentTree";
            this.ContentTree.Size = new System.Drawing.Size(272, 568);
            this.ContentTree.TabIndex = 0;
            this.ContentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ContentTree_AfterSelect);
            // 
            // EditorPanel
            // 
            this.EditorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorPanel.Location = new System.Drawing.Point(291, 12);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(684, 569);
            this.EditorPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 593);
            this.Controls.Add(this.EditorPanel);
            this.Controls.Add(this.ContentTree);
            this.Name = "MainForm";
            this.Text = "Curvature Studio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ContentTree;
        private System.Windows.Forms.Panel EditorPanel;
    }
}

