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
            this.ProjectEditWidget = new Curvature.EditWidgetProject();
            this.KnowledgeTab = new System.Windows.Forms.TabPage();
            this.KnowledgeBaseEditWidget = new Curvature.EditWidgetKnowledgeBase();
            this.InputsTab = new System.Windows.Forms.TabPage();
            this.InputsEditWidget = new Curvature.EditWidgetInputs();
            this.BehaviorsTab = new System.Windows.Forms.TabPage();
            this.BehaviorsEditWidget = new Curvature.Widgets.EditWidgetBehaviors();
            this.BehaviorSetsTab = new System.Windows.Forms.TabPage();
            this.BehaviorSetsEditWidget = new Curvature.Widgets.EditWidgetBehaviorSets();
            this.ArchetypesTab = new System.Windows.Forms.TabPage();
            this.DeleteArchetypesButton = new System.Windows.Forms.Button();
            this.AddArchetypeButton = new System.Windows.Forms.Button();
            this.ArchetypeEditWidget = new Curvature.EditWidgetArchetype();
            this.ArchetypesListView = new System.Windows.Forms.ListView();
            this.ArchetypeNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScenariosTab = new System.Windows.Forms.TabPage();
            this.DeleteScenariosButton = new System.Windows.Forms.Button();
            this.ScenariosListView = new System.Windows.Forms.ListView();
            this.ScenarioNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateScenarioButton = new System.Windows.Forms.Button();
            this.ScenarioPanel = new System.Windows.Forms.Panel();
            this.PrimaryMenuStrip.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.KnowledgeTab.SuspendLayout();
            this.InputsTab.SuspendLayout();
            this.BehaviorsTab.SuspendLayout();
            this.BehaviorSetsTab.SuspendLayout();
            this.ArchetypesTab.SuspendLayout();
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
            this.MainTabs.TabIndex = 5;
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
            // ProjectEditWidget
            // 
            this.ProjectEditWidget.BackColor = System.Drawing.SystemColors.Window;
            this.ProjectEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectEditWidget.Location = new System.Drawing.Point(3, 3);
            this.ProjectEditWidget.Name = "ProjectEditWidget";
            this.ProjectEditWidget.Size = new System.Drawing.Size(949, 591);
            this.ProjectEditWidget.TabIndex = 0;
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
            // KnowledgeBaseEditWidget
            // 
            this.KnowledgeBaseEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KnowledgeBaseEditWidget.Location = new System.Drawing.Point(0, 0);
            this.KnowledgeBaseEditWidget.Name = "KnowledgeBaseEditWidget";
            this.KnowledgeBaseEditWidget.Size = new System.Drawing.Size(955, 597);
            this.KnowledgeBaseEditWidget.TabIndex = 0;
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
            // InputsEditWidget
            // 
            this.InputsEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputsEditWidget.Location = new System.Drawing.Point(0, 0);
            this.InputsEditWidget.Name = "InputsEditWidget";
            this.InputsEditWidget.Size = new System.Drawing.Size(955, 597);
            this.InputsEditWidget.TabIndex = 0;
            // 
            // BehaviorsTab
            // 
            this.BehaviorsTab.Controls.Add(this.BehaviorsEditWidget);
            this.BehaviorsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorsTab.Name = "BehaviorsTab";
            this.BehaviorsTab.Size = new System.Drawing.Size(955, 597);
            this.BehaviorsTab.TabIndex = 3;
            this.BehaviorsTab.Text = "Behaviors";
            this.BehaviorsTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorsEditWidget
            // 
            this.BehaviorsEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BehaviorsEditWidget.Location = new System.Drawing.Point(0, 0);
            this.BehaviorsEditWidget.Name = "BehaviorsEditWidget";
            this.BehaviorsEditWidget.Size = new System.Drawing.Size(955, 597);
            this.BehaviorsEditWidget.TabIndex = 0;
            // 
            // BehaviorSetsTab
            // 
            this.BehaviorSetsTab.Controls.Add(this.BehaviorSetsEditWidget);
            this.BehaviorSetsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorSetsTab.Name = "BehaviorSetsTab";
            this.BehaviorSetsTab.Size = new System.Drawing.Size(955, 597);
            this.BehaviorSetsTab.TabIndex = 4;
            this.BehaviorSetsTab.Text = "Behavior Sets";
            this.BehaviorSetsTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorSetsEditWidget
            // 
            this.BehaviorSetsEditWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BehaviorSetsEditWidget.Location = new System.Drawing.Point(0, 0);
            this.BehaviorSetsEditWidget.Name = "BehaviorSetsEditWidget";
            this.BehaviorSetsEditWidget.Size = new System.Drawing.Size(955, 597);
            this.BehaviorSetsEditWidget.TabIndex = 0;
            // 
            // ArchetypesTab
            // 
            this.ArchetypesTab.Controls.Add(this.DeleteArchetypesButton);
            this.ArchetypesTab.Controls.Add(this.AddArchetypeButton);
            this.ArchetypesTab.Controls.Add(this.ArchetypeEditWidget);
            this.ArchetypesTab.Controls.Add(this.ArchetypesListView);
            this.ArchetypesTab.Location = new System.Drawing.Point(4, 22);
            this.ArchetypesTab.Name = "ArchetypesTab";
            this.ArchetypesTab.Size = new System.Drawing.Size(955, 597);
            this.ArchetypesTab.TabIndex = 5;
            this.ArchetypesTab.Text = "Archetypes";
            this.ArchetypesTab.UseVisualStyleBackColor = true;
            // 
            // DeleteArchetypesButton
            // 
            this.DeleteArchetypesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteArchetypesButton.Location = new System.Drawing.Point(3, 48);
            this.DeleteArchetypesButton.Name = "DeleteArchetypesButton";
            this.DeleteArchetypesButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteArchetypesButton.TabIndex = 5;
            this.DeleteArchetypesButton.Text = "Delete Selection";
            this.DeleteArchetypesButton.UseVisualStyleBackColor = true;
            // 
            // AddArchetypeButton
            // 
            this.AddArchetypeButton.Location = new System.Drawing.Point(3, 542);
            this.AddArchetypeButton.Name = "AddArchetypeButton";
            this.AddArchetypeButton.Size = new System.Drawing.Size(244, 23);
            this.AddArchetypeButton.TabIndex = 1;
            this.AddArchetypeButton.Text = "Add Archetype";
            this.AddArchetypeButton.UseVisualStyleBackColor = true;
            // 
            // ArchetypeEditWidget
            // 
            this.ArchetypeEditWidget.Location = new System.Drawing.Point(253, 3);
            this.ArchetypeEditWidget.Name = "ArchetypeEditWidget";
            this.ArchetypeEditWidget.Size = new System.Drawing.Size(699, 594);
            this.ArchetypeEditWidget.TabIndex = 2;
            this.ArchetypeEditWidget.Visible = false;
            // 
            // ArchetypesListView
            // 
            this.ArchetypesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArchetypeNameColumn});
            this.ArchetypesListView.FullRowSelect = true;
            this.ArchetypesListView.HideSelection = false;
            this.ArchetypesListView.Location = new System.Drawing.Point(3, 3);
            this.ArchetypesListView.Name = "ArchetypesListView";
            this.ArchetypesListView.Size = new System.Drawing.Size(244, 533);
            this.ArchetypesListView.TabIndex = 0;
            this.ArchetypesListView.UseCompatibleStateImageBehavior = false;
            this.ArchetypesListView.View = System.Windows.Forms.View.Details;
            // 
            // ArchetypeNameColumn
            // 
            this.ArchetypeNameColumn.Text = "Archetype Name";
            this.ArchetypeNameColumn.Width = 220;
            // 
            // ScenariosTab
            // 
            this.ScenariosTab.Controls.Add(this.DeleteScenariosButton);
            this.ScenariosTab.Controls.Add(this.ScenariosListView);
            this.ScenariosTab.Controls.Add(this.CreateScenarioButton);
            this.ScenariosTab.Controls.Add(this.ScenarioPanel);
            this.ScenariosTab.Location = new System.Drawing.Point(4, 22);
            this.ScenariosTab.Name = "ScenariosTab";
            this.ScenariosTab.Size = new System.Drawing.Size(955, 597);
            this.ScenariosTab.TabIndex = 6;
            this.ScenariosTab.Text = "Scenarios";
            this.ScenariosTab.UseVisualStyleBackColor = true;
            // 
            // DeleteScenariosButton
            // 
            this.DeleteScenariosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteScenariosButton.Location = new System.Drawing.Point(3, 48);
            this.DeleteScenariosButton.Name = "DeleteScenariosButton";
            this.DeleteScenariosButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteScenariosButton.TabIndex = 5;
            this.DeleteScenariosButton.Text = "Delete Selection";
            this.DeleteScenariosButton.UseVisualStyleBackColor = true;
            // 
            // ScenariosListView
            // 
            this.ScenariosListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScenariosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScenarioNameColumn});
            this.ScenariosListView.FullRowSelect = true;
            this.ScenariosListView.HideSelection = false;
            this.ScenariosListView.Location = new System.Drawing.Point(3, 3);
            this.ScenariosListView.Name = "ScenariosListView";
            this.ScenariosListView.Size = new System.Drawing.Size(244, 10);
            this.ScenariosListView.TabIndex = 2;
            this.ScenariosListView.UseCompatibleStateImageBehavior = false;
            this.ScenariosListView.View = System.Windows.Forms.View.Details;
            // 
            // ScenarioNameColumn
            // 
            this.ScenarioNameColumn.Text = "Scenario Name";
            this.ScenarioNameColumn.Width = 220;
            // 
            // CreateScenarioButton
            // 
            this.CreateScenarioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateScenarioButton.Location = new System.Drawing.Point(3, 19);
            this.CreateScenarioButton.Name = "CreateScenarioButton";
            this.CreateScenarioButton.Size = new System.Drawing.Size(244, 23);
            this.CreateScenarioButton.TabIndex = 1;
            this.CreateScenarioButton.Text = "New Scenario";
            this.CreateScenarioButton.UseVisualStyleBackColor = true;
            // 
            // ScenarioPanel
            // 
            this.ScenarioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioPanel.Location = new System.Drawing.Point(253, 3);
            this.ScenarioPanel.Name = "ScenarioPanel";
            this.ScenarioPanel.Size = new System.Drawing.Size(0, 68);
            this.ScenarioPanel.TabIndex = 0;
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
            this.BehaviorSetsTab.ResumeLayout(false);
            this.ArchetypesTab.ResumeLayout(false);
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
        private EditWidgetProject ProjectEditWidget;
        private System.Windows.Forms.TabPage KnowledgeTab;
        private EditWidgetKnowledgeBase KnowledgeBaseEditWidget;
        private System.Windows.Forms.TabPage InputsTab;
        private EditWidgetInputs InputsEditWidget;
        private System.Windows.Forms.TabPage BehaviorsTab;
        private System.Windows.Forms.TabPage BehaviorSetsTab;
        private System.Windows.Forms.TabPage ArchetypesTab;
        private System.Windows.Forms.Button DeleteArchetypesButton;
        private System.Windows.Forms.Button AddArchetypeButton;
        private EditWidgetArchetype ArchetypeEditWidget;
        private System.Windows.Forms.ListView ArchetypesListView;
        private System.Windows.Forms.ColumnHeader ArchetypeNameColumn;
        private System.Windows.Forms.TabPage ScenariosTab;
        private System.Windows.Forms.Button DeleteScenariosButton;
        private System.Windows.Forms.ListView ScenariosListView;
        private System.Windows.Forms.ColumnHeader ScenarioNameColumn;
        private System.Windows.Forms.Button CreateScenarioButton;
        private System.Windows.Forms.Panel ScenarioPanel;
        private Widgets.EditWidgetBehaviors BehaviorsEditWidget;
        private Widgets.EditWidgetBehaviorSets BehaviorSetsEditWidget;
    }
}

