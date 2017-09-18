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
            this.DeleteSelectedBehaviorsButton = new System.Windows.Forms.Button();
            this.BehaviorTabs = new System.Windows.Forms.TabControl();
            this.BehaviorOverviewTab = new System.Windows.Forms.TabPage();
            this.BehaviorConsiderationsTab = new System.Windows.Forms.TabPage();
            this.AddConsiderationButton = new System.Windows.Forms.Button();
            this.ConsiderationsListView = new System.Windows.Forms.ListView();
            this.ConsiderationNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BehaviorsListView = new System.Windows.Forms.ListView();
            this.BehaviorNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateBehaviorButton = new System.Windows.Forms.Button();
            this.BehaviorSetsTab = new System.Windows.Forms.TabPage();
            this.DeleteBehaviorSetButton = new System.Windows.Forms.Button();
            this.AddBehaviorSetButton = new System.Windows.Forms.Button();
            this.BehaviorSetsListView = new System.Windows.Forms.ListView();
            this.BehaviorSetNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArchetypesTab = new System.Windows.Forms.TabPage();
            this.DeleteArchetypesButton = new System.Windows.Forms.Button();
            this.AddArchetypeButton = new System.Windows.Forms.Button();
            this.ArchetypesListView = new System.Windows.Forms.ListView();
            this.ArchetypeNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScenariosTab = new System.Windows.Forms.TabPage();
            this.DeleteScenariosButton = new System.Windows.Forms.Button();
            this.ScenariosListView = new System.Windows.Forms.ListView();
            this.ScenarioNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateScenarioButton = new System.Windows.Forms.Button();
            this.ScenarioPanel = new System.Windows.Forms.Panel();
            this.ProjectEditWidget = new Curvature.EditWidgetProject();
            this.KnowledgeBaseEditWidget = new Curvature.EditWidgetKnowledgeBase();
            this.InputsEditWidget = new Curvature.EditWidgetInputs();
            this.BehaviorEditWidget = new Curvature.EditWidgetBehavior();
            this.ConsiderationEditWidget = new Curvature.EditWidgetConsideration();
            this.BehaviorSetEditWidget = new Curvature.EditWidgetBehaviorSet();
            this.ArchetypeEditWidget = new Curvature.EditWidgetArchetype();
            this.PrimaryMenuStrip.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.KnowledgeTab.SuspendLayout();
            this.InputsTab.SuspendLayout();
            this.BehaviorsTab.SuspendLayout();
            this.BehaviorTabs.SuspendLayout();
            this.BehaviorOverviewTab.SuspendLayout();
            this.BehaviorConsiderationsTab.SuspendLayout();
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
            this.BehaviorsTab.Controls.Add(this.DeleteSelectedBehaviorsButton);
            this.BehaviorsTab.Controls.Add(this.BehaviorTabs);
            this.BehaviorsTab.Controls.Add(this.BehaviorsListView);
            this.BehaviorsTab.Controls.Add(this.CreateBehaviorButton);
            this.BehaviorsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorsTab.Name = "BehaviorsTab";
            this.BehaviorsTab.Size = new System.Drawing.Size(955, 597);
            this.BehaviorsTab.TabIndex = 3;
            this.BehaviorsTab.Text = "Behaviors";
            this.BehaviorsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedBehaviorsButton
            // 
            this.DeleteSelectedBehaviorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelectedBehaviorsButton.Location = new System.Drawing.Point(3, 571);
            this.DeleteSelectedBehaviorsButton.Name = "DeleteSelectedBehaviorsButton";
            this.DeleteSelectedBehaviorsButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteSelectedBehaviorsButton.TabIndex = 4;
            this.DeleteSelectedBehaviorsButton.Text = "Delete Selection";
            this.DeleteSelectedBehaviorsButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedBehaviorsButton.Click += new System.EventHandler(this.DeleteSelectedBehaviorsButton_Click);
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
            this.BehaviorTabs.Visible = false;
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
            this.AddConsiderationButton.Location = new System.Drawing.Point(3, 1153);
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
            this.ConsiderationsListView.Size = new System.Drawing.Size(164, 1143);
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
            this.BehaviorsListView.Size = new System.Drawing.Size(244, 533);
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
            // CreateBehaviorButton
            // 
            this.CreateBehaviorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateBehaviorButton.Location = new System.Drawing.Point(3, 542);
            this.CreateBehaviorButton.Name = "CreateBehaviorButton";
            this.CreateBehaviorButton.Size = new System.Drawing.Size(244, 23);
            this.CreateBehaviorButton.TabIndex = 1;
            this.CreateBehaviorButton.Text = "Add New Behavior";
            this.CreateBehaviorButton.UseVisualStyleBackColor = true;
            this.CreateBehaviorButton.Click += new System.EventHandler(this.CreateBehaviorButton_Click);
            // 
            // BehaviorSetsTab
            // 
            this.BehaviorSetsTab.Controls.Add(this.DeleteBehaviorSetButton);
            this.BehaviorSetsTab.Controls.Add(this.AddBehaviorSetButton);
            this.BehaviorSetsTab.Controls.Add(this.BehaviorSetEditWidget);
            this.BehaviorSetsTab.Controls.Add(this.BehaviorSetsListView);
            this.BehaviorSetsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorSetsTab.Name = "BehaviorSetsTab";
            this.BehaviorSetsTab.Size = new System.Drawing.Size(955, 597);
            this.BehaviorSetsTab.TabIndex = 4;
            this.BehaviorSetsTab.Text = "Behavior Sets";
            this.BehaviorSetsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteBehaviorSetButton
            // 
            this.DeleteBehaviorSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteBehaviorSetButton.Location = new System.Drawing.Point(3, 571);
            this.DeleteBehaviorSetButton.Name = "DeleteBehaviorSetButton";
            this.DeleteBehaviorSetButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteBehaviorSetButton.TabIndex = 5;
            this.DeleteBehaviorSetButton.Text = "Delete Selection";
            this.DeleteBehaviorSetButton.UseVisualStyleBackColor = true;
            this.DeleteBehaviorSetButton.Click += new System.EventHandler(this.DeleteBehaviorSetButton_Click);
            // 
            // AddBehaviorSetButton
            // 
            this.AddBehaviorSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBehaviorSetButton.Location = new System.Drawing.Point(3, 542);
            this.AddBehaviorSetButton.Name = "AddBehaviorSetButton";
            this.AddBehaviorSetButton.Size = new System.Drawing.Size(244, 23);
            this.AddBehaviorSetButton.TabIndex = 2;
            this.AddBehaviorSetButton.Text = "Add Behavior Set";
            this.AddBehaviorSetButton.UseVisualStyleBackColor = true;
            this.AddBehaviorSetButton.Click += new System.EventHandler(this.AddBehaviorSetButton_Click);
            // 
            // BehaviorSetsListView
            // 
            this.BehaviorSetsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BehaviorSetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BehaviorSetNameColumn});
            this.BehaviorSetsListView.FullRowSelect = true;
            this.BehaviorSetsListView.Location = new System.Drawing.Point(3, 3);
            this.BehaviorSetsListView.Name = "BehaviorSetsListView";
            this.BehaviorSetsListView.Size = new System.Drawing.Size(244, 533);
            this.BehaviorSetsListView.TabIndex = 0;
            this.BehaviorSetsListView.UseCompatibleStateImageBehavior = false;
            this.BehaviorSetsListView.View = System.Windows.Forms.View.Details;
            this.BehaviorSetsListView.SelectedIndexChanged += new System.EventHandler(this.BehaviorSetsListView_SelectedIndexChanged);
            // 
            // BehaviorSetNameColumn
            // 
            this.BehaviorSetNameColumn.Text = "Behavior Set Name";
            this.BehaviorSetNameColumn.Width = 220;
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
            this.DeleteArchetypesButton.Location = new System.Drawing.Point(3, 571);
            this.DeleteArchetypesButton.Name = "DeleteArchetypesButton";
            this.DeleteArchetypesButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteArchetypesButton.TabIndex = 5;
            this.DeleteArchetypesButton.Text = "Delete Selection";
            this.DeleteArchetypesButton.UseVisualStyleBackColor = true;
            this.DeleteArchetypesButton.Click += new System.EventHandler(this.DeleteArchetypesButton_Click);
            // 
            // AddArchetypeButton
            // 
            this.AddArchetypeButton.Location = new System.Drawing.Point(3, 542);
            this.AddArchetypeButton.Name = "AddArchetypeButton";
            this.AddArchetypeButton.Size = new System.Drawing.Size(244, 23);
            this.AddArchetypeButton.TabIndex = 1;
            this.AddArchetypeButton.Text = "Add Archetype";
            this.AddArchetypeButton.UseVisualStyleBackColor = true;
            this.AddArchetypeButton.Click += new System.EventHandler(this.AddArchetypeButton_Click);
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
            this.ArchetypesListView.SelectedIndexChanged += new System.EventHandler(this.ArchetypesListView_SelectedIndexChanged);
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
            this.DeleteScenariosButton.Location = new System.Drawing.Point(3, 571);
            this.DeleteScenariosButton.Name = "DeleteScenariosButton";
            this.DeleteScenariosButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteScenariosButton.TabIndex = 5;
            this.DeleteScenariosButton.Text = "Delete Selection";
            this.DeleteScenariosButton.UseVisualStyleBackColor = true;
            this.DeleteScenariosButton.Click += new System.EventHandler(this.DeleteScenariosButton_Click);
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
            this.ScenariosListView.Size = new System.Drawing.Size(244, 533);
            this.ScenariosListView.TabIndex = 2;
            this.ScenariosListView.UseCompatibleStateImageBehavior = false;
            this.ScenariosListView.View = System.Windows.Forms.View.Details;
            this.ScenariosListView.SelectedIndexChanged += new System.EventHandler(this.ScenariosListView_SelectedIndexChanged);
            // 
            // ScenarioNameColumn
            // 
            this.ScenarioNameColumn.Text = "Scenario Name";
            this.ScenarioNameColumn.Width = 220;
            // 
            // CreateScenarioButton
            // 
            this.CreateScenarioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateScenarioButton.Location = new System.Drawing.Point(3, 542);
            this.CreateScenarioButton.Name = "CreateScenarioButton";
            this.CreateScenarioButton.Size = new System.Drawing.Size(244, 23);
            this.CreateScenarioButton.TabIndex = 1;
            this.CreateScenarioButton.Text = "New Scenario";
            this.CreateScenarioButton.UseVisualStyleBackColor = true;
            this.CreateScenarioButton.Click += new System.EventHandler(this.CreateScenarioButton_Click);
            // 
            // ScenarioPanel
            // 
            this.ScenarioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioPanel.Location = new System.Drawing.Point(253, 3);
            this.ScenarioPanel.Name = "ScenarioPanel";
            this.ScenarioPanel.Size = new System.Drawing.Size(699, 591);
            this.ScenarioPanel.TabIndex = 0;
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
            this.BehaviorEditWidget.Size = new System.Drawing.Size(691, 553);
            this.BehaviorEditWidget.TabIndex = 3;
            // 
            // ConsiderationEditWidget
            // 
            this.ConsiderationEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsiderationEditWidget.Location = new System.Drawing.Point(173, 6);
            this.ConsiderationEditWidget.Name = "ConsiderationEditWidget";
            this.ConsiderationEditWidget.Size = new System.Drawing.Size(1779, 1178);
            this.ConsiderationEditWidget.TabIndex = 2;
            this.ConsiderationEditWidget.Visible = false;
            // 
            // BehaviorSetEditWidget
            // 
            this.BehaviorSetEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorSetEditWidget.Location = new System.Drawing.Point(253, 3);
            this.BehaviorSetEditWidget.Name = "BehaviorSetEditWidget";
            this.BehaviorSetEditWidget.Size = new System.Drawing.Size(699, 591);
            this.BehaviorSetEditWidget.TabIndex = 1;
            this.BehaviorSetEditWidget.Visible = false;
            // 
            // ArchetypeEditWidget
            // 
            this.ArchetypeEditWidget.Location = new System.Drawing.Point(253, 3);
            this.ArchetypeEditWidget.Name = "ArchetypeEditWidget";
            this.ArchetypeEditWidget.Size = new System.Drawing.Size(699, 594);
            this.ArchetypeEditWidget.TabIndex = 2;
            this.ArchetypeEditWidget.Visible = false;
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
        private System.Windows.Forms.ListView BehaviorSetsListView;
        private System.Windows.Forms.ColumnHeader BehaviorSetNameColumn;
        private EditWidgetBehaviorSet BehaviorSetEditWidget;
        private System.Windows.Forms.ListView ArchetypesListView;
        private System.Windows.Forms.ColumnHeader ArchetypeNameColumn;
        private System.Windows.Forms.Button AddArchetypeButton;
        private System.Windows.Forms.ListView ScenariosListView;
        private System.Windows.Forms.ColumnHeader ScenarioNameColumn;
        private EditWidgetArchetype ArchetypeEditWidget;
        private System.Windows.Forms.Button AddBehaviorSetButton;
        private System.Windows.Forms.Button DeleteSelectedBehaviorsButton;
        private System.Windows.Forms.Button DeleteBehaviorSetButton;
        private System.Windows.Forms.Button DeleteArchetypesButton;
        private System.Windows.Forms.Button DeleteScenariosButton;
    }
}

