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
            this.AddAgentButton = new System.Windows.Forms.Button();
            this.AgentsListView = new System.Windows.Forms.ListView();
            this.ScenarioAgentNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScenarioAgentPositionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationsTab = new System.Windows.Forms.TabPage();
            this.SimulationTab = new System.Windows.Forms.TabPage();
            this.Advance100msButton = new System.Windows.Forms.Button();
            this.ScenarioRenderingBox = new System.Windows.Forms.PictureBox();
            this.ScenarioNameLabel = new System.Windows.Forms.Label();
            this.LocationsListView = new System.Windows.Forms.ListView();
            this.LocationNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationCoordinatesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.ScenarioAgentArchetypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScenarioEditorTabs.SuspendLayout();
            this.AgentsTab.SuspendLayout();
            this.LocationsTab.SuspendLayout();
            this.SimulationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioRenderingBox)).BeginInit();
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
            // ScenarioAgentArchetypeColumnHeader
            // 
            this.ScenarioAgentArchetypeColumnHeader.Text = "Archetype";
            this.ScenarioAgentArchetypeColumnHeader.Width = 100;
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
            this.LocationsTab.ResumeLayout(false);
            this.SimulationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScenarioRenderingBox)).EndInit();
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
    }
}
