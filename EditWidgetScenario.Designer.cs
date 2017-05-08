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
            this.LocationsTab = new System.Windows.Forms.TabPage();
            this.SimulationTab = new System.Windows.Forms.TabPage();
            this.Advance100msButton = new System.Windows.Forms.Button();
            this.ScenarioRenderingBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScenarioEditorTabs.SuspendLayout();
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
            this.AgentsTab.Location = new System.Drawing.Point(4, 4);
            this.AgentsTab.Name = "AgentsTab";
            this.AgentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AgentsTab.Size = new System.Drawing.Size(738, 443);
            this.AgentsTab.TabIndex = 0;
            this.AgentsTab.Text = "Agents";
            this.AgentsTab.UseVisualStyleBackColor = true;
            // 
            // LocationsTab
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Scenario Name)";
            // 
            // EditWidgetScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScenarioEditorTabs);
            this.Name = "EditWidgetScenario";
            this.Size = new System.Drawing.Size(752, 495);
            this.ScenarioEditorTabs.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ScenarioRenderingBox;
        private System.Windows.Forms.Button Advance100msButton;
    }
}
