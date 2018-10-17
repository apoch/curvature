namespace Curvature
{
    partial class EditWidgetScenario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetScenario));
            this.ScenarioEditorTabs = new System.Windows.Forms.TabControl();
            this.AgentsTab = new System.Windows.Forms.TabPage();
            this.AgentRandomStartPositionCheckBox = new System.Windows.Forms.CheckBox();
            this.AgentStartLocationCombo = new System.Windows.Forms.ComboBox();
            this.AgentStartLocationLabel = new System.Windows.Forms.Label();
            this.ColorSwatch = new System.Windows.Forms.PictureBox();
            this.DeleteSelectedAgentsButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.AgentProperties = new System.Windows.Forms.PropertyGrid();
            this.CopyCurrentAgentPositionButton = new System.Windows.Forms.Button();
            this.AgentResetButton = new System.Windows.Forms.Button();
            this.AgentStartYLabel = new System.Windows.Forms.Label();
            this.AgentStartYUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentStartXLabel = new System.Windows.Forms.Label();
            this.AgentStartXUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentArchetypeLabel = new System.Windows.Forms.Label();
            this.AgentArchetypeComboBox = new System.Windows.Forms.ComboBox();
            this.AgentRadiusLabel = new System.Windows.Forms.Label();
            this.AgentRadiusUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentYLabel = new System.Windows.Forms.Label();
            this.AgentYUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentXUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentXLabel = new System.Windows.Forms.Label();
            this.AddAgentButton = new System.Windows.Forms.Button();
            this.AgentsListView = new System.Windows.Forms.ListView();
            this.ScenarioAgentNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScenarioAgentPositionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScenarioAgentArchetypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationsTab = new System.Windows.Forms.TabPage();
            this.DeleteLocationButton = new System.Windows.Forms.Button();
            this.LocationPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.LocationRadius = new System.Windows.Forms.NumericUpDown();
            this.LocationRadiusLabel = new System.Windows.Forms.Label();
            this.LocationCenterY = new System.Windows.Forms.NumericUpDown();
            this.LocationCenterYLabel = new System.Windows.Forms.Label();
            this.LocationCenterX = new System.Windows.Forms.NumericUpDown();
            this.LocationCenterXLabel = new System.Windows.Forms.Label();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.LocationsListView = new System.Windows.Forms.ListView();
            this.LocationNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationCoordinatesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SimulationTab = new System.Windows.Forms.TabPage();
            this.RandomSeedCombo = new System.Windows.Forms.ComboBox();
            this.RandomSeedLabel = new System.Windows.Forms.Label();
            this.ResetSimulationButton = new System.Windows.Forms.Button();
            this.AutoAdvanceButton = new System.Windows.Forms.Button();
            this.Advance100msButton = new System.Windows.Forms.Button();
            this.ScenarioRenderingBox = new System.Windows.Forms.PictureBox();
            this.LogsTab = new System.Windows.Forms.TabPage();
            this.LogDetailTextBox = new System.Windows.Forms.TextBox();
            this.LogsTreeView = new System.Windows.Forms.TreeView();
            this.AutoAdvanceTimer = new System.Windows.Forms.Timer(this.components);
            this.SimulationInspectionTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.ScenariosToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameEditWidget = new Curvature.EditWidgetName();
            this.ScenarioEditorTabs.SuspendLayout();
            this.AgentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSwatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentRadiusUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentXUpDown)).BeginInit();
            this.LocationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationCenterY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationCenterX)).BeginInit();
            this.SimulationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioRenderingBox)).BeginInit();
            this.LogsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScenarioEditorTabs
            // 
            this.ScenarioEditorTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ScenarioEditorTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioEditorTabs.Controls.Add(this.AgentsTab);
            this.ScenarioEditorTabs.Controls.Add(this.LocationsTab);
            this.ScenarioEditorTabs.Controls.Add(this.SimulationTab);
            this.ScenarioEditorTabs.Controls.Add(this.LogsTab);
            this.ScenarioEditorTabs.Location = new System.Drawing.Point(3, 36);
            this.ScenarioEditorTabs.Name = "ScenarioEditorTabs";
            this.ScenarioEditorTabs.SelectedIndex = 0;
            this.ScenarioEditorTabs.Size = new System.Drawing.Size(746, 456);
            this.ScenarioEditorTabs.TabIndex = 1;
            // 
            // AgentsTab
            // 
            this.AgentsTab.Controls.Add(this.AgentRandomStartPositionCheckBox);
            this.AgentsTab.Controls.Add(this.AgentStartLocationCombo);
            this.AgentsTab.Controls.Add(this.AgentStartLocationLabel);
            this.AgentsTab.Controls.Add(this.ColorSwatch);
            this.AgentsTab.Controls.Add(this.DeleteSelectedAgentsButton);
            this.AgentsTab.Controls.Add(this.AgentProperties);
            this.AgentsTab.Controls.Add(this.CopyCurrentAgentPositionButton);
            this.AgentsTab.Controls.Add(this.AgentResetButton);
            this.AgentsTab.Controls.Add(this.AgentStartYLabel);
            this.AgentsTab.Controls.Add(this.AgentStartYUpDown);
            this.AgentsTab.Controls.Add(this.AgentStartXLabel);
            this.AgentsTab.Controls.Add(this.AgentStartXUpDown);
            this.AgentsTab.Controls.Add(this.AgentArchetypeLabel);
            this.AgentsTab.Controls.Add(this.AgentArchetypeComboBox);
            this.AgentsTab.Controls.Add(this.AgentRadiusLabel);
            this.AgentsTab.Controls.Add(this.AgentRadiusUpDown);
            this.AgentsTab.Controls.Add(this.AgentYLabel);
            this.AgentsTab.Controls.Add(this.AgentYUpDown);
            this.AgentsTab.Controls.Add(this.AgentXUpDown);
            this.AgentsTab.Controls.Add(this.AgentXLabel);
            this.AgentsTab.Controls.Add(this.AddAgentButton);
            this.AgentsTab.Controls.Add(this.AgentsListView);
            this.AgentsTab.Location = new System.Drawing.Point(4, 4);
            this.AgentsTab.Name = "AgentsTab";
            this.AgentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AgentsTab.Size = new System.Drawing.Size(738, 430);
            this.AgentsTab.TabIndex = 0;
            this.AgentsTab.Text = "Agents";
            this.AgentsTab.UseVisualStyleBackColor = true;
            // 
            // AgentRandomStartPositionCheckBox
            // 
            this.AgentRandomStartPositionCheckBox.AutoSize = true;
            this.AgentRandomStartPositionCheckBox.Location = new System.Drawing.Point(229, 283);
            this.AgentRandomStartPositionCheckBox.Name = "AgentRandomStartPositionCheckBox";
            this.AgentRandomStartPositionCheckBox.Size = new System.Drawing.Size(70, 17);
            this.AgentRandomStartPositionCheckBox.TabIndex = 9;
            this.AgentRandomStartPositionCheckBox.Text = "Add Fuzz";
            this.ScenariosToolTip.SetToolTip(this.AgentRandomStartPositionCheckBox, resources.GetString("AgentRandomStartPositionCheckBox.ToolTip"));
            this.AgentRandomStartPositionCheckBox.UseVisualStyleBackColor = true;
            this.AgentRandomStartPositionCheckBox.CheckedChanged += new System.EventHandler(this.AgentRandomStartPositionCheckBox_CheckedChanged);
            // 
            // AgentStartLocationCombo
            // 
            this.AgentStartLocationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentStartLocationCombo.FormattingEnabled = true;
            this.AgentStartLocationCombo.Location = new System.Drawing.Point(6, 281);
            this.AgentStartLocationCombo.Name = "AgentStartLocationCombo";
            this.AgentStartLocationCombo.Size = new System.Drawing.Size(217, 21);
            this.AgentStartLocationCombo.TabIndex = 8;
            this.AgentStartLocationCombo.SelectedIndexChanged += new System.EventHandler(this.AgentStartLocationCombo_SelectedIndexChanged);
            // 
            // AgentStartLocationLabel
            // 
            this.AgentStartLocationLabel.AutoSize = true;
            this.AgentStartLocationLabel.Location = new System.Drawing.Point(3, 265);
            this.AgentStartLocationLabel.Name = "AgentStartLocationLabel";
            this.AgentStartLocationLabel.Size = new System.Drawing.Size(76, 13);
            this.AgentStartLocationLabel.TabIndex = 7;
            this.AgentStartLocationLabel.Text = "Start Location:";
            // 
            // ColorSwatch
            // 
            this.ColorSwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorSwatch.Location = new System.Drawing.Point(290, 241);
            this.ColorSwatch.Name = "ColorSwatch";
            this.ColorSwatch.Size = new System.Drawing.Size(20, 20);
            this.ColorSwatch.TabIndex = 19;
            this.ColorSwatch.TabStop = false;
            this.ScenariosToolTip.SetToolTip(this.ColorSwatch, "Click to choose a color for this agent");
            this.ColorSwatch.Click += new System.EventHandler(this.ColorSwatch_Click);
            // 
            // DeleteSelectedAgentsButton
            // 
            this.DeleteSelectedAgentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedAgentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSelectedAgentsButton.ImageIndex = 1;
            this.DeleteSelectedAgentsButton.ImageList = this.IconImageList;
            this.DeleteSelectedAgentsButton.Location = new System.Drawing.Point(639, 33);
            this.DeleteSelectedAgentsButton.Name = "DeleteSelectedAgentsButton";
            this.DeleteSelectedAgentsButton.Size = new System.Drawing.Size(96, 27);
            this.DeleteSelectedAgentsButton.TabIndex = 2;
            this.DeleteSelectedAgentsButton.Text = "Delete";
            this.DeleteSelectedAgentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteSelectedAgentsButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedAgentsButton.Click += new System.EventHandler(this.DeleteSelectedAgentsButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            this.IconImageList.Images.SetKeyName(1, "DeleteItemIcon.png");
            // 
            // AgentProperties
            // 
            this.AgentProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentProperties.LineColor = System.Drawing.SystemColors.ControlDark;
            this.AgentProperties.Location = new System.Drawing.Point(316, 228);
            this.AgentProperties.Name = "AgentProperties";
            this.AgentProperties.Size = new System.Drawing.Size(317, 196);
            this.AgentProperties.TabIndex = 20;
            this.AgentProperties.ToolbarVisible = false;
            // 
            // CopyCurrentAgentPositionButton
            // 
            this.CopyCurrentAgentPositionButton.Location = new System.Drawing.Point(179, 328);
            this.CopyCurrentAgentPositionButton.Name = "CopyCurrentAgentPositionButton";
            this.CopyCurrentAgentPositionButton.Size = new System.Drawing.Size(131, 20);
            this.CopyCurrentAgentPositionButton.TabIndex = 14;
            this.CopyCurrentAgentPositionButton.Text = "Use Current Location";
            this.CopyCurrentAgentPositionButton.UseVisualStyleBackColor = true;
            this.CopyCurrentAgentPositionButton.Click += new System.EventHandler(this.CopyCurrentAgentPositionButton_Click);
            // 
            // AgentResetButton
            // 
            this.AgentResetButton.Location = new System.Drawing.Point(179, 376);
            this.AgentResetButton.Name = "AgentResetButton";
            this.AgentResetButton.Size = new System.Drawing.Size(131, 20);
            this.AgentResetButton.TabIndex = 19;
            this.AgentResetButton.Text = "Teleport Back to Start";
            this.AgentResetButton.UseVisualStyleBackColor = true;
            this.AgentResetButton.Click += new System.EventHandler(this.AgentResetButton_Click);
            // 
            // AgentStartYLabel
            // 
            this.AgentStartYLabel.AutoSize = true;
            this.AgentStartYLabel.Location = new System.Drawing.Point(89, 312);
            this.AgentStartYLabel.Name = "AgentStartYLabel";
            this.AgentStartYLabel.Size = new System.Drawing.Size(56, 13);
            this.AgentStartYLabel.TabIndex = 12;
            this.AgentStartYLabel.Text = "Starting Y:";
            // 
            // AgentStartYUpDown
            // 
            this.AgentStartYUpDown.DecimalPlaces = 3;
            this.AgentStartYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentStartYUpDown.Location = new System.Drawing.Point(92, 328);
            this.AgentStartYUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgentStartYUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AgentStartYUpDown.Name = "AgentStartYUpDown";
            this.AgentStartYUpDown.Size = new System.Drawing.Size(81, 20);
            this.AgentStartYUpDown.TabIndex = 13;
            this.AgentStartYUpDown.ValueChanged += new System.EventHandler(this.AgentStartYUpDown_ValueChanged);
            // 
            // AgentStartXLabel
            // 
            this.AgentStartXLabel.AutoSize = true;
            this.AgentStartXLabel.Location = new System.Drawing.Point(3, 312);
            this.AgentStartXLabel.Name = "AgentStartXLabel";
            this.AgentStartXLabel.Size = new System.Drawing.Size(56, 13);
            this.AgentStartXLabel.TabIndex = 10;
            this.AgentStartXLabel.Text = "Starting X:";
            // 
            // AgentStartXUpDown
            // 
            this.AgentStartXUpDown.DecimalPlaces = 3;
            this.AgentStartXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentStartXUpDown.Location = new System.Drawing.Point(6, 328);
            this.AgentStartXUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgentStartXUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AgentStartXUpDown.Name = "AgentStartXUpDown";
            this.AgentStartXUpDown.Size = new System.Drawing.Size(80, 20);
            this.AgentStartXUpDown.TabIndex = 11;
            this.AgentStartXUpDown.ValueChanged += new System.EventHandler(this.AgentStartXUpDown_ValueChanged);
            // 
            // AgentArchetypeLabel
            // 
            this.AgentArchetypeLabel.AutoSize = true;
            this.AgentArchetypeLabel.Location = new System.Drawing.Point(3, 225);
            this.AgentArchetypeLabel.Name = "AgentArchetypeLabel";
            this.AgentArchetypeLabel.Size = new System.Drawing.Size(58, 13);
            this.AgentArchetypeLabel.TabIndex = 3;
            this.AgentArchetypeLabel.Text = "Archetype:";
            // 
            // AgentArchetypeComboBox
            // 
            this.AgentArchetypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentArchetypeComboBox.FormattingEnabled = true;
            this.AgentArchetypeComboBox.Location = new System.Drawing.Point(6, 241);
            this.AgentArchetypeComboBox.Name = "AgentArchetypeComboBox";
            this.AgentArchetypeComboBox.Size = new System.Drawing.Size(217, 21);
            this.AgentArchetypeComboBox.TabIndex = 4;
            this.AgentArchetypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AgentArchetypeComboBox_SelectedIndexChanged);
            // 
            // AgentRadiusLabel
            // 
            this.AgentRadiusLabel.AutoSize = true;
            this.AgentRadiusLabel.Location = new System.Drawing.Point(226, 225);
            this.AgentRadiusLabel.Name = "AgentRadiusLabel";
            this.AgentRadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.AgentRadiusLabel.TabIndex = 5;
            this.AgentRadiusLabel.Text = "Radius:";
            // 
            // AgentRadiusUpDown
            // 
            this.AgentRadiusUpDown.DecimalPlaces = 2;
            this.AgentRadiusUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentRadiusUpDown.Location = new System.Drawing.Point(229, 241);
            this.AgentRadiusUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.AgentRadiusUpDown.Name = "AgentRadiusUpDown";
            this.AgentRadiusUpDown.Size = new System.Drawing.Size(55, 20);
            this.AgentRadiusUpDown.TabIndex = 6;
            this.AgentRadiusUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgentRadiusUpDown.ValueChanged += new System.EventHandler(this.AgentRadiusUpDown_ValueChanged);
            // 
            // AgentYLabel
            // 
            this.AgentYLabel.AutoSize = true;
            this.AgentYLabel.Location = new System.Drawing.Point(89, 360);
            this.AgentYLabel.Name = "AgentYLabel";
            this.AgentYLabel.Size = new System.Drawing.Size(54, 13);
            this.AgentYLabel.TabIndex = 17;
            this.AgentYLabel.Text = "Current Y:";
            // 
            // AgentYUpDown
            // 
            this.AgentYUpDown.DecimalPlaces = 3;
            this.AgentYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentYUpDown.Location = new System.Drawing.Point(92, 376);
            this.AgentYUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgentYUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AgentYUpDown.Name = "AgentYUpDown";
            this.AgentYUpDown.Size = new System.Drawing.Size(81, 20);
            this.AgentYUpDown.TabIndex = 18;
            this.AgentYUpDown.ValueChanged += new System.EventHandler(this.AgentYUpDown_ValueChanged);
            // 
            // AgentXUpDown
            // 
            this.AgentXUpDown.DecimalPlaces = 3;
            this.AgentXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentXUpDown.Location = new System.Drawing.Point(6, 376);
            this.AgentXUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgentXUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.AgentXUpDown.Name = "AgentXUpDown";
            this.AgentXUpDown.Size = new System.Drawing.Size(80, 20);
            this.AgentXUpDown.TabIndex = 16;
            this.AgentXUpDown.ValueChanged += new System.EventHandler(this.AgentXUpDown_ValueChanged);
            // 
            // AgentXLabel
            // 
            this.AgentXLabel.AutoSize = true;
            this.AgentXLabel.Location = new System.Drawing.Point(3, 360);
            this.AgentXLabel.Name = "AgentXLabel";
            this.AgentXLabel.Size = new System.Drawing.Size(54, 13);
            this.AgentXLabel.TabIndex = 15;
            this.AgentXLabel.Text = "Current X:";
            // 
            // AddAgentButton
            // 
            this.AddAgentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAgentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddAgentButton.ImageIndex = 0;
            this.AddAgentButton.ImageList = this.IconImageList;
            this.AddAgentButton.Location = new System.Drawing.Point(639, 0);
            this.AddAgentButton.Name = "AddAgentButton";
            this.AddAgentButton.Size = new System.Drawing.Size(96, 27);
            this.AddAgentButton.TabIndex = 1;
            this.AddAgentButton.Text = "Add Agent";
            this.AddAgentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddAgentButton.UseVisualStyleBackColor = true;
            this.AddAgentButton.Click += new System.EventHandler(this.AddAgentButton_Click);
            // 
            // AgentsListView
            // 
            this.AgentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScenarioAgentNameColumnHeader,
            this.ScenarioAgentPositionColumnHeader,
            this.ScenarioAgentArchetypeColumnHeader});
            this.AgentsListView.FullRowSelect = true;
            this.AgentsListView.HideSelection = false;
            this.AgentsListView.LabelEdit = true;
            this.AgentsListView.Location = new System.Drawing.Point(0, 0);
            this.AgentsListView.MultiSelect = false;
            this.AgentsListView.Name = "AgentsListView";
            this.AgentsListView.Size = new System.Drawing.Size(633, 222);
            this.AgentsListView.TabIndex = 0;
            this.AgentsListView.UseCompatibleStateImageBehavior = false;
            this.AgentsListView.View = System.Windows.Forms.View.Details;
            this.AgentsListView.SelectedIndexChanged += new System.EventHandler(this.AgentsListView_SelectedIndexChanged);
            // 
            // ScenarioAgentNameColumnHeader
            // 
            this.ScenarioAgentNameColumnHeader.Text = "Agent Name";
            this.ScenarioAgentNameColumnHeader.Width = 200;
            // 
            // ScenarioAgentPositionColumnHeader
            // 
            this.ScenarioAgentPositionColumnHeader.Text = "Current Position";
            this.ScenarioAgentPositionColumnHeader.Width = 150;
            // 
            // ScenarioAgentArchetypeColumnHeader
            // 
            this.ScenarioAgentArchetypeColumnHeader.Text = "Archetype";
            this.ScenarioAgentArchetypeColumnHeader.Width = 100;
            // 
            // LocationsTab
            // 
            this.LocationsTab.Controls.Add(this.DeleteLocationButton);
            this.LocationsTab.Controls.Add(this.LocationPropertyGrid);
            this.LocationsTab.Controls.Add(this.LocationRadius);
            this.LocationsTab.Controls.Add(this.LocationRadiusLabel);
            this.LocationsTab.Controls.Add(this.LocationCenterY);
            this.LocationsTab.Controls.Add(this.LocationCenterYLabel);
            this.LocationsTab.Controls.Add(this.LocationCenterX);
            this.LocationsTab.Controls.Add(this.LocationCenterXLabel);
            this.LocationsTab.Controls.Add(this.AddLocationButton);
            this.LocationsTab.Controls.Add(this.LocationsListView);
            this.LocationsTab.Location = new System.Drawing.Point(4, 4);
            this.LocationsTab.Name = "LocationsTab";
            this.LocationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LocationsTab.Size = new System.Drawing.Size(738, 430);
            this.LocationsTab.TabIndex = 1;
            this.LocationsTab.Text = "Locations";
            this.LocationsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteLocationButton
            // 
            this.DeleteLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteLocationButton.ImageIndex = 1;
            this.DeleteLocationButton.ImageList = this.IconImageList;
            this.DeleteLocationButton.Location = new System.Drawing.Point(639, 33);
            this.DeleteLocationButton.Name = "DeleteLocationButton";
            this.DeleteLocationButton.Size = new System.Drawing.Size(96, 27);
            this.DeleteLocationButton.TabIndex = 2;
            this.DeleteLocationButton.Text = "Delete";
            this.DeleteLocationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteLocationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteLocationButton.UseVisualStyleBackColor = true;
            this.DeleteLocationButton.Click += new System.EventHandler(this.DeleteLocationButton_Click);
            // 
            // LocationPropertyGrid
            // 
            this.LocationPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationPropertyGrid.Location = new System.Drawing.Point(316, 228);
            this.LocationPropertyGrid.Name = "LocationPropertyGrid";
            this.LocationPropertyGrid.Size = new System.Drawing.Size(317, 196);
            this.LocationPropertyGrid.TabIndex = 9;
            this.LocationPropertyGrid.ToolbarVisible = false;
            // 
            // LocationRadius
            // 
            this.LocationRadius.DecimalPlaces = 3;
            this.LocationRadius.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.LocationRadius.Location = new System.Drawing.Point(212, 241);
            this.LocationRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LocationRadius.Name = "LocationRadius";
            this.LocationRadius.Size = new System.Drawing.Size(98, 20);
            this.LocationRadius.TabIndex = 8;
            this.LocationRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LocationRadius.ValueChanged += new System.EventHandler(this.LocationRadius_ValueChanged);
            // 
            // LocationRadiusLabel
            // 
            this.LocationRadiusLabel.AutoSize = true;
            this.LocationRadiusLabel.Location = new System.Drawing.Point(209, 225);
            this.LocationRadiusLabel.Name = "LocationRadiusLabel";
            this.LocationRadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.LocationRadiusLabel.TabIndex = 7;
            this.LocationRadiusLabel.Text = "Radius:";
            // 
            // LocationCenterY
            // 
            this.LocationCenterY.DecimalPlaces = 3;
            this.LocationCenterY.Location = new System.Drawing.Point(109, 241);
            this.LocationCenterY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LocationCenterY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.LocationCenterY.Name = "LocationCenterY";
            this.LocationCenterY.Size = new System.Drawing.Size(97, 20);
            this.LocationCenterY.TabIndex = 6;
            this.LocationCenterY.ValueChanged += new System.EventHandler(this.LocationCenterY_ValueChanged);
            // 
            // LocationCenterYLabel
            // 
            this.LocationCenterYLabel.AutoSize = true;
            this.LocationCenterYLabel.Location = new System.Drawing.Point(106, 225);
            this.LocationCenterYLabel.Name = "LocationCenterYLabel";
            this.LocationCenterYLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationCenterYLabel.TabIndex = 5;
            this.LocationCenterYLabel.Text = "Center Y:";
            // 
            // LocationCenterX
            // 
            this.LocationCenterX.DecimalPlaces = 3;
            this.LocationCenterX.Location = new System.Drawing.Point(6, 241);
            this.LocationCenterX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LocationCenterX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.LocationCenterX.Name = "LocationCenterX";
            this.LocationCenterX.Size = new System.Drawing.Size(97, 20);
            this.LocationCenterX.TabIndex = 4;
            this.LocationCenterX.ValueChanged += new System.EventHandler(this.LocationCenterX_ValueChanged);
            // 
            // LocationCenterXLabel
            // 
            this.LocationCenterXLabel.AutoSize = true;
            this.LocationCenterXLabel.Location = new System.Drawing.Point(3, 225);
            this.LocationCenterXLabel.Name = "LocationCenterXLabel";
            this.LocationCenterXLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationCenterXLabel.TabIndex = 3;
            this.LocationCenterXLabel.Text = "Center X:";
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLocationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddLocationButton.ImageIndex = 0;
            this.AddLocationButton.ImageList = this.IconImageList;
            this.AddLocationButton.Location = new System.Drawing.Point(639, 0);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(96, 27);
            this.AddLocationButton.TabIndex = 1;
            this.AddLocationButton.Text = "Add Location";
            this.AddLocationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // LocationsListView
            // 
            this.LocationsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LocationNameColumnHeader,
            this.LocationCoordinatesColumnHeader});
            this.LocationsListView.FullRowSelect = true;
            this.LocationsListView.HideSelection = false;
            this.LocationsListView.LabelEdit = true;
            this.LocationsListView.Location = new System.Drawing.Point(0, 0);
            this.LocationsListView.Name = "LocationsListView";
            this.LocationsListView.Size = new System.Drawing.Size(633, 222);
            this.LocationsListView.TabIndex = 0;
            this.LocationsListView.UseCompatibleStateImageBehavior = false;
            this.LocationsListView.View = System.Windows.Forms.View.Details;
            this.LocationsListView.SelectedIndexChanged += new System.EventHandler(this.LocationsListView_SelectedIndexChanged);
            // 
            // LocationNameColumnHeader
            // 
            this.LocationNameColumnHeader.Text = "Location Name";
            this.LocationNameColumnHeader.Width = 200;
            // 
            // LocationCoordinatesColumnHeader
            // 
            this.LocationCoordinatesColumnHeader.Text = "Coordinates";
            this.LocationCoordinatesColumnHeader.Width = 180;
            // 
            // SimulationTab
            // 
            this.SimulationTab.Controls.Add(this.RandomSeedCombo);
            this.SimulationTab.Controls.Add(this.RandomSeedLabel);
            this.SimulationTab.Controls.Add(this.ResetSimulationButton);
            this.SimulationTab.Controls.Add(this.AutoAdvanceButton);
            this.SimulationTab.Controls.Add(this.Advance100msButton);
            this.SimulationTab.Controls.Add(this.ScenarioRenderingBox);
            this.SimulationTab.Location = new System.Drawing.Point(4, 4);
            this.SimulationTab.Name = "SimulationTab";
            this.SimulationTab.Size = new System.Drawing.Size(738, 430);
            this.SimulationTab.TabIndex = 2;
            this.SimulationTab.Text = "Simulation";
            this.SimulationTab.UseVisualStyleBackColor = true;
            // 
            // RandomSeedCombo
            // 
            this.RandomSeedCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomSeedCombo.FormattingEnabled = true;
            this.RandomSeedCombo.Location = new System.Drawing.Point(85, 403);
            this.RandomSeedCombo.Name = "RandomSeedCombo";
            this.RandomSeedCombo.Size = new System.Drawing.Size(137, 21);
            this.RandomSeedCombo.TabIndex = 1;
            // 
            // RandomSeedLabel
            // 
            this.RandomSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomSeedLabel.AutoSize = true;
            this.RandomSeedLabel.Location = new System.Drawing.Point(3, 406);
            this.RandomSeedLabel.Name = "RandomSeedLabel";
            this.RandomSeedLabel.Size = new System.Drawing.Size(76, 13);
            this.RandomSeedLabel.TabIndex = 0;
            this.RandomSeedLabel.Text = "Random seed:";
            // 
            // ResetSimulationButton
            // 
            this.ResetSimulationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetSimulationButton.Location = new System.Drawing.Point(622, 398);
            this.ResetSimulationButton.Name = "ResetSimulationButton";
            this.ResetSimulationButton.Size = new System.Drawing.Size(113, 29);
            this.ResetSimulationButton.TabIndex = 4;
            this.ResetSimulationButton.Text = "Reset to Start";
            this.ResetSimulationButton.UseVisualStyleBackColor = true;
            this.ResetSimulationButton.Click += new System.EventHandler(this.ResetSimulationButton_Click);
            // 
            // AutoAdvanceButton
            // 
            this.AutoAdvanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoAdvanceButton.Location = new System.Drawing.Point(503, 398);
            this.AutoAdvanceButton.Name = "AutoAdvanceButton";
            this.AutoAdvanceButton.Size = new System.Drawing.Size(113, 29);
            this.AutoAdvanceButton.TabIndex = 3;
            this.AutoAdvanceButton.Text = "Auto Advance";
            this.AutoAdvanceButton.UseVisualStyleBackColor = true;
            this.AutoAdvanceButton.Click += new System.EventHandler(this.AutoAdvanceButton_Click);
            // 
            // Advance100msButton
            // 
            this.Advance100msButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Advance100msButton.Location = new System.Drawing.Point(384, 398);
            this.Advance100msButton.Name = "Advance100msButton";
            this.Advance100msButton.Size = new System.Drawing.Size(113, 29);
            this.Advance100msButton.TabIndex = 2;
            this.Advance100msButton.Text = "Advance 100 ms";
            this.Advance100msButton.UseVisualStyleBackColor = true;
            this.Advance100msButton.Click += new System.EventHandler(this.Advance100msButton_Click);
            // 
            // ScenarioRenderingBox
            // 
            this.ScenarioRenderingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioRenderingBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScenarioRenderingBox.Location = new System.Drawing.Point(3, 3);
            this.ScenarioRenderingBox.Name = "ScenarioRenderingBox";
            this.ScenarioRenderingBox.Size = new System.Drawing.Size(732, 390);
            this.ScenarioRenderingBox.TabIndex = 0;
            this.ScenarioRenderingBox.TabStop = false;
            // 
            // LogsTab
            // 
            this.LogsTab.Controls.Add(this.LogDetailTextBox);
            this.LogsTab.Controls.Add(this.LogsTreeView);
            this.LogsTab.Location = new System.Drawing.Point(4, 4);
            this.LogsTab.Name = "LogsTab";
            this.LogsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogsTab.Size = new System.Drawing.Size(738, 430);
            this.LogsTab.TabIndex = 3;
            this.LogsTab.Text = "Logs";
            this.LogsTab.UseVisualStyleBackColor = true;
            // 
            // LogDetailTextBox
            // 
            this.LogDetailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDetailTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogDetailTextBox.Location = new System.Drawing.Point(255, 0);
            this.LogDetailTextBox.Multiline = true;
            this.LogDetailTextBox.Name = "LogDetailTextBox";
            this.LogDetailTextBox.ReadOnly = true;
            this.LogDetailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogDetailTextBox.Size = new System.Drawing.Size(477, 424);
            this.LogDetailTextBox.TabIndex = 1;
            this.LogDetailTextBox.WordWrap = false;
            // 
            // LogsTreeView
            // 
            this.LogsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogsTreeView.FullRowSelect = true;
            this.LogsTreeView.Location = new System.Drawing.Point(0, 0);
            this.LogsTreeView.Name = "LogsTreeView";
            this.LogsTreeView.Size = new System.Drawing.Size(249, 424);
            this.LogsTreeView.TabIndex = 0;
            // 
            // AutoAdvanceTimer
            // 
            this.AutoAdvanceTimer.Tick += new System.EventHandler(this.AutoAdvanceTimer_Tick);
            // 
            // ColorPicker
            // 
            this.ColorPicker.AnyColor = true;
            this.ColorPicker.FullOpen = true;
            // 
            // ScenariosToolTip
            // 
            this.ScenariosToolTip.AutoPopDelay = 5000;
            this.ScenariosToolTip.InitialDelay = 500;
            this.ScenariosToolTip.ReshowDelay = 100;
            // 
            // NameEditWidget
            // 
            this.NameEditWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameEditWidget.Location = new System.Drawing.Point(0, 0);
            this.NameEditWidget.Name = "NameEditWidget";
            this.NameEditWidget.Size = new System.Drawing.Size(752, 30);
            this.NameEditWidget.TabIndex = 0;
            // 
            // EditWidgetScenario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.NameEditWidget);
            this.Controls.Add(this.ScenarioEditorTabs);
            this.Name = "EditWidgetScenario";
            this.Size = new System.Drawing.Size(752, 495);
            this.ScenarioEditorTabs.ResumeLayout(false);
            this.AgentsTab.ResumeLayout(false);
            this.AgentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSwatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentRadiusUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentXUpDown)).EndInit();
            this.LocationsTab.ResumeLayout(false);
            this.LocationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationCenterY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationCenterX)).EndInit();
            this.SimulationTab.ResumeLayout(false);
            this.SimulationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioRenderingBox)).EndInit();
            this.LogsTab.ResumeLayout(false);
            this.LogsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ScenarioEditorTabs;
        private System.Windows.Forms.TabPage AgentsTab;
        private System.Windows.Forms.TabPage LocationsTab;
        private System.Windows.Forms.TabPage SimulationTab;
        private System.Windows.Forms.PictureBox ScenarioRenderingBox;
        private System.Windows.Forms.Button Advance100msButton;
        private System.Windows.Forms.ListView AgentsListView;
        private System.Windows.Forms.ColumnHeader ScenarioAgentNameColumnHeader;
        private System.Windows.Forms.ColumnHeader ScenarioAgentPositionColumnHeader;
        private System.Windows.Forms.Button AddAgentButton;
        private System.Windows.Forms.ListView LocationsListView;
        private System.Windows.Forms.ColumnHeader LocationNameColumnHeader;
        private System.Windows.Forms.ColumnHeader LocationCoordinatesColumnHeader;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.ColumnHeader ScenarioAgentArchetypeColumnHeader;
        private System.Windows.Forms.Label AgentXLabel;
        private System.Windows.Forms.NumericUpDown AgentXUpDown;
        private System.Windows.Forms.NumericUpDown AgentYUpDown;
        private System.Windows.Forms.Label AgentYLabel;
        private System.Windows.Forms.NumericUpDown AgentRadiusUpDown;
        private System.Windows.Forms.Label AgentRadiusLabel;
        private System.Windows.Forms.ComboBox AgentArchetypeComboBox;
        private System.Windows.Forms.Label AgentArchetypeLabel;
        private System.Windows.Forms.Label AgentStartXLabel;
        private System.Windows.Forms.NumericUpDown AgentStartXUpDown;
        private System.Windows.Forms.NumericUpDown AgentStartYUpDown;
        private System.Windows.Forms.Label AgentStartYLabel;
        private System.Windows.Forms.Button AgentResetButton;
        private System.Windows.Forms.Button CopyCurrentAgentPositionButton;
        private System.Windows.Forms.Button AutoAdvanceButton;
        private System.Windows.Forms.Timer AutoAdvanceTimer;
        private System.Windows.Forms.Button ResetSimulationButton;
        private EditWidgetName NameEditWidget;
        private System.Windows.Forms.TabPage LogsTab;
        private System.Windows.Forms.TreeView LogsTreeView;
        private System.Windows.Forms.TextBox LogDetailTextBox;
        private System.Windows.Forms.ToolTip SimulationInspectionTooltip;
        private System.Windows.Forms.PropertyGrid AgentProperties;
        private System.Windows.Forms.Button DeleteSelectedAgentsButton;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.PictureBox ColorSwatch;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Label RandomSeedLabel;
        private System.Windows.Forms.ComboBox RandomSeedCombo;
        private System.Windows.Forms.Label AgentStartLocationLabel;
        private System.Windows.Forms.ComboBox AgentStartLocationCombo;
        private System.Windows.Forms.CheckBox AgentRandomStartPositionCheckBox;
        private System.Windows.Forms.ToolTip ScenariosToolTip;
        private System.Windows.Forms.Label LocationCenterXLabel;
        private System.Windows.Forms.NumericUpDown LocationCenterX;
        private System.Windows.Forms.Label LocationCenterYLabel;
        private System.Windows.Forms.NumericUpDown LocationCenterY;
        private System.Windows.Forms.Label LocationRadiusLabel;
        private System.Windows.Forms.NumericUpDown LocationRadius;
        private System.Windows.Forms.PropertyGrid LocationPropertyGrid;
        private System.Windows.Forms.Button DeleteLocationButton;
    }
}
