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
            this.BehaviorOverviewTab = new System.Windows.Forms.TabPage();
            this.BehaviorConsiderationsTab = new System.Windows.Forms.TabPage();
            this.DeleteConsiderationButton = new System.Windows.Forms.Button();
            this.AddConsiderationButton = new System.Windows.Forms.Button();
            this.ConsiderationsListView = new System.Windows.Forms.ListView();
            this.ConsiderationNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BehaviorEditWidget = new Curvature.EditWidgetBehavior();
            this.ConsiderationEditWidget = new Curvature.EditWidgetConsideration();
            this.HintLabel = new System.Windows.Forms.Label();
            this.BehaviorTabs.SuspendLayout();
            this.BehaviorOverviewTab.SuspendLayout();
            this.BehaviorConsiderationsTab.SuspendLayout();
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
            this.DeleteSelectedBehaviorsButton.TabIndex = 7;
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
            this.BehaviorsListView.TabIndex = 5;
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
            this.CreateBehaviorButton.TabIndex = 6;
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
            this.BehaviorTabs.Controls.Add(this.BehaviorOverviewTab);
            this.BehaviorTabs.Controls.Add(this.BehaviorConsiderationsTab);
            this.BehaviorTabs.Location = new System.Drawing.Point(253, 3);
            this.BehaviorTabs.Name = "BehaviorTabs";
            this.BehaviorTabs.SelectedIndex = 0;
            this.BehaviorTabs.Size = new System.Drawing.Size(562, 583);
            this.BehaviorTabs.TabIndex = 8;
            this.BehaviorTabs.Visible = false;
            // 
            // BehaviorOverviewTab
            // 
            this.BehaviorOverviewTab.Controls.Add(this.BehaviorEditWidget);
            this.BehaviorOverviewTab.Location = new System.Drawing.Point(4, 22);
            this.BehaviorOverviewTab.Name = "BehaviorOverviewTab";
            this.BehaviorOverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.BehaviorOverviewTab.Size = new System.Drawing.Size(554, 557);
            this.BehaviorOverviewTab.TabIndex = 0;
            this.BehaviorOverviewTab.Text = "Scoring Overview";
            this.BehaviorOverviewTab.UseVisualStyleBackColor = true;
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
            this.BehaviorConsiderationsTab.Size = new System.Drawing.Size(554, 557);
            this.BehaviorConsiderationsTab.TabIndex = 1;
            this.BehaviorConsiderationsTab.Text = "Edit Considerations";
            this.BehaviorConsiderationsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteConsiderationButton
            // 
            this.DeleteConsiderationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteConsiderationButton.ImageIndex = 1;
            this.DeleteConsiderationButton.ImageList = this.IconImageList;
            this.DeleteConsiderationButton.Location = new System.Drawing.Point(124, 529);
            this.DeleteConsiderationButton.Name = "DeleteConsiderationButton";
            this.DeleteConsiderationButton.Size = new System.Drawing.Size(102, 25);
            this.DeleteConsiderationButton.TabIndex = 3;
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
            this.AddConsiderationButton.Location = new System.Drawing.Point(6, 529);
            this.AddConsiderationButton.Name = "AddConsiderationButton";
            this.AddConsiderationButton.Size = new System.Drawing.Size(112, 25);
            this.AddConsiderationButton.TabIndex = 1;
            this.AddConsiderationButton.Text = "Add...";
            this.AddConsiderationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddConsiderationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.ConsiderationsListView.Location = new System.Drawing.Point(6, 6);
            this.ConsiderationsListView.Name = "ConsiderationsListView";
            this.ConsiderationsListView.Size = new System.Drawing.Size(220, 517);
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
            // BehaviorEditWidget
            // 
            this.BehaviorEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorEditWidget.Location = new System.Drawing.Point(6, 6);
            this.BehaviorEditWidget.Name = "BehaviorEditWidget";
            this.BehaviorEditWidget.Size = new System.Drawing.Size(542, 545);
            this.BehaviorEditWidget.TabIndex = 3;
            // 
            // ConsiderationEditWidget
            // 
            this.ConsiderationEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsiderationEditWidget.Location = new System.Drawing.Point(232, 6);
            this.ConsiderationEditWidget.Name = "ConsiderationEditWidget";
            this.ConsiderationEditWidget.Size = new System.Drawing.Size(316, 545);
            this.ConsiderationEditWidget.TabIndex = 2;
            this.ConsiderationEditWidget.Visible = false;
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintLabel.Location = new System.Drawing.Point(253, 3);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(558, 583);
            this.HintLabel.TabIndex = 9;
            this.HintLabel.Text = "Select or create a behavior to begin editing.";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditWidgetBehaviors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BehaviorTabs);
            this.Controls.Add(this.DeleteSelectedBehaviorsButton);
            this.Controls.Add(this.BehaviorsListView);
            this.Controls.Add(this.CreateBehaviorButton);
            this.Controls.Add(this.HintLabel);
            this.Name = "EditWidgetBehaviors";
            this.Size = new System.Drawing.Size(818, 589);
            this.BehaviorTabs.ResumeLayout(false);
            this.BehaviorOverviewTab.ResumeLayout(false);
            this.BehaviorConsiderationsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteSelectedBehaviorsButton;
        private System.Windows.Forms.ListView BehaviorsListView;
        private System.Windows.Forms.ColumnHeader BehaviorNameColumn;
        private System.Windows.Forms.Button CreateBehaviorButton;
        private System.Windows.Forms.TabControl BehaviorTabs;
        private System.Windows.Forms.TabPage BehaviorOverviewTab;
        private EditWidgetBehavior BehaviorEditWidget;
        private System.Windows.Forms.TabPage BehaviorConsiderationsTab;
        private EditWidgetConsideration ConsiderationEditWidget;
        private System.Windows.Forms.Button AddConsiderationButton;
        private System.Windows.Forms.ListView ConsiderationsListView;
        private System.Windows.Forms.ColumnHeader ConsiderationNameHeader;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Button DeleteConsiderationButton;
        private System.Windows.Forms.Label HintLabel;
    }
}
