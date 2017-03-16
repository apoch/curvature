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
            this.components = new System.ComponentModel.Container();
            this.ContentTree = new System.Windows.Forms.TreeView();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.PrimaryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.ContextMenuBehavior = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNewConsiderationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBehaviorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            this.PrimaryMenuStrip.SuspendLayout();
            this.ContextMenuBehavior.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentTree
            // 
            this.ContentTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContentTree.Location = new System.Drawing.Point(13, 27);
            this.ContentTree.Name = "ContentTree";
            this.ContentTree.Size = new System.Drawing.Size(272, 507);
            this.ContentTree.TabIndex = 0;
            this.ContentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ContentTree_AfterSelect);
            // 
            // EditorPanel
            // 
            this.EditorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorPanel.Location = new System.Drawing.Point(291, 27);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(684, 507);
            this.EditorPanel.TabIndex = 1;
            // 
            // PrimaryMenuStrip
            // 
            this.PrimaryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.PrimaryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrimaryMenuStrip.Name = "PrimaryMenuStrip";
            this.PrimaryMenuStrip.Size = new System.Drawing.Size(987, 24);
            this.PrimaryMenuStrip.TabIndex = 2;
            this.PrimaryMenuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newProjectToolStripMenuItem.Text = "&New Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveProjectToolStripMenuItem.Text = "&Save Project";
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project &As...";
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openProjectToolStripMenuItem.Text = "&Open Project...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // SaveFileDialogBox
            // 
            this.SaveFileDialogBox.DefaultExt = "xml";
            this.SaveFileDialogBox.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.SaveFileDialogBox.Title = "Save Curvature Project";
            // 
            // ContextMenuBehavior
            // 
            this.ContextMenuBehavior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewConsiderationToolStripMenuItem,
            this.deleteBehaviorToolStripMenuItem});
            this.ContextMenuBehavior.Name = "ContextMenuBehavior";
            this.ContextMenuBehavior.Size = new System.Drawing.Size(218, 48);
            this.ContextMenuBehavior.Text = "ContextMenuBehavior";
            // 
            // createNewConsiderationToolStripMenuItem
            // 
            this.createNewConsiderationToolStripMenuItem.Name = "createNewConsiderationToolStripMenuItem";
            this.createNewConsiderationToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.createNewConsiderationToolStripMenuItem.Text = "Create new consideration...";
            this.createNewConsiderationToolStripMenuItem.Click += new System.EventHandler(this.createNewConsiderationToolStripMenuItem_Click);
            // 
            // deleteBehaviorToolStripMenuItem
            // 
            this.deleteBehaviorToolStripMenuItem.Name = "deleteBehaviorToolStripMenuItem";
            this.deleteBehaviorToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.deleteBehaviorToolStripMenuItem.Text = "Delete behavior";
            // 
            // OpenFileDialogBox
            // 
            this.OpenFileDialogBox.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 546);
            this.Controls.Add(this.EditorPanel);
            this.Controls.Add(this.ContentTree);
            this.Controls.Add(this.PrimaryMenuStrip);
            this.MainMenuStrip = this.PrimaryMenuStrip;
            this.Name = "MainForm";
            this.Text = "Curvature Studio";
            this.PrimaryMenuStrip.ResumeLayout(false);
            this.PrimaryMenuStrip.PerformLayout();
            this.ContextMenuBehavior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ContentTree;
        private System.Windows.Forms.Panel EditorPanel;
        private System.Windows.Forms.MenuStrip PrimaryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogBox;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBehavior;
        private System.Windows.Forms.ToolStripMenuItem createNewConsiderationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBehaviorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogBox;
    }
}

