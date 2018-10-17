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
            this.InputAxisDropdown = new System.Windows.Forms.ComboBox();
            this.InputAxisLabel = new System.Windows.Forms.Label();
            this.HorizontalSplitter = new System.Windows.Forms.SplitContainer();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.WrapInputCheckBox = new System.Windows.Forms.CheckBox();
            this.ParamFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ResponseCurveGroupBox = new System.Windows.Forms.GroupBox();
            this.ResponseCurveEditor = new Curvature.EditWidgetResponseCurve();
            this.CurveWizardButton = new System.Windows.Forms.Button();
            this.NameEditWidget = new Curvature.EditWidgetName();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitter)).BeginInit();
            this.HorizontalSplitter.Panel1.SuspendLayout();
            this.HorizontalSplitter.Panel2.SuspendLayout();
            this.HorizontalSplitter.SuspendLayout();
            this.ParametersGroupBox.SuspendLayout();
            this.ResponseCurveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputAxisDropdown
            // 
            this.InputAxisDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputAxisDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputAxisDropdown.FormattingEnabled = true;
            this.InputAxisDropdown.Location = new System.Drawing.Point(43, 37);
            this.InputAxisDropdown.Name = "InputAxisDropdown";
            this.InputAxisDropdown.Size = new System.Drawing.Size(613, 21);
            this.InputAxisDropdown.TabIndex = 2;
            this.InputAxisDropdown.SelectedIndexChanged += new System.EventHandler(this.InputAxisDropdown_SelectedIndexChanged);
            // 
            // InputAxisLabel
            // 
            this.InputAxisLabel.AutoSize = true;
            this.InputAxisLabel.Location = new System.Drawing.Point(4, 40);
            this.InputAxisLabel.Name = "InputAxisLabel";
            this.InputAxisLabel.Size = new System.Drawing.Size(34, 13);
            this.InputAxisLabel.TabIndex = 1;
            this.InputAxisLabel.Text = "Input:";
            // 
            // HorizontalSplitter
            // 
            this.HorizontalSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontalSplitter.Location = new System.Drawing.Point(7, 65);
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
            this.HorizontalSplitter.Size = new System.Drawing.Size(758, 442);
            this.HorizontalSplitter.SplitterDistance = 119;
            this.HorizontalSplitter.TabIndex = 4;
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersGroupBox.Controls.Add(this.WrapInputCheckBox);
            this.ParametersGroupBox.Controls.Add(this.ParamFlowPanel);
            this.ParametersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(752, 113);
            this.ParametersGroupBox.TabIndex = 0;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // WrapInputCheckBox
            // 
            this.WrapInputCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WrapInputCheckBox.AutoSize = true;
            this.WrapInputCheckBox.Location = new System.Drawing.Point(648, 16);
            this.WrapInputCheckBox.Name = "WrapInputCheckBox";
            this.WrapInputCheckBox.Size = new System.Drawing.Size(84, 17);
            this.WrapInputCheckBox.TabIndex = 1;
            this.WrapInputCheckBox.Text = "Wrap Inputs";
            this.WrapInputCheckBox.UseVisualStyleBackColor = true;
            this.WrapInputCheckBox.CheckedChanged += new System.EventHandler(this.WrapInputCheckBox_CheckedChanged);
            // 
            // ParamFlowPanel
            // 
            this.ParamFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParamFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.ParamFlowPanel.Name = "ParamFlowPanel";
            this.ParamFlowPanel.Size = new System.Drawing.Size(643, 94);
            this.ParamFlowPanel.TabIndex = 0;
            // 
            // ResponseCurveGroupBox
            // 
            this.ResponseCurveGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCurveGroupBox.Controls.Add(this.ResponseCurveEditor);
            this.ResponseCurveGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ResponseCurveGroupBox.Name = "ResponseCurveGroupBox";
            this.ResponseCurveGroupBox.Size = new System.Drawing.Size(752, 313);
            this.ResponseCurveGroupBox.TabIndex = 0;
            this.ResponseCurveGroupBox.TabStop = false;
            this.ResponseCurveGroupBox.Text = "Response Curve";
            // 
            // ResponseCurveEditor
            // 
            this.ResponseCurveEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCurveEditor.Location = new System.Drawing.Point(6, 19);
            this.ResponseCurveEditor.Name = "ResponseCurveEditor";
            this.ResponseCurveEditor.Size = new System.Drawing.Size(740, 288);
            this.ResponseCurveEditor.TabIndex = 0;
            // 
            // CurveWizardButton
            // 
            this.CurveWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurveWizardButton.Location = new System.Drawing.Point(662, 36);
            this.CurveWizardButton.Name = "CurveWizardButton";
            this.CurveWizardButton.Size = new System.Drawing.Size(103, 23);
            this.CurveWizardButton.TabIndex = 3;
            this.CurveWizardButton.Text = "Wizard...";
            this.CurveWizardButton.UseVisualStyleBackColor = true;
            this.CurveWizardButton.Click += new System.EventHandler(this.CurveWizardButton_Click);
            // 
            // NameEditWidget
            // 
            this.NameEditWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameEditWidget.Location = new System.Drawing.Point(0, 0);
            this.NameEditWidget.Name = "NameEditWidget";
            this.NameEditWidget.Size = new System.Drawing.Size(768, 30);
            this.NameEditWidget.TabIndex = 0;
            // 
            // EditWidgetConsideration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.NameEditWidget);
            this.Controls.Add(this.CurveWizardButton);
            this.Controls.Add(this.HorizontalSplitter);
            this.Controls.Add(this.InputAxisLabel);
            this.Controls.Add(this.InputAxisDropdown);
            this.Name = "EditWidgetConsideration";
            this.Size = new System.Drawing.Size(768, 510);
            this.HorizontalSplitter.Panel1.ResumeLayout(false);
            this.HorizontalSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitter)).EndInit();
            this.HorizontalSplitter.ResumeLayout(false);
            this.ParametersGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.PerformLayout();
            this.ResponseCurveGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox InputAxisDropdown;
        private System.Windows.Forms.Label InputAxisLabel;
        private System.Windows.Forms.SplitContainer HorizontalSplitter;
        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.GroupBox ResponseCurveGroupBox;
        private EditWidgetResponseCurve ResponseCurveEditor;
        private System.Windows.Forms.FlowLayoutPanel ParamFlowPanel;
        private System.Windows.Forms.Button CurveWizardButton;
        private EditWidgetName NameEditWidget;
        private System.Windows.Forms.CheckBox WrapInputCheckBox;
    }
}
