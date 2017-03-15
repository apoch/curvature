namespace Curvature
{
    partial class EditWidgetBehaviorSet
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
            this.BehaviorSetNameLabel = new System.Windows.Forms.Label();
            this.EnabledBehaviorsListBox = new System.Windows.Forms.CheckedListBox();
            this.InputOutputSplitContainer = new System.Windows.Forms.SplitContainer();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.InputFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.BehaviorScoresListView = new System.Windows.Forms.ListView();
            this.BehaviorNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScoreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WinningBehaviorLabel = new System.Windows.Forms.Label();
            this.WeightColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.InputOutputSplitContainer)).BeginInit();
            this.InputOutputSplitContainer.Panel1.SuspendLayout();
            this.InputOutputSplitContainer.Panel2.SuspendLayout();
            this.InputOutputSplitContainer.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BehaviorSetNameLabel
            // 
            this.BehaviorSetNameLabel.AutoSize = true;
            this.BehaviorSetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehaviorSetNameLabel.Location = new System.Drawing.Point(3, 0);
            this.BehaviorSetNameLabel.Name = "BehaviorSetNameLabel";
            this.BehaviorSetNameLabel.Size = new System.Drawing.Size(180, 20);
            this.BehaviorSetNameLabel.TabIndex = 0;
            this.BehaviorSetNameLabel.Text = "Behavior Set: (Name)";
            // 
            // EnabledBehaviorsListBox
            // 
            this.EnabledBehaviorsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnabledBehaviorsListBox.FormattingEnabled = true;
            this.EnabledBehaviorsListBox.IntegralHeight = false;
            this.EnabledBehaviorsListBox.Location = new System.Drawing.Point(7, 23);
            this.EnabledBehaviorsListBox.Name = "EnabledBehaviorsListBox";
            this.EnabledBehaviorsListBox.Size = new System.Drawing.Size(222, 229);
            this.EnabledBehaviorsListBox.TabIndex = 1;
            // 
            // InputOutputSplitContainer
            // 
            this.InputOutputSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputOutputSplitContainer.Location = new System.Drawing.Point(235, 23);
            this.InputOutputSplitContainer.Name = "InputOutputSplitContainer";
            this.InputOutputSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // InputOutputSplitContainer.Panel1
            // 
            this.InputOutputSplitContainer.Panel1.Controls.Add(this.InputGroupBox);
            // 
            // InputOutputSplitContainer.Panel2
            // 
            this.InputOutputSplitContainer.Panel2.Controls.Add(this.WinningBehaviorLabel);
            this.InputOutputSplitContainer.Panel2.Controls.Add(this.BehaviorScoresListView);
            this.InputOutputSplitContainer.Size = new System.Drawing.Size(268, 229);
            this.InputOutputSplitContainer.SplitterDistance = 89;
            this.InputOutputSplitContainer.TabIndex = 2;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputGroupBox.Controls.Add(this.InputFlowPanel);
            this.InputGroupBox.Location = new System.Drawing.Point(0, 0);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(265, 86);
            this.InputGroupBox.TabIndex = 3;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Inputs";
            // 
            // InputFlowPanel
            // 
            this.InputFlowPanel.AutoScroll = true;
            this.InputFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InputFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.InputFlowPanel.Name = "InputFlowPanel";
            this.InputFlowPanel.Size = new System.Drawing.Size(259, 67);
            this.InputFlowPanel.TabIndex = 0;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 250;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // BehaviorScoresListView
            // 
            this.BehaviorScoresListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorScoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BehaviorNameColumnHeader,
            this.WeightColumnHeader,
            this.ScoreColumnHeader});
            this.BehaviorScoresListView.Location = new System.Drawing.Point(3, 3);
            this.BehaviorScoresListView.Name = "BehaviorScoresListView";
            this.BehaviorScoresListView.Size = new System.Drawing.Size(262, 96);
            this.BehaviorScoresListView.TabIndex = 0;
            this.BehaviorScoresListView.UseCompatibleStateImageBehavior = false;
            this.BehaviorScoresListView.View = System.Windows.Forms.View.Details;
            // 
            // BehaviorNameColumnHeader
            // 
            this.BehaviorNameColumnHeader.Text = "Behavior Name";
            this.BehaviorNameColumnHeader.Width = 180;
            // 
            // ScoreColumnHeader
            // 
            this.ScoreColumnHeader.Text = "Score";
            // 
            // WinningBehaviorLabel
            // 
            this.WinningBehaviorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinningBehaviorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningBehaviorLabel.Location = new System.Drawing.Point(3, 102);
            this.WinningBehaviorLabel.Name = "WinningBehaviorLabel";
            this.WinningBehaviorLabel.Size = new System.Drawing.Size(265, 38);
            this.WinningBehaviorLabel.TabIndex = 1;
            this.WinningBehaviorLabel.Text = "Winner: (Behavior)";
            this.WinningBehaviorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightColumnHeader
            // 
            this.WeightColumnHeader.Text = "Weight";
            // 
            // EditWidgetBehaviorSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputOutputSplitContainer);
            this.Controls.Add(this.EnabledBehaviorsListBox);
            this.Controls.Add(this.BehaviorSetNameLabel);
            this.Name = "EditWidgetBehaviorSet";
            this.Size = new System.Drawing.Size(506, 256);
            this.InputOutputSplitContainer.Panel1.ResumeLayout(false);
            this.InputOutputSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputOutputSplitContainer)).EndInit();
            this.InputOutputSplitContainer.ResumeLayout(false);
            this.InputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BehaviorSetNameLabel;
        private System.Windows.Forms.CheckedListBox EnabledBehaviorsListBox;
        private System.Windows.Forms.SplitContainer InputOutputSplitContainer;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.FlowLayoutPanel InputFlowPanel;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ListView BehaviorScoresListView;
        private System.Windows.Forms.ColumnHeader BehaviorNameColumnHeader;
        private System.Windows.Forms.ColumnHeader ScoreColumnHeader;
        private System.Windows.Forms.Label WinningBehaviorLabel;
        private System.Windows.Forms.ColumnHeader WeightColumnHeader;
    }
}
