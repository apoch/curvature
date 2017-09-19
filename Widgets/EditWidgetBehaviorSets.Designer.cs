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
            this.DeleteBehaviorSetButton = new System.Windows.Forms.Button();
            this.AddBehaviorSetButton = new System.Windows.Forms.Button();
            this.BehaviorSetsListView = new System.Windows.Forms.ListView();
            this.BehaviorSetNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BehaviorSetEditWidget = new Curvature.EditWidgetBehaviorSet();
            this.SuspendLayout();
            // 
            // DeleteBehaviorSetButton
            // 
            this.DeleteBehaviorSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteBehaviorSetButton.Location = new System.Drawing.Point(3, 395);
            this.DeleteBehaviorSetButton.Name = "DeleteBehaviorSetButton";
            this.DeleteBehaviorSetButton.Size = new System.Drawing.Size(244, 23);
            this.DeleteBehaviorSetButton.TabIndex = 9;
            this.DeleteBehaviorSetButton.Text = "Delete Selection";
            this.DeleteBehaviorSetButton.UseVisualStyleBackColor = true;
            this.DeleteBehaviorSetButton.Click += new System.EventHandler(this.DeleteBehaviorSetButton_Click);
            // 
            // AddBehaviorSetButton
            // 
            this.AddBehaviorSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBehaviorSetButton.Location = new System.Drawing.Point(3, 366);
            this.AddBehaviorSetButton.Name = "AddBehaviorSetButton";
            this.AddBehaviorSetButton.Size = new System.Drawing.Size(244, 23);
            this.AddBehaviorSetButton.TabIndex = 8;
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
            this.BehaviorSetsListView.Size = new System.Drawing.Size(244, 357);
            this.BehaviorSetsListView.TabIndex = 6;
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
            this.BehaviorSetEditWidget.TabIndex = 7;
            this.BehaviorSetEditWidget.Visible = false;
            // 
            // EditWidgetBehaviorSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBehaviorSetButton);
            this.Controls.Add(this.AddBehaviorSetButton);
            this.Controls.Add(this.BehaviorSetEditWidget);
            this.Controls.Add(this.BehaviorSetsListView);
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
    }
}
