namespace Curvature.Widgets
{
    partial class EditWidgetBehaviorSets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetBehaviorSets));
            this.DeleteBehaviorSetButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.AddBehaviorSetButton = new System.Windows.Forms.Button();
            this.BehaviorSetsListView = new System.Windows.Forms.ListView();
            this.BehaviorSetNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BehaviorSetEditWidget = new Curvature.EditWidgetBehaviorSet();
            this.HintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteBehaviorSetButton
            // 
            this.DeleteBehaviorSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteBehaviorSetButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteBehaviorSetButton.ImageIndex = 1;
            this.DeleteBehaviorSetButton.ImageList = this.IconImageList;
            this.DeleteBehaviorSetButton.Location = new System.Drawing.Point(128, 366);
            this.DeleteBehaviorSetButton.Name = "DeleteBehaviorSetButton";
            this.DeleteBehaviorSetButton.Size = new System.Drawing.Size(119, 52);
            this.DeleteBehaviorSetButton.TabIndex = 2;
            this.DeleteBehaviorSetButton.Text = "Delete Selection";
            this.DeleteBehaviorSetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteBehaviorSetButton.UseVisualStyleBackColor = true;
            this.DeleteBehaviorSetButton.Click += new System.EventHandler(this.DeleteBehaviorSetButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            this.IconImageList.Images.SetKeyName(1, "DeleteItemIcon.png");
            // 
            // AddBehaviorSetButton
            // 
            this.AddBehaviorSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBehaviorSetButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBehaviorSetButton.ImageIndex = 0;
            this.AddBehaviorSetButton.ImageList = this.IconImageList;
            this.AddBehaviorSetButton.Location = new System.Drawing.Point(3, 366);
            this.AddBehaviorSetButton.Name = "AddBehaviorSetButton";
            this.AddBehaviorSetButton.Size = new System.Drawing.Size(119, 52);
            this.AddBehaviorSetButton.TabIndex = 1;
            this.AddBehaviorSetButton.Text = "Create Behavior Set";
            this.AddBehaviorSetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.BehaviorSetsListView.Size = new System.Drawing.Size(244, 357);
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
            // BehaviorSetEditWidget
            // 
            this.BehaviorSetEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorSetEditWidget.Location = new System.Drawing.Point(253, 3);
            this.BehaviorSetEditWidget.Name = "BehaviorSetEditWidget";
            this.BehaviorSetEditWidget.Size = new System.Drawing.Size(554, 415);
            this.BehaviorSetEditWidget.TabIndex = 3;
            this.BehaviorSetEditWidget.Visible = false;
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.Location = new System.Drawing.Point(253, 3);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(554, 415);
            this.HintLabel.TabIndex = 4;
            this.HintLabel.Text = "Select or create a behavior set to begin editing.";
            this.HintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditWidgetBehaviorSets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.DeleteBehaviorSetButton);
            this.Controls.Add(this.AddBehaviorSetButton);
            this.Controls.Add(this.BehaviorSetEditWidget);
            this.Controls.Add(this.BehaviorSetsListView);
            this.Controls.Add(this.HintLabel);
            this.Name = "EditWidgetBehaviorSets";
            this.Size = new System.Drawing.Size(810, 421);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteBehaviorSetButton;
        private System.Windows.Forms.Button AddBehaviorSetButton;
        private EditWidgetBehaviorSet BehaviorSetEditWidget;
        private System.Windows.Forms.ListView BehaviorSetsListView;
        private System.Windows.Forms.ColumnHeader BehaviorSetNameColumn;
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.Label HintLabel;
    }
}
