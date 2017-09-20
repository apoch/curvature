namespace Curvature.Widgets
{
    partial class EditWidgetScenarios
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
            this.DeleteScenariosButton = new System.Windows.Forms.Button();
            this.ScenariosListView = new System.Windows.Forms.ListView();
            this.ScenarioNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateScenarioButton = new System.Windows.Forms.Button();
            this.ScenarioPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DeleteScenariosButton
            // 
            this.DeleteScenariosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteScenariosButton.Location = new System.Drawing.Point(3, 560);
            this.DeleteScenariosButton.Name = "DeleteScenariosButton";
            this.DeleteScenariosButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteScenariosButton.TabIndex = 9;
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
            this.ScenariosListView.Size = new System.Drawing.Size(244, 522);
            this.ScenariosListView.TabIndex = 8;
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
            this.CreateScenarioButton.Location = new System.Drawing.Point(3, 531);
            this.CreateScenarioButton.Name = "CreateScenarioButton";
            this.CreateScenarioButton.Size = new System.Drawing.Size(244, 23);
            this.CreateScenarioButton.TabIndex = 7;
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
            this.ScenarioPanel.Size = new System.Drawing.Size(668, 580);
            this.ScenarioPanel.TabIndex = 6;
            // 
            // EditWidgetScenarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteScenariosButton);
            this.Controls.Add(this.ScenariosListView);
            this.Controls.Add(this.CreateScenarioButton);
            this.Controls.Add(this.ScenarioPanel);
            this.Name = "EditWidgetScenarios";
            this.Size = new System.Drawing.Size(924, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteScenariosButton;
        private System.Windows.Forms.ListView ScenariosListView;
        private System.Windows.Forms.ColumnHeader ScenarioNameColumn;
        private System.Windows.Forms.Button CreateScenarioButton;
        private System.Windows.Forms.Panel ScenarioPanel;
    }
}
