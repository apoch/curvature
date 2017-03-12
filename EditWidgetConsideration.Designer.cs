namespace Curvature
{
    partial class EditWidgetConsideration
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
            this.ConsiderationNameLabel = new System.Windows.Forms.Label();
            this.InputAxisDropdown = new System.Windows.Forms.ComboBox();
            this.InputAxisLabel = new System.Windows.Forms.Label();
            this.HorizontalSplitter = new System.Windows.Forms.SplitContainer();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.ResponseCurveGroupBox = new System.Windows.Forms.GroupBox();
            this.ParamFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CurveWizardButton = new System.Windows.Forms.Button();
            this.ResponseCurveEditor = new Curvature.EditWidgetResponseCurve();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitter)).BeginInit();
            this.HorizontalSplitter.Panel1.SuspendLayout();
            this.HorizontalSplitter.Panel2.SuspendLayout();
            this.HorizontalSplitter.SuspendLayout();
            this.ParametersGroupBox.SuspendLayout();
            this.ResponseCurveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsiderationNameLabel
            // 
            this.ConsiderationNameLabel.AutoSize = true;
            this.ConsiderationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsiderationNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ConsiderationNameLabel.Name = "ConsiderationNameLabel";
            this.ConsiderationNameLabel.Size = new System.Drawing.Size(188, 20);
            this.ConsiderationNameLabel.TabIndex = 0;
            this.ConsiderationNameLabel.Text = "Consideration: (Name)";
            // 
            // InputAxisDropdown
            // 
            this.InputAxisDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAxisDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputAxisDropdown.FormattingEnabled = true;
            this.InputAxisDropdown.Location = new System.Drawing.Point(43, 23);
            this.InputAxisDropdown.Name = "InputAxisDropdown";
            this.InputAxisDropdown.Size = new System.Drawing.Size(613, 21);
            this.InputAxisDropdown.TabIndex = 1;
            // 
            // InputAxisLabel
            // 
            this.InputAxisLabel.AutoSize = true;
            this.InputAxisLabel.Location = new System.Drawing.Point(4, 26);
            this.InputAxisLabel.Name = "InputAxisLabel";
            this.InputAxisLabel.Size = new System.Drawing.Size(34, 13);
            this.InputAxisLabel.TabIndex = 2;
            this.InputAxisLabel.Text = "Input:";
            // 
            // HorizontalSplitter
            // 
            this.HorizontalSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontalSplitter.Location = new System.Drawing.Point(7, 50);
            this.HorizontalSplitter.Name = "HorizontalSplitter";
            this.HorizontalSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalSplitter.Panel1
            // 
            this.HorizontalSplitter.Panel1.Controls.Add(this.ParametersGroupBox);
            // 
            // HorizontalSplitter.Panel2
            // 
            this.HorizontalSplitter.Panel2.Controls.Add(this.ResponseCurveGroupBox);
            this.HorizontalSplitter.Size = new System.Drawing.Size(758, 361);
            this.HorizontalSplitter.SplitterDistance = 180;
            this.HorizontalSplitter.TabIndex = 4;
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersGroupBox.Controls.Add(this.ParamFlowPanel);
            this.ParametersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(752, 174);
            this.ParametersGroupBox.TabIndex = 4;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // ResponseCurveGroupBox
            // 
            this.ResponseCurveGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCurveGroupBox.Controls.Add(this.ResponseCurveEditor);
            this.ResponseCurveGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ResponseCurveGroupBox.Name = "ResponseCurveGroupBox";
            this.ResponseCurveGroupBox.Size = new System.Drawing.Size(752, 171);
            this.ResponseCurveGroupBox.TabIndex = 0;
            this.ResponseCurveGroupBox.TabStop = false;
            this.ResponseCurveGroupBox.Text = "Response Curve";
            // 
            // ParamFlowPanel
            // 
            this.ParamFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParamFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.ParamFlowPanel.Name = "ParamFlowPanel";
            this.ParamFlowPanel.Size = new System.Drawing.Size(746, 155);
            this.ParamFlowPanel.TabIndex = 0;
            // 
            // CurveWizardButton
            // 
            this.CurveWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurveWizardButton.Location = new System.Drawing.Point(662, 22);
            this.CurveWizardButton.Name = "CurveWizardButton";
            this.CurveWizardButton.Size = new System.Drawing.Size(103, 23);
            this.CurveWizardButton.TabIndex = 5;
            this.CurveWizardButton.Text = "Wizard...";
            this.CurveWizardButton.UseVisualStyleBackColor = true;
            this.CurveWizardButton.Click += new System.EventHandler(this.CurveWizardButton_Click);
            // 
            // ResponseCurveEditor
            // 
            this.ResponseCurveEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCurveEditor.Location = new System.Drawing.Point(6, 19);
            this.ResponseCurveEditor.Name = "ResponseCurveEditor";
            this.ResponseCurveEditor.Size = new System.Drawing.Size(740, 146);
            this.ResponseCurveEditor.TabIndex = 0;
            // 
            // EditWidgetConsideration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurveWizardButton);
            this.Controls.Add(this.HorizontalSplitter);
            this.Controls.Add(this.InputAxisLabel);
            this.Controls.Add(this.InputAxisDropdown);
            this.Controls.Add(this.ConsiderationNameLabel);
            this.Name = "EditWidgetConsideration";
            this.Size = new System.Drawing.Size(768, 414);
            this.HorizontalSplitter.Panel1.ResumeLayout(false);
            this.HorizontalSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitter)).EndInit();
            this.HorizontalSplitter.ResumeLayout(false);
            this.ParametersGroupBox.ResumeLayout(false);
            this.ResponseCurveGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsiderationNameLabel;
        private System.Windows.Forms.ComboBox InputAxisDropdown;
        private System.Windows.Forms.Label InputAxisLabel;
        private System.Windows.Forms.SplitContainer HorizontalSplitter;
        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.GroupBox ResponseCurveGroupBox;
        private EditWidgetResponseCurve ResponseCurveEditor;
        private System.Windows.Forms.FlowLayoutPanel ParamFlowPanel;
        private System.Windows.Forms.Button CurveWizardButton;
    }
}
