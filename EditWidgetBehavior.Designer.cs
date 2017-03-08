namespace Curvature
{
    partial class EditWidgetBehavior
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
            this.BehaviorNameLabel = new System.Windows.Forms.Label();
            this.BehaviorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.InputFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsiderationScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoreLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorSplitContainer)).BeginInit();
            this.BehaviorSplitContainer.Panel1.SuspendLayout();
            this.BehaviorSplitContainer.Panel2.SuspendLayout();
            this.BehaviorSplitContainer.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.ConsiderationScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BehaviorNameLabel
            // 
            this.BehaviorNameLabel.AutoSize = true;
            this.BehaviorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehaviorNameLabel.Location = new System.Drawing.Point(3, 0);
            this.BehaviorNameLabel.Name = "BehaviorNameLabel";
            this.BehaviorNameLabel.Size = new System.Drawing.Size(147, 20);
            this.BehaviorNameLabel.TabIndex = 0;
            this.BehaviorNameLabel.Text = "Behavior: (Name)";
            // 
            // BehaviorSplitContainer
            // 
            this.BehaviorSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorSplitContainer.Location = new System.Drawing.Point(3, 23);
            this.BehaviorSplitContainer.Name = "BehaviorSplitContainer";
            this.BehaviorSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BehaviorSplitContainer.Panel1
            // 
            this.BehaviorSplitContainer.Panel1.Controls.Add(this.InputGroupBox);
            // 
            // BehaviorSplitContainer.Panel2
            // 
            this.BehaviorSplitContainer.Panel2.Controls.Add(this.ConsiderationScoreGroupBox);
            this.BehaviorSplitContainer.Size = new System.Drawing.Size(600, 392);
            this.BehaviorSplitContainer.SplitterDistance = 174;
            this.BehaviorSplitContainer.TabIndex = 2;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputGroupBox.Controls.Add(this.InputFlowPanel);
            this.InputGroupBox.Location = new System.Drawing.Point(4, 3);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(593, 168);
            this.InputGroupBox.TabIndex = 2;
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
            this.InputFlowPanel.Size = new System.Drawing.Size(581, 143);
            this.InputFlowPanel.TabIndex = 0;
            // 
            // ConsiderationScoreGroupBox
            // 
            this.ConsiderationScoreGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsiderationScoreGroupBox.Controls.Add(this.ScoreLayoutPanel);
            this.ConsiderationScoreGroupBox.Location = new System.Drawing.Point(4, 3);
            this.ConsiderationScoreGroupBox.Name = "ConsiderationScoreGroupBox";
            this.ConsiderationScoreGroupBox.Size = new System.Drawing.Size(593, 208);
            this.ConsiderationScoreGroupBox.TabIndex = 0;
            this.ConsiderationScoreGroupBox.TabStop = false;
            this.ConsiderationScoreGroupBox.Text = "Consideration Scores";
            // 
            // ScoreLayoutPanel
            // 
            this.ScoreLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScoreLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.ScoreLayoutPanel.Name = "ScoreLayoutPanel";
            this.ScoreLayoutPanel.Size = new System.Drawing.Size(581, 183);
            this.ScoreLayoutPanel.TabIndex = 0;
            // 
            // EditWidgetBehavior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BehaviorSplitContainer);
            this.Controls.Add(this.BehaviorNameLabel);
            this.Name = "EditWidgetBehavior";
            this.Size = new System.Drawing.Size(606, 418);
            this.BehaviorSplitContainer.Panel1.ResumeLayout(false);
            this.BehaviorSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorSplitContainer)).EndInit();
            this.BehaviorSplitContainer.ResumeLayout(false);
            this.InputGroupBox.ResumeLayout(false);
            this.ConsiderationScoreGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BehaviorNameLabel;
        private System.Windows.Forms.SplitContainer BehaviorSplitContainer;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.FlowLayoutPanel InputFlowPanel;
        private System.Windows.Forms.GroupBox ConsiderationScoreGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ScoreLayoutPanel;
    }
}
