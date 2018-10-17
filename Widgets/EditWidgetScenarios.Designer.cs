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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetScenarios));
            this.DeleteScenariosButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.ScenariosListView = new System.Windows.Forms.ListView();
            this.ScenarioNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateScenarioButton = new System.Windows.Forms.Button();
            this.ScenarioEditWidget = new Curvature.EditWidgetScenario();
            this.HintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteScenariosButton
            // 
            this.DeleteScenariosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteScenariosButton.ImageIndex = 1;
            this.DeleteScenariosButton.ImageList = this.IconImageList;
            this.DeleteScenariosButton.Location = new System.Drawing.Point(128, 531);
            this.DeleteScenariosButton.Name = "DeleteScenariosButton";
            this.DeleteScenariosButton.Size = new System.Drawing.Size(119, 52);
            this.DeleteScenariosButton.TabIndex = 2;
            this.DeleteScenariosButton.Text = "Delete Selection";
            this.DeleteScenariosButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteScenariosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteScenariosButton.UseVisualStyleBackColor = true;
            this.DeleteScenariosButton.Click += new System.EventHandler(this.DeleteScenariosButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            this.IconImageList.Images.SetKeyName(1, "DeleteItemIcon.png");
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
            this.ScenariosListView.TabIndex = 0;
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
            this.CreateScenarioButton.ImageIndex = 0;
            this.CreateScenarioButton.ImageList = this.IconImageList;
            this.CreateScenarioButton.Location = new System.Drawing.Point(3, 531);
            this.CreateScenarioButton.Name = "CreateScenarioButton";
            this.CreateScenarioButton.Size = new System.Drawing.Size(119, 52);
            this.CreateScenarioButton.TabIndex = 1;
            this.CreateScenarioButton.Text = "Create Scenario";
            this.CreateScenarioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateScenarioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CreateScenarioButton.UseVisualStyleBackColor = true;
            this.CreateScenarioButton.Click += new System.EventHandler(this.CreateScenarioButton_Click);
            // 
            // ScenarioEditWidget
            // 
            this.ScenarioEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScenarioEditWidget.Location = new System.Drawing.Point(253, 3);
            this.ScenarioEditWidget.Name = "ScenarioEditWidget";
            this.ScenarioEditWidget.Size = new System.Drawing.Size(668, 580);
            this.ScenarioEditWidget.TabIndex = 3;
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.Location = new System.Drawing.Point(253, 3);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(668, 580);
            this.HintLabel.TabIndex = 11;
            this.HintLabel.Text = "Select or create a scenario to watch your AI come to life!";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditWidgetScenarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ScenarioEditWidget);
            this.Controls.Add(this.DeleteScenariosButton);
            this.Controls.Add(this.ScenariosListView);
            this.Controls.Add(this.CreateScenarioButton);
            this.Controls.Add(this.HintLabel);
            this.Name = "EditWidgetScenarios";
            this.Size = new System.Drawing.Size(924, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteScenariosButton;
        private System.Windows.Forms.ListView ScenariosListView;
        private System.Windows.Forms.ColumnHeader ScenarioNameColumn;
        private System.Windows.Forms.Button CreateScenarioButton;
        private System.Windows.Forms.ImageList IconImageList;
        private EditWidgetScenario ScenarioEditWidget;
        private System.Windows.Forms.Label HintLabel;
    }
}
