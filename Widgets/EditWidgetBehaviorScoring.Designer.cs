namespace Curvature.Widgets
{
    partial class EditWidgetBehaviorScoring
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Considerations", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Bonuses", System.Windows.Forms.HorizontalAlignment.Left);
            this.BreakdownGroupBox = new System.Windows.Forms.GroupBox();
            this.FinalScoreLabel = new System.Windows.Forms.Label();
            this.ScoreListView = new System.Windows.Forms.ListView();
            this.ScoreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MomentumBonusCheckBox = new System.Windows.Forms.CheckBox();
            this.CompensationCheckBox = new System.Windows.Forms.CheckBox();
            this.InputScoreSplitter = new System.Windows.Forms.SplitContainer();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.InputFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsiderationScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoreLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BreakdownGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputScoreSplitter)).BeginInit();
            this.InputScoreSplitter.Panel1.SuspendLayout();
            this.InputScoreSplitter.Panel2.SuspendLayout();
            this.InputScoreSplitter.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.ConsiderationScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BreakdownGroupBox
            // 
            this.BreakdownGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BreakdownGroupBox.Controls.Add(this.FinalScoreLabel);
            this.BreakdownGroupBox.Controls.Add(this.ScoreListView);
            this.BreakdownGroupBox.Controls.Add(this.MomentumBonusCheckBox);
            this.BreakdownGroupBox.Controls.Add(this.CompensationCheckBox);
            this.BreakdownGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BreakdownGroupBox.Name = "BreakdownGroupBox";
            this.BreakdownGroupBox.Size = new System.Drawing.Size(297, 465);
            this.BreakdownGroupBox.TabIndex = 7;
            this.BreakdownGroupBox.TabStop = false;
            this.BreakdownGroupBox.Text = "Scoring Preview";
            // 
            // FinalScoreLabel
            // 
            this.FinalScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreLabel.Location = new System.Drawing.Point(9, 423);
            this.FinalScoreLabel.Name = "FinalScoreLabel";
            this.FinalScoreLabel.Size = new System.Drawing.Size(282, 30);
            this.FinalScoreLabel.TabIndex = 5;
            this.FinalScoreLabel.Text = "Final Score = 0.0";
            this.FinalScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreListView
            // 
            this.ScoreListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScoreColumnHeader,
            this.DescriptionColumnHeader});
            this.ScoreListView.FullRowSelect = true;
            listViewGroup1.Header = "Considerations";
            listViewGroup1.Name = "ConsiderationGroup";
            listViewGroup2.Header = "Bonuses";
            listViewGroup2.Name = "BonusGroup";
            this.ScoreListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ScoreListView.Location = new System.Drawing.Point(6, 65);
            this.ScoreListView.Name = "ScoreListView";
            this.ScoreListView.Size = new System.Drawing.Size(285, 351);
            this.ScoreListView.TabIndex = 4;
            this.ScoreListView.UseCompatibleStateImageBehavior = false;
            this.ScoreListView.View = System.Windows.Forms.View.Details;
            // 
            // ScoreColumnHeader
            // 
            this.ScoreColumnHeader.Text = "Score";
            // 
            // DescriptionColumnHeader
            // 
            this.DescriptionColumnHeader.Text = "Description";
            this.DescriptionColumnHeader.Width = 120;
            // 
            // MomentumBonusCheckBox
            // 
            this.MomentumBonusCheckBox.AutoSize = true;
            this.MomentumBonusCheckBox.Location = new System.Drawing.Point(6, 42);
            this.MomentumBonusCheckBox.Name = "MomentumBonusCheckBox";
            this.MomentumBonusCheckBox.Size = new System.Drawing.Size(204, 17);
            this.MomentumBonusCheckBox.TabIndex = 3;
            this.MomentumBonusCheckBox.Text = "Preview with momentum bonus active";
            this.MomentumBonusCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompensationCheckBox
            // 
            this.CompensationCheckBox.AutoSize = true;
            this.CompensationCheckBox.Checked = true;
            this.CompensationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompensationCheckBox.Location = new System.Drawing.Point(6, 19);
            this.CompensationCheckBox.Name = "CompensationCheckBox";
            this.CompensationCheckBox.Size = new System.Drawing.Size(192, 17);
            this.CompensationCheckBox.TabIndex = 2;
            this.CompensationCheckBox.Text = "Preview with compensation formula";
            this.CompensationCheckBox.UseVisualStyleBackColor = true;
            // 
            // InputScoreSplitter
            // 
            this.InputScoreSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputScoreSplitter.Location = new System.Drawing.Point(306, 3);
            this.InputScoreSplitter.Name = "InputScoreSplitter";
            this.InputScoreSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // InputScoreSplitter.Panel1
            // 
            this.InputScoreSplitter.Panel1.Controls.Add(this.InputGroupBox);
            // 
            // InputScoreSplitter.Panel2
            // 
            this.InputScoreSplitter.Panel2.Controls.Add(this.ConsiderationScoreGroupBox);
            this.InputScoreSplitter.Size = new System.Drawing.Size(345, 465);
            this.InputScoreSplitter.SplitterDistance = 204;
            this.InputScoreSplitter.TabIndex = 11;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.InputFlowPanel);
            this.InputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputGroupBox.Location = new System.Drawing.Point(0, 0);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(345, 204);
            this.InputGroupBox.TabIndex = 9;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Inputs";
            // 
            // InputFlowPanel
            // 
            this.InputFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFlowPanel.AutoScroll = true;
            this.InputFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InputFlowPanel.Location = new System.Drawing.Point(6, 19);
            this.InputFlowPanel.Name = "InputFlowPanel";
            this.InputFlowPanel.Size = new System.Drawing.Size(333, 179);
            this.InputFlowPanel.TabIndex = 0;
            // 
            // ConsiderationScoreGroupBox
            // 
            this.ConsiderationScoreGroupBox.Controls.Add(this.ScoreLayoutPanel);
            this.ConsiderationScoreGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsiderationScoreGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ConsiderationScoreGroupBox.Name = "ConsiderationScoreGroupBox";
            this.ConsiderationScoreGroupBox.Size = new System.Drawing.Size(345, 257);
            this.ConsiderationScoreGroupBox.TabIndex = 10;
            this.ConsiderationScoreGroupBox.TabStop = false;
            this.ConsiderationScoreGroupBox.Text = "Consideration Scores";
            // 
            // ScoreLayoutPanel
            // 
            this.ScoreLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLayoutPanel.AutoScroll = true;
            this.ScoreLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScoreLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.ScoreLayoutPanel.Name = "ScoreLayoutPanel";
            this.ScoreLayoutPanel.Size = new System.Drawing.Size(333, 238);
            this.ScoreLayoutPanel.TabIndex = 0;
            // 
            // EditWidgetBehaviorScoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.InputScoreSplitter);
            this.Controls.Add(this.BreakdownGroupBox);
            this.Name = "EditWidgetBehaviorScoring";
            this.Size = new System.Drawing.Size(654, 471);
            this.BreakdownGroupBox.ResumeLayout(false);
            this.BreakdownGroupBox.PerformLayout();
            this.InputScoreSplitter.Panel1.ResumeLayout(false);
            this.InputScoreSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputScoreSplitter)).EndInit();
            this.InputScoreSplitter.ResumeLayout(false);
            this.InputGroupBox.ResumeLayout(false);
            this.ConsiderationScoreGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BreakdownGroupBox;
        private System.Windows.Forms.Label FinalScoreLabel;
        private System.Windows.Forms.ListView ScoreListView;
        private System.Windows.Forms.ColumnHeader ScoreColumnHeader;
        private System.Windows.Forms.ColumnHeader DescriptionColumnHeader;
        private System.Windows.Forms.CheckBox MomentumBonusCheckBox;
        private System.Windows.Forms.CheckBox CompensationCheckBox;
        private System.Windows.Forms.SplitContainer InputScoreSplitter;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.FlowLayoutPanel InputFlowPanel;
        private System.Windows.Forms.GroupBox ConsiderationScoreGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ScoreLayoutPanel;
    }
}
