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
            this.ScenarioEditorTabs = new System.Windows.Forms.TabControl();
            this.AgentsTab = new System.Windows.Forms.TabPage();
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
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.LocationsListView = new System.Windows.Forms.ListView();
            this.LocationNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationCoordinatesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SimulationTab = new System.Windows.Forms.TabPage();
            this.Advance100msButton = new System.Windows.Forms.Button();
            this.ScenarioRenderingBox = new System.Windows.Forms.PictureBox();
            this.ScenarioNameLabel = new System.Windows.Forms.Label();
            this.AgentStartXUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentStartXLabel = new System.Windows.Forms.Label();
            this.AgentStartYUpDown = new System.Windows.Forms.NumericUpDown();
            this.AgentStartYLabel = new System.Windows.Forms.Label();
            this.AgentResetButton = new System.Windows.Forms.Button();
            this.CopyCurrentAgentPositionButton = new System.Windows.Forms.Button();
            this.ScenarioEditorTabs.SuspendLayout();
            this.AgentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgentRadiusUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentXUpDown)).BeginInit();
            this.LocationsTab.SuspendLayout();
            this.SimulationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioRenderingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartYUpDown)).BeginInit();
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
            this.ScenarioEditorTabs.Location = new System.Drawing.Point(3, 23);
            this.ScenarioEditorTabs.Name = "ScenarioEditorTabs";
            this.ScenarioEditorTabs.SelectedIndex = 0;
            this.ScenarioEditorTabs.Size = new System.Drawing.Size(746, 469);
            this.ScenarioEditorTabs.TabIndex = 0;
            // 
            // AgentsTab
            // 
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
            this.AgentsTab.Size = new System.Drawing.Size(738, 443);
            this.AgentsTab.TabIndex = 0;
            this.AgentsTab.Text = "Agents";
            this.AgentsTab.UseVisualStyleBackColor = true;
            // 
            // AgentArchetypeLabel
            // 
            this.AgentArchetypeLabel.AutoSize = true;
            this.AgentArchetypeLabel.Location = new System.Drawing.Point(263, 225);
            this.AgentArchetypeLabel.Name = "AgentArchetypeLabel";
            this.AgentArchetypeLabel.Size = new System.Drawing.Size(58, 13);
            this.AgentArchetypeLabel.TabIndex = 9;
            this.AgentArchetypeLabel.Text = "Archetype:";
            // 
            // AgentArchetypeComboBox
            // 
            this.AgentArchetypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentArchetypeComboBox.FormattingEnabled = true;
            this.AgentArchetypeComboBox.Location = new System.Drawing.Point(266, 240);
            this.AgentArchetypeComboBox.Name = "AgentArchetypeComboBox";
            this.AgentArchetypeComboBox.Size = new System.Drawing.Size(181, 21);
            this.AgentArchetypeComboBox.TabIndex = 8;
            this.AgentArchetypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AgentArchetypeComboBox_SelectedIndexChanged);
            // 
            // AgentRadiusLabel
            // 
            this.AgentRadiusLabel.AutoSize = true;
            this.AgentRadiusLabel.Location = new System.Drawing.Point(176, 225);
            this.AgentRadiusLabel.Name = "AgentRadiusLabel";
            this.AgentRadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.AgentRadiusLabel.TabIndex = 7;
            this.AgentRadiusLabel.Text = "Radius:";
            // 
            // AgentRadiusUpDown
            // 
            this.AgentRadiusUpDown.DecimalPlaces = 3;
            this.AgentRadiusUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentRadiusUpDown.Location = new System.Drawing.Point(179, 241);
            this.AgentRadiusUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.AgentRadiusUpDown.Name = "AgentRadiusUpDown";
            this.AgentRadiusUpDown.Size = new System.Drawing.Size(81, 20);
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
            this.AgentYLabel.Location = new System.Drawing.Point(89, 225);
            this.AgentYLabel.Name = "AgentYLabel";
            this.AgentYLabel.Size = new System.Drawing.Size(54, 13);
            this.AgentYLabel.TabIndex = 5;
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
            this.AgentYUpDown.Location = new System.Drawing.Point(92, 241);
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
            this.AgentYUpDown.TabIndex = 4;
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
            this.AgentXUpDown.Location = new System.Drawing.Point(6, 241);
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
            this.AgentXUpDown.TabIndex = 3;
            this.AgentXUpDown.ValueChanged += new System.EventHandler(this.AgentXUpDown_ValueChanged);
            // 
            // AgentXLabel
            // 
            this.AgentXLabel.AutoSize = true;
            this.AgentXLabel.Location = new System.Drawing.Point(3, 225);
            this.AgentXLabel.Name = "AgentXLabel";
            this.AgentXLabel.Size = new System.Drawing.Size(54, 13);
            this.AgentXLabel.TabIndex = 2;
            this.AgentXLabel.Text = "Current X:";
            // 
            // AddAgentButton
            // 
            this.AddAgentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAgentButton.Location = new System.Drawing.Point(639, 0);
            this.AddAgentButton.Name = "AddAgentButton";
            this.AddAgentButton.Size = new System.Drawing.Size(96, 27);
            this.AddAgentButton.TabIndex = 1;
            this.AddAgentButton.Text = "Add Agent";
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
            this.AgentsListView.Location = new System.Drawing.Point(0, 0);
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
            this.LocationsTab.Controls.Add(this.AddLocationButton);
            this.LocationsTab.Controls.Add(this.LocationsListView);
            this.LocationsTab.Location = new System.Drawing.Point(4, 4);
            this.LocationsTab.Name = "LocationsTab";
            this.LocationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LocationsTab.Size = new System.Drawing.Size(738, 443);
            this.LocationsTab.TabIndex = 1;
            this.LocationsTab.Text = "Locations";
            this.LocationsTab.UseVisualStyleBackColor = true;
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLocationButton.Location = new System.Drawing.Point(639, 0);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(96, 27);
            this.AddLocationButton.TabIndex = 1;
            this.AddLocationButton.Text = "Add Location";
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
            this.LocationsListView.Location = new System.Drawing.Point(0, 0);
            this.LocationsListView.Name = "LocationsListView";
            this.LocationsListView.Size = new System.Drawing.Size(633, 222);
            this.LocationsListView.TabIndex = 0;
            this.LocationsListView.UseCompatibleStateImageBehavior = false;
            this.LocationsListView.View = System.Windows.Forms.View.Details;
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
            this.SimulationTab.Controls.Add(this.Advance100msButton);
            this.SimulationTab.Controls.Add(this.ScenarioRenderingBox);
            this.SimulationTab.Location = new System.Drawing.Point(4, 4);
            this.SimulationTab.Name = "SimulationTab";
            this.SimulationTab.Size = new System.Drawing.Size(738, 443);
            this.SimulationTab.TabIndex = 2;
            this.SimulationTab.Text = "Simulation";
            this.SimulationTab.UseVisualStyleBackColor = true;
            // 
            // Advance100msButton
            // 
            this.Advance100msButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Advance100msButton.Location = new System.Drawing.Point(3, 411);
            this.Advance100msButton.Name = "Advance100msButton";
            this.Advance100msButton.Size = new System.Drawing.Size(113, 29);
            this.Advance100msButton.TabIndex = 1;
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
            this.ScenarioRenderingBox.Size = new System.Drawing.Size(732, 403);
            this.ScenarioRenderingBox.TabIndex = 0;
            this.ScenarioRenderingBox.TabStop = false;
            // 
            // ScenarioNameLabel
            // 
            this.ScenarioNameLabel.AutoSize = true;
            this.ScenarioNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScenarioNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ScenarioNameLabel.Name = "ScenarioNameLabel";
            this.ScenarioNameLabel.Size = new System.Drawing.Size(143, 20);
            this.ScenarioNameLabel.TabIndex = 1;
            this.ScenarioNameLabel.Text = "(Scenario Name)";
            // 
            // AgentStartXUpDown
            // 
            this.AgentStartXUpDown.DecimalPlaces = 3;
            this.AgentStartXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentStartXUpDown.Location = new System.Drawing.Point(6, 286);
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
            this.AgentStartXUpDown.TabIndex = 10;
            this.AgentStartXUpDown.ValueChanged += new System.EventHandler(this.AgentStartXUpDown_ValueChanged);
            // 
            // AgentStartXLabel
            // 
            this.AgentStartXLabel.AutoSize = true;
            this.AgentStartXLabel.Location = new System.Drawing.Point(3, 270);
            this.AgentStartXLabel.Name = "AgentStartXLabel";
            this.AgentStartXLabel.Size = new System.Drawing.Size(42, 13);
            this.AgentStartXLabel.TabIndex = 11;
            this.AgentStartXLabel.Text = "Start X:";
            // 
            // AgentStartYUpDown
            // 
            this.AgentStartYUpDown.DecimalPlaces = 3;
            this.AgentStartYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AgentStartYUpDown.Location = new System.Drawing.Point(92, 286);
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
            this.AgentStartYUpDown.TabIndex = 12;
            this.AgentStartYUpDown.ValueChanged += new System.EventHandler(this.AgentStartYUpDown_ValueChanged);
            // 
            // AgentStartYLabel
            // 
            this.AgentStartYLabel.AutoSize = true;
            this.AgentStartYLabel.Location = new System.Drawing.Point(89, 270);
            this.AgentStartYLabel.Name = "AgentStartYLabel";
            this.AgentStartYLabel.Size = new System.Drawing.Size(42, 13);
            this.AgentStartYLabel.TabIndex = 14;
            this.AgentStartYLabel.Text = "Start Y:";
            // 
            // AgentResetButton
            // 
            this.AgentResetButton.Location = new System.Drawing.Point(179, 286);
            this.AgentResetButton.Name = "AgentResetButton";
            this.AgentResetButton.Size = new System.Drawing.Size(81, 20);
            this.AgentResetButton.TabIndex = 15;
            this.AgentResetButton.Text = "Set Current";
            this.AgentResetButton.UseVisualStyleBackColor = true;
            this.AgentResetButton.Click += new System.EventHandler(this.AgentResetButton_Click);
            // 
            // CopyCurrentAgentPositionButton
            // 
            this.CopyCurrentAgentPositionButton.Location = new System.Drawing.Point(266, 286);
            this.CopyCurrentAgentPositionButton.Name = "CopyCurrentAgentPositionButton";
            this.CopyCurrentAgentPositionButton.Size = new System.Drawing.Size(81, 20);
            this.CopyCurrentAgentPositionButton.TabIndex = 16;
            this.CopyCurrentAgentPositionButton.Text = "Copy Current";
            this.CopyCurrentAgentPositionButton.UseVisualStyleBackColor = true;
            this.CopyCurrentAgentPositionButton.Click += new System.EventHandler(this.CopyCurrentAgentPositionButton_Click);
            // 
            // EditWidgetScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScenarioNameLabel);
            this.Controls.Add(this.ScenarioEditorTabs);
            this.Name = "EditWidgetScenario";
            this.Size = new System.Drawing.Size(752, 495);
            this.ScenarioEditorTabs.ResumeLayout(false);
            this.AgentsTab.ResumeLayout(false);
            this.AgentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgentRadiusUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentXUpDown)).EndInit();
            this.LocationsTab.ResumeLayout(false);
            this.SimulationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioRenderingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentStartYUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ScenarioEditorTabs;
        private System.Windows.Forms.TabPage AgentsTab;
        private System.Windows.Forms.TabPage LocationsTab;
        private System.Windows.Forms.TabPage SimulationTab;
        private System.Windows.Forms.Label ScenarioNameLabel;
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
    }
}
