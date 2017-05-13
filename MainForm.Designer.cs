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
            this.PrimaryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialogBox = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.ProjectTab = new System.Windows.Forms.TabPage();
            this.KnowledgeTab = new System.Windows.Forms.TabPage();
            this.InputsTab = new System.Windows.Forms.TabPage();
            this.BehaviorsTab = new System.Windows.Forms.TabPage();
            this.BehaviorTabs = new System.Windows.Forms.TabControl();
            this.BehaviorOverviewTab = new System.Windows.Forms.TabPage();
            this.BehaviorConsiderationsTab = new System.Windows.Forms.TabPage();
            this.AddConsiderationButton = new System.Windows.Forms.Button();
            this.ConsiderationsListView = new System.Windows.Forms.ListView();
            this.ConsiderationNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateBehaviorButton = new System.Windows.Forms.Button();
            this.BehaviorsListView = new System.Windows.Forms.ListView();
            this.BehaviorNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BehaviorSetsTab = new System.Windows.Forms.TabPage();
            this.ArchetypesTab = new System.Windows.Forms.TabPage();
            this.ScenariosTab = new System.Windows.Forms.TabPage();
            this.ScenarioPanel = new System.Windows.Forms.Panel();
            this.CreateScenarioButton = new System.Windows.Forms.Button();
            this.ProjectEditWidget = new Curvature.EditWidgetProject();
            this.KnowledgeBaseEditWidget = new Curvature.EditWidgetKnowledgeBase();
            this.InputsEditWidget = new Curvature.EditWidgetInputs();
            this.BehaviorEditWidget = new Curvature.EditWidgetBehavior();
            this.ConsiderationEditWidget = new Curvature.EditWidgetConsideration();
            this.PrimaryMenuStrip.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.KnowledgeTab.SuspendLayout();
            this.InputsTab.SuspendLayout();
            this.BehaviorsTab.SuspendLayout();
            this.BehaviorTabs.SuspendLayout();
            this.BehaviorOverviewTab.SuspendLayout();
            this.BehaviorConsiderationsTab.SuspendLayout();
            this.ScenariosTab.SuspendLayout();
            this.SuspendLayout();
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
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
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
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveProjectToolStripMenuItem.Text = "&Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project &As...";
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SaveFileDialogBox
            // 
            this.SaveFileDialogBox.DefaultExt = "xml";
            this.SaveFileDialogBox.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.SaveFileDialogBox.Title = "Save Curvature Project";
            // 
            // OpenFileDialogBox
            // 
            this.OpenFileDialogBox.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // MainTabs
            // 
            this.MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabs.Controls.Add(this.ProjectTab);
            this.MainTabs.Controls.Add(this.KnowledgeTab);
            this.MainTabs.Controls.Add(this.InputsTab);
            this.MainTabs.Controls.Add(this.BehaviorsTab);
            this.MainTabs.Controls.Add(this.BehaviorSetsTab);
            this.MainTabs.Controls.Add(this.ArchetypesTab);
            this.MainTabs.Controls.Add(this.ScenariosTab);
            this.MainTabs.Location = new System.Drawing.Point(12, 27);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(963, 623);
            this.MainTabs.TabIndex = 4;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Controls.Add(this.ProjectEditWidget);
            this.ProjectTab.Location = new System.Drawing.Point(4, 22);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProjectTab.Size = new System.Drawing.Size(955, 597);
            this.ProjectTab.TabIndex = 0;
            this.ProjectTab.Text = "Project";
            this.ProjectTab.UseVisualStyleBackColor = true;
            // 
            // KnowledgeTab
            // 
            this.KnowledgeTab.Controls.Add(this.KnowledgeBaseEditWidget);
            this.KnowledgeTab.Location = new System.Drawing.Point(4, 22);
            this.KnowledgeTab.Name = "KnowledgeTab";
            this.KnowledgeTab.Size = new System.Drawing.Size(955, 597);
            this.KnowledgeTab.TabIndex = 1;
            this.KnowledgeTab.Text = "Knowledge Base";
            this.KnowledgeTab.UseVisualStyleBackColor = true;
            // 
            // InputsTab
            // 
            this.InputsTab.Controls.Add(this.InputsEditWidget);
            this.InputsTab.Location = new System.Drawing.Point(4, 22);
            this.InputsTab.Name = "InputsTab";
            this.InputsTab.Size = new System.Drawing.Size(955, 597);
            this.InputsTab.TabIndex = 2;
            this.InputsTab.Text = "Inputs";
            this.InputsTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorsTab
            // 
            this.BehaviorsTab.Controls.Add(this.BehaviorTabs);
            this.BehaviorsTab.Controls.Add(this.CreateBehaviorButton);
            this.BehaviorsTab.Controls.Add(this.BehaviorsListView);
            this.BehaviorsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorsTab.Name = "BehaviorsTab";
            this.BehaviorsTab.Size = new System.Drawing.Size(955, 597);
            this.BehaviorsTab.TabIndex = 3;
            this.BehaviorsTab.Text = "Behaviors";
            this.BehaviorsTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorTabs
            // 
            this.BehaviorTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorTabs.Controls.Add(this.BehaviorOverviewTab);
            this.BehaviorTabs.Controls.Add(this.BehaviorConsiderationsTab);
            this.BehaviorTabs.Location = new System.Drawing.Point(253, 3);
            this.BehaviorTabs.Name = "BehaviorTabs";
            this.BehaviorTabs.SelectedIndex = 0;
            this.BehaviorTabs.Size = new System.Drawing.Size(699, 591);
            this.BehaviorTabs.TabIndex = 3;
            // 
            // BehaviorOverviewTab
            // 
            this.BehaviorOverviewTab.Controls.Add(this.BehaviorEditWidget);
            this.BehaviorOverviewTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorOverviewTab.Name = "BehaviorOverviewTab";
            this.BehaviorOverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.BehaviorOverviewTab.Size = new System.Drawing.Size(691, 565);
            this.BehaviorOverviewTab.TabIndex = 0;
            this.BehaviorOverviewTab.Text = "Scoring Overview";
            this.BehaviorOverviewTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorConsiderationsTab
            // 
            this.BehaviorConsiderationsTab.Controls.Add(this.ConsiderationEditWidget);
            this.BehaviorConsiderationsTab.Controls.Add(this.AddConsiderationButton);
            this.BehaviorConsiderationsTab.Controls.Add(this.ConsiderationsListView);
            this.BehaviorConsiderationsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorConsiderationsTab.Name = "BehaviorConsiderationsTab";
            this.BehaviorConsiderationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BehaviorConsiderationsTab.Size = new System.Drawing.Size(691, 565);
            this.BehaviorConsiderationsTab.TabIndex = 1;
            this.BehaviorConsiderationsTab.Text = "Edit Considerations";
            this.BehaviorConsiderationsTab.UseVisualStyleBackColor = true;
            // 
            // AddConsiderationButton
            // 
            this.AddConsiderationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddConsiderationButton.Location = new System.Drawing.Point(3, 534);
            this.AddConsiderationButton.Name = "AddConsiderationButton";
            this.AddConsiderationButton.Size = new System.Drawing.Size(72, 25);
            this.AddConsiderationButton.TabIndex = 1;
            this.AddConsiderationButton.Text = "Add...";
            this.AddConsiderationButton.UseVisualStyleBackColor = true;
            this.AddConsiderationButton.Click += new System.EventHandler(this.AddConsiderationButton_Click);
            // 
            // ConsiderationsListView
            // 
            this.ConsiderationsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsiderationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConsiderationNameHeader});
            this.ConsiderationsListView.FullRowSelect = true;
            this.ConsiderationsListView.HideSelection = false;
            this.ConsiderationsListView.Location = new System.Drawing.Point(3, 6);
            this.ConsiderationsListView.Name = "ConsiderationsListView";
            this.ConsiderationsListView.Size = new System.Drawing.Size(164, 524);
            this.ConsiderationsListView.TabIndex = 0;
            this.ConsiderationsListView.UseCompatibleStateImageBehavior = false;
            this.ConsiderationsListView.View = System.Windows.Forms.View.Details;
            this.ConsiderationsListView.SelectedIndexChanged += new System.EventHandler(this.ConsiderationsListView_SelectedIndexChanged);
            // 
            // ConsiderationNameHeader
            // 
            this.ConsiderationNameHeader.Text = "Consideration Name";
            this.ConsiderationNameHeader.Width = 150;
            // 
            // CreateBehaviorButton
            // 
            this.CreateBehaviorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateBehaviorButton.Location = new System.Drawing.Point(3, 571);
            this.CreateBehaviorButton.Name = "CreateBehaviorButton";
            this.CreateBehaviorButton.Size = new System.Drawing.Size(244, 23);
            this.CreateBehaviorButton.TabIndex = 1;
            this.CreateBehaviorButton.Text = "Add New Behavior";
            this.CreateBehaviorButton.UseVisualStyleBackColor = true;
            this.CreateBehaviorButton.Click += new System.EventHandler(this.CreateBehaviorButton_Click);
            // 
            // BehaviorsListView
            // 
            this.BehaviorsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BehaviorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BehaviorNameColumn});
            this.BehaviorsListView.FullRowSelect = true;
            this.BehaviorsListView.HideSelection = false;
            this.BehaviorsListView.Location = new System.Drawing.Point(3, 3);
            this.BehaviorsListView.Name = "BehaviorsListView";
            this.BehaviorsListView.Size = new System.Drawing.Size(244, 564);
            this.BehaviorsListView.TabIndex = 0;
            this.BehaviorsListView.UseCompatibleStateImageBehavior = false;
            this.BehaviorsListView.View = System.Windows.Forms.View.Details;
            this.BehaviorsListView.SelectedIndexChanged += new System.EventHandler(this.BehaviorsListView_SelectedIndexChanged);
            // 
            // BehaviorNameColumn
            // 
            this.BehaviorNameColumn.Text = "Behavior Name";
            this.BehaviorNameColumn.Width = 200;
            // 
            // BehaviorSetsTab
            // 
            this.BehaviorSetsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorSetsTab.Name = "BehaviorSetsTab";
            this.BehaviorSetsTab.Size = new System.Drawing.Size(955, 597);
            this.BehaviorSetsTab.TabIndex = 4;
            this.BehaviorSetsTab.Text = "Behavior Sets";
            this.BehaviorSetsTab.UseVisualStyleBackColor = true;
            // 
            // ArchetypesTab
            // 
            this.ArchetypesTab.Location = new System.Drawing.Point(4, 22);
            this.ArchetypesTab.Name = "ArchetypesTab";
            this.ArchetypesTab.Size = new System.Drawing.Size(955, 597);
            this.ArchetypesTab.TabIndex = 5;
            this.ArchetypesTab.Text = "Archetypes";
            this.ArchetypesTab.UseVisualStyleBackColor = true;
            // 
            // ScenariosTab
            // 
            this.ScenariosTab.Controls.Add(this.CreateScenarioButton);
            this.ScenariosTab.Controls.Add(this.ScenarioPanel);
            this.ScenariosTab.Location = new System.Drawing.Point(4, 22);
            this.ScenariosTab.Name = "ScenariosTab";
            this.ScenariosTab.Size = new System.Drawing.Size(955, 597);
            this.ScenariosTab.TabIndex = 6;
            this.ScenariosTab.Text = "Scenarios";
            this.ScenariosTab.UseVisualStyleBackColor = true;
            // 
            // ScenarioPanel
            // 
            this.ScenarioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioPanel.Location = new System.Drawing.Point(300, 3);
            this.ScenarioPanel.Name = "ScenarioPanel";
            this.ScenarioPanel.Size = new System.Drawing.Size(652, 591);
            this.ScenarioPanel.TabIndex = 0;
            // 
            // CreateScenarioButton
            // 
            this.CreateScenarioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateScenarioButton.Location = new System.Drawing.Point(3, 560);
            this.CreateScenarioButton.Name = "CreateScenarioButton";
            this.CreateScenarioButton.Size = new System.Drawing.Size(155, 34);
            this.CreateScenarioButton.TabIndex = 1;
            this.CreateScenarioButton.Text = "New Scenario";
            this.CreateScenarioButton.UseVisualStyleBackColor = true;
            this.CreateScenarioButton.Click += new System.EventHandler(this.CreateScenarioButton_Click);
            // 
            // ProjectEditWidget
            // 
            this.ProjectEditWidget.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectEditWidget.Location = new System.Drawing.Point(3, 3);
            this.ProjectEditWidget.Name = "ProjectEditWidget";
            this.ProjectEditWidget.Size = new System.Drawing.Size(949, 591);
            this.ProjectEditWidget.TabIndex = 0;
            // 
            // KnowledgeBaseEditWidget
            // 
            this.KnowledgeBaseEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KnowledgeBaseEditWidget.Location = new System.Drawing.Point(0, 0);
            this.KnowledgeBaseEditWidget.Name = "KnowledgeBaseEditWidget";
            this.KnowledgeBaseEditWidget.Size = new System.Drawing.Size(955, 597);
            this.KnowledgeBaseEditWidget.TabIndex = 0;
            // 
            // InputsEditWidget
            // 
            this.InputsEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputsEditWidget.Location = new System.Drawing.Point(0, 0);
            this.InputsEditWidget.Name = "InputsEditWidget";
            this.InputsEditWidget.Size = new System.Drawing.Size(955, 597);
            this.InputsEditWidget.TabIndex = 0;
            // 
            // BehaviorEditWidget
            // 
            this.BehaviorEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorEditWidget.Location = new System.Drawing.Point(6, 6);
            this.BehaviorEditWidget.Name = "BehaviorEditWidget";
            this.BehaviorEditWidget.Size = new System.Drawing.Size(679, 553);
            this.BehaviorEditWidget.TabIndex = 3;
            this.BehaviorEditWidget.Visible = false;
            // 
            // ConsiderationEditWidget
            // 
            this.ConsiderationEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsiderationEditWidget.Location = new System.Drawing.Point(173, 6);
            this.ConsiderationEditWidget.Name = "ConsiderationEditWidget";
            this.ConsiderationEditWidget.Size = new System.Drawing.Size(512, 559);
            this.ConsiderationEditWidget.TabIndex = 2;
            this.ConsiderationEditWidget.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 662);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.PrimaryMenuStrip);
            this.MainMenuStrip = this.PrimaryMenuStrip;
            this.Name = "MainForm";
            this.Text = "Curvature Studio";
            this.PrimaryMenuStrip.ResumeLayout(false);
            this.PrimaryMenuStrip.PerformLayout();
            this.MainTabs.ResumeLayout(false);
            this.ProjectTab.ResumeLayout(false);
            this.KnowledgeTab.ResumeLayout(false);
            this.InputsTab.ResumeLayout(false);
            this.BehaviorsTab.ResumeLayout(false);
            this.BehaviorTabs.ResumeLayout(false);
            this.BehaviorOverviewTab.ResumeLayout(false);
            this.BehaviorConsiderationsTab.ResumeLayout(false);
            this.ScenariosTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.OpenFileDialog OpenFileDialogBox;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage ProjectTab;
        private System.Windows.Forms.TabPage KnowledgeTab;
        private System.Windows.Forms.TabPage InputsTab;
        private System.Windows.Forms.TabPage BehaviorsTab;
        private System.Windows.Forms.TabPage BehaviorSetsTab;
        private System.Windows.Forms.TabPage ArchetypesTab;
        private System.Windows.Forms.TabPage ScenariosTab;
        private EditWidgetProject ProjectEditWidget;
        private EditWidgetKnowledgeBase KnowledgeBaseEditWidget;
        private EditWidgetInputs InputsEditWidget;
        private System.Windows.Forms.ListView BehaviorsListView;
        private System.Windows.Forms.Button CreateBehaviorButton;
        private System.Windows.Forms.ColumnHeader BehaviorNameColumn;
        private System.Windows.Forms.TabControl BehaviorTabs;
        private System.Windows.Forms.TabPage BehaviorOverviewTab;
        private EditWidgetBehavior BehaviorEditWidget;
        private System.Windows.Forms.TabPage BehaviorConsiderationsTab;
        private System.Windows.Forms.ListView ConsiderationsListView;
        private System.Windows.Forms.ColumnHeader ConsiderationNameHeader;
        private System.Windows.Forms.Button AddConsiderationButton;
        private EditWidgetConsideration ConsiderationEditWidget;
        private System.Windows.Forms.Button CreateScenarioButton;
        private System.Windows.Forms.Panel ScenarioPanel;
    }
}

