namespace Curvature.Widgets
{
    partial class EditWidgetBehaviors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetBehaviors));
            this.DeleteSelectedBehaviorsButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.BehaviorsListView = new System.Windows.Forms.ListView();
            this.BehaviorNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateBehaviorButton = new System.Windows.Forms.Button();
            this.BehaviorTabs = new System.Windows.Forms.TabControl();
            this.BehaviorSettingsTab = new System.Windows.Forms.TabPage();
            this.BehaviorEditWidget = new Curvature.EditWidgetBehavior();
            this.BehaviorConsiderationsTab = new System.Windows.Forms.TabPage();
            this.DeleteConsiderationButton = new System.Windows.Forms.Button();
            this.AddConsiderationButton = new System.Windows.Forms.Button();
            this.ConsiderationEditWidget = new Curvature.EditWidgetConsideration();
            this.ConsiderationsListView = new System.Windows.Forms.ListView();
            this.ConsiderationNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BehaviorScoringTab = new System.Windows.Forms.TabPage();
            this.BehaviorScoringWidget = new Curvature.Widgets.EditWidgetBehaviorScoring();
            this.HintLabel = new System.Windows.Forms.Label();
            this.BehaviorNameEditWidget = new Curvature.EditWidgetName();
            this.BehaviorTabs.SuspendLayout();
            this.BehaviorSettingsTab.SuspendLayout();
            this.BehaviorConsiderationsTab.SuspendLayout();
            this.BehaviorScoringTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteSelectedBehaviorsButton
            // 
            this.DeleteSelectedBehaviorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelectedBehaviorsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteSelectedBehaviorsButton.ImageIndex = 1;
            this.DeleteSelectedBehaviorsButton.ImageList = this.IconImageList;
            this.DeleteSelectedBehaviorsButton.Location = new System.Drawing.Point(128, 534);
            this.DeleteSelectedBehaviorsButton.Name = "DeleteSelectedBehaviorsButton";
            this.DeleteSelectedBehaviorsButton.Size = new System.Drawing.Size(119, 52);
            this.DeleteSelectedBehaviorsButton.TabIndex = 2;
            this.DeleteSelectedBehaviorsButton.Text = "Delete Selection";
            this.DeleteSelectedBehaviorsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteSelectedBehaviorsButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedBehaviorsButton.Click += new System.EventHandler(this.DeleteSelectedBehaviorsButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            this.IconImageList.Images.SetKeyName(1, "DeleteItemIcon.png");
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
            this.BehaviorsListView.Size = new System.Drawing.Size(244, 525);
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
            this.CreateBehaviorButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateBehaviorButton.ImageIndex = 0;
            this.CreateBehaviorButton.ImageList = this.IconImageList;
            this.CreateBehaviorButton.Location = new System.Drawing.Point(3, 534);
            this.CreateBehaviorButton.Name = "CreateBehaviorButton";
            this.CreateBehaviorButton.Size = new System.Drawing.Size(119, 52);
            this.CreateBehaviorButton.TabIndex = 1;
            this.CreateBehaviorButton.Text = "Create Behavior";
            this.CreateBehaviorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CreateBehaviorButton.UseVisualStyleBackColor = true;
            this.CreateBehaviorButton.Click += new System.EventHandler(this.CreateBehaviorButton_Click);
            // 
            // BehaviorTabs
            // 
            this.BehaviorTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorTabs.Controls.Add(this.BehaviorSettingsTab);
            this.BehaviorTabs.Controls.Add(this.BehaviorConsiderationsTab);
            this.BehaviorTabs.Controls.Add(this.BehaviorScoringTab);
            this.BehaviorTabs.Location = new System.Drawing.Point(253, 38);
            this.BehaviorTabs.Name = "BehaviorTabs";
            this.BehaviorTabs.SelectedIndex = 0;
            this.BehaviorTabs.Size = new System.Drawing.Size(562, 548);
            this.BehaviorTabs.TabIndex = 3;
            this.BehaviorTabs.Visible = false;
            // 
            // BehaviorSettingsTab
            // 
            this.BehaviorSettingsTab.Controls.Add(this.BehaviorEditWidget);
            this.BehaviorSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorSettingsTab.Name = "BehaviorSettingsTab";
            this.BehaviorSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BehaviorSettingsTab.Size = new System.Drawing.Size(554, 522);
            this.BehaviorSettingsTab.TabIndex = 0;
            this.BehaviorSettingsTab.Text = "Behavior";
            this.BehaviorSettingsTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorEditWidget
            // 
            this.BehaviorEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorEditWidget.Location = new System.Drawing.Point(6, 6);
            this.BehaviorEditWidget.Name = "BehaviorEditWidget";
            this.BehaviorEditWidget.Size = new System.Drawing.Size(542, 510);
            this.BehaviorEditWidget.TabIndex = 0;
            // 
            // BehaviorConsiderationsTab
            // 
            this.BehaviorConsiderationsTab.Controls.Add(this.DeleteConsiderationButton);
            this.BehaviorConsiderationsTab.Controls.Add(this.AddConsiderationButton);
            this.BehaviorConsiderationsTab.Controls.Add(this.ConsiderationEditWidget);
            this.BehaviorConsiderationsTab.Controls.Add(this.ConsiderationsListView);
            this.BehaviorConsiderationsTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorConsiderationsTab.Name = "BehaviorConsiderationsTab";
            this.BehaviorConsiderationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BehaviorConsiderationsTab.Size = new System.Drawing.Size(554, 522);
            this.BehaviorConsiderationsTab.TabIndex = 1;
            this.BehaviorConsiderationsTab.Text = "Edit Considerations";
            this.BehaviorConsiderationsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteConsiderationButton
            // 
            this.DeleteConsiderationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteConsiderationButton.ImageIndex = 1;
            this.DeleteConsiderationButton.ImageList = this.IconImageList;
            this.DeleteConsiderationButton.Location = new System.Drawing.Point(124, 474);
            this.DeleteConsiderationButton.Name = "DeleteConsiderationButton";
            this.DeleteConsiderationButton.Size = new System.Drawing.Size(102, 42);
            this.DeleteConsiderationButton.TabIndex = 2;
            this.DeleteConsiderationButton.Text = "Delete";
            this.DeleteConsiderationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteConsiderationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteConsiderationButton.UseVisualStyleBackColor = true;
            this.DeleteConsiderationButton.Click += new System.EventHandler(this.DeleteConsiderationButton_Click);
            // 
            // AddConsiderationButton
            // 
            this.AddConsiderationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddConsiderationButton.ImageIndex = 0;
            this.AddConsiderationButton.ImageList = this.IconImageList;
            this.AddConsiderationButton.Location = new System.Drawing.Point(6, 474);
            this.AddConsiderationButton.Name = "AddConsiderationButton";
            this.AddConsiderationButton.Size = new System.Drawing.Size(112, 42);
            this.AddConsiderationButton.TabIndex = 1;
            this.AddConsiderationButton.Text = "Add...";
            this.AddConsiderationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddConsiderationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddConsiderationButton.UseVisualStyleBackColor = true;
            this.AddConsiderationButton.Click += new System.EventHandler(this.AddConsiderationButton_Click);
            // 
            // ConsiderationEditWidget
            // 
            this.ConsiderationEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsiderationEditWidget.Location = new System.Drawing.Point(232, 6);
            this.ConsiderationEditWidget.Name = "ConsiderationEditWidget";
            this.ConsiderationEditWidget.Size = new System.Drawing.Size(316, 510);
            this.ConsiderationEditWidget.TabIndex = 3;
            this.ConsiderationEditWidget.Visible = false;
            // 
            // ConsiderationsListView
            // 
            this.ConsiderationsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsiderationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConsiderationNameHeader});
            this.ConsiderationsListView.FullRowSelect = true;
            this.ConsiderationsListView.HideSelection = false;
            this.ConsiderationsListView.Location = new System.Drawing.Point(6, 6);
            this.ConsiderationsListView.Name = "ConsiderationsListView";
            this.ConsiderationsListView.Size = new System.Drawing.Size(220, 462);
            this.ConsiderationsListView.TabIndex = 0;
            this.ConsiderationsListView.UseCompatibleStateImageBehavior = false;
            this.ConsiderationsListView.View = System.Windows.Forms.View.Details;
            this.ConsiderationsListView.SelectedIndexChanged += new System.EventHandler(this.ConsiderationsListView_SelectedIndexChanged);
            // 
            // ConsiderationNameHeader
            // 
            this.ConsiderationNameHeader.Text = "Consideration Name";
            this.ConsiderationNameHeader.Width = 185;
            // 
            // BehaviorScoringTab
            // 
            this.BehaviorScoringTab.Controls.Add(this.BehaviorScoringWidget);
            this.BehaviorScoringTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorScoringTab.Name = "BehaviorScoringTab";
            this.BehaviorScoringTab.Size = new System.Drawing.Size(554, 522);
            this.BehaviorScoringTab.TabIndex = 2;
            this.BehaviorScoringTab.Text = "Scoring Preview";
            this.BehaviorScoringTab.UseVisualStyleBackColor = true;
            // 
            // BehaviorScoringWidget
            // 
            this.BehaviorScoringWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorScoringWidget.Location = new System.Drawing.Point(0, 0);
            this.BehaviorScoringWidget.Name = "BehaviorScoringWidget";
            this.BehaviorScoringWidget.Size = new System.Drawing.Size(554, 522);
            this.BehaviorScoringWidget.TabIndex = 0;
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.Location = new System.Drawing.Point(253, 3);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(558, 583);
            this.HintLabel.TabIndex = 9;
            this.HintLabel.Text = "Select or create a behavior to begin editing.";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BehaviorNameEditWidget
            // 
            this.BehaviorNameEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorNameEditWidget.Location = new System.Drawing.Point(253, 3);
            this.BehaviorNameEditWidget.Name = "BehaviorNameEditWidget";
            this.BehaviorNameEditWidget.Size = new System.Drawing.Size(558, 29);
            this.BehaviorNameEditWidget.TabIndex = 10;
            // 
            // EditWidgetBehaviors
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.BehaviorNameEditWidget);
            this.Controls.Add(this.BehaviorTabs);
            this.Controls.Add(this.DeleteSelectedBehaviorsButton);
            this.Controls.Add(this.BehaviorsListView);
            this.Controls.Add(this.CreateBehaviorButton);
            this.Controls.Add(this.HintLabel);
            this.Name = "EditWidgetBehaviors";
            this.Size = new System.Drawing.Size(818, 589);
            this.BehaviorTabs.ResumeLayout(false);
            this.BehaviorSettingsTab.ResumeLayout(false);
            this.BehaviorConsiderationsTab.ResumeLayout(false);
            this.BehaviorScoringTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteSelectedBehaviorsButton;
        private System.Windows.Forms.ListView BehaviorsListView;
        private System.Windows.Forms.ColumnHeader BehaviorNameColumn;
        private System.Windows.Forms.Button CreateBehaviorButton;
        private System.Windows.Forms.TabControl BehaviorTabs;
        private System.Windows.Forms.TabPage BehaviorSettingsTab;
        private EditWidgetBehavior BehaviorEditWidget;
        private System.Windows.Forms.TabPage BehaviorConsiderationsTab;
        private EditWidgetConsideration ConsiderationEditWidget;
        private System.Windows.Forms.Button AddConsiderationButton;
        private System.Windows.Forms.ListView ConsiderationsListView;
        private System.Windows.Forms.ColumnHeader ConsiderationNameHeader;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Button DeleteConsiderationButton;
        private System.Windows.Forms.Label HintLabel;
        private EditWidgetName BehaviorNameEditWidget;
        private System.Windows.Forms.TabPage BehaviorScoringTab;
        private EditWidgetBehaviorScoring BehaviorScoringWidget;
    }
}
