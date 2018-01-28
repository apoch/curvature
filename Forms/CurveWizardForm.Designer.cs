namespace Curvature
{
    partial class CurveWizardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurveWizardForm));
            this.WizardTabs = new System.Windows.Forms.TabControl();
            this.GettingStartedTab = new System.Windows.Forms.TabPage();
            this.WizardDescriptionLabel = new System.Windows.Forms.Label();
            this.WizardTitleLabel = new System.Windows.Forms.Label();
            this.SelectInputTab = new System.Windows.Forms.TabPage();
            this.InputDescriptionLabel = new System.Windows.Forms.Label();
            this.InputComboBox = new System.Windows.Forms.ComboBox();
            this.ConfigureParametersTab = new System.Windows.Forms.TabPage();
            this.ParameterHintSpecificsLabel = new System.Windows.Forms.Label();
            this.ParametersHintLabel = new System.Windows.Forms.Label();
            this.ParamFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ResponseCurveTab = new System.Windows.Forms.TabPage();
            this.ResponseCurveDescriptionLabel = new System.Windows.Forms.Label();
            this.ResponseCurveEditor = new Curvature.EditWidgetResponseCurve();
            this.NameConsiderationTab = new System.Windows.Forms.TabPage();
            this.ConsiderationNameEditBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelWizardButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.NameHintLabel = new System.Windows.Forms.Label();
            this.NamingWikiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.WizardTabs.SuspendLayout();
            this.GettingStartedTab.SuspendLayout();
            this.SelectInputTab.SuspendLayout();
            this.ConfigureParametersTab.SuspendLayout();
            this.ResponseCurveTab.SuspendLayout();
            this.NameConsiderationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // WizardTabs
            // 
            this.WizardTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardTabs.Controls.Add(this.GettingStartedTab);
            this.WizardTabs.Controls.Add(this.SelectInputTab);
            this.WizardTabs.Controls.Add(this.ConfigureParametersTab);
            this.WizardTabs.Controls.Add(this.ResponseCurveTab);
            this.WizardTabs.Controls.Add(this.NameConsiderationTab);
            this.WizardTabs.Location = new System.Drawing.Point(12, 12);
            this.WizardTabs.Name = "WizardTabs";
            this.WizardTabs.SelectedIndex = 0;
            this.WizardTabs.Size = new System.Drawing.Size(565, 304);
            this.WizardTabs.TabIndex = 0;
            // 
            // GettingStartedTab
            // 
            this.GettingStartedTab.Controls.Add(this.WizardDescriptionLabel);
            this.GettingStartedTab.Controls.Add(this.WizardTitleLabel);
            this.GettingStartedTab.Location = new System.Drawing.Point(4, 22);
            this.GettingStartedTab.Name = "GettingStartedTab";
            this.GettingStartedTab.Size = new System.Drawing.Size(557, 278);
            this.GettingStartedTab.TabIndex = 3;
            this.GettingStartedTab.Text = "Getting Started";
            this.GettingStartedTab.UseVisualStyleBackColor = true;
            // 
            // WizardDescriptionLabel
            // 
            this.WizardDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WizardDescriptionLabel.Location = new System.Drawing.Point(3, 30);
            this.WizardDescriptionLabel.Name = "WizardDescriptionLabel";
            this.WizardDescriptionLabel.Size = new System.Drawing.Size(551, 248);
            this.WizardDescriptionLabel.TabIndex = 1;
            this.WizardDescriptionLabel.Text = resources.GetString("WizardDescriptionLabel.Text");
            // 
            // WizardTitleLabel
            // 
            this.WizardTitleLabel.AutoSize = true;
            this.WizardTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizardTitleLabel.Location = new System.Drawing.Point(3, 3);
            this.WizardTitleLabel.Name = "WizardTitleLabel";
            this.WizardTitleLabel.Size = new System.Drawing.Size(275, 16);
            this.WizardTitleLabel.TabIndex = 0;
            this.WizardTitleLabel.Text = "Consideration Response Curve Wizard";
            // 
            // SelectInputTab
            // 
            this.SelectInputTab.Controls.Add(this.InputDescriptionLabel);
            this.SelectInputTab.Controls.Add(this.InputComboBox);
            this.SelectInputTab.Location = new System.Drawing.Point(4, 22);
            this.SelectInputTab.Name = "SelectInputTab";
            this.SelectInputTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectInputTab.Size = new System.Drawing.Size(557, 278);
            this.SelectInputTab.TabIndex = 0;
            this.SelectInputTab.Text = "Select Input";
            this.SelectInputTab.UseVisualStyleBackColor = true;
            // 
            // InputDescriptionLabel
            // 
            this.InputDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputDescriptionLabel.Location = new System.Drawing.Point(6, 3);
            this.InputDescriptionLabel.Name = "InputDescriptionLabel";
            this.InputDescriptionLabel.Size = new System.Drawing.Size(545, 136);
            this.InputDescriptionLabel.TabIndex = 1;
            this.InputDescriptionLabel.Text = resources.GetString("InputDescriptionLabel.Text");
            // 
            // InputComboBox
            // 
            this.InputComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputComboBox.FormattingEnabled = true;
            this.InputComboBox.Location = new System.Drawing.Point(6, 158);
            this.InputComboBox.Name = "InputComboBox";
            this.InputComboBox.Size = new System.Drawing.Size(545, 21);
            this.InputComboBox.TabIndex = 0;
            this.InputComboBox.SelectedIndexChanged += new System.EventHandler(this.InputComboBox_SelectedIndexChanged);
            // 
            // ConfigureParametersTab
            // 
            this.ConfigureParametersTab.Controls.Add(this.ParameterHintSpecificsLabel);
            this.ConfigureParametersTab.Controls.Add(this.ParametersHintLabel);
            this.ConfigureParametersTab.Controls.Add(this.ParamFlowPanel);
            this.ConfigureParametersTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigureParametersTab.Name = "ConfigureParametersTab";
            this.ConfigureParametersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigureParametersTab.Size = new System.Drawing.Size(557, 278);
            this.ConfigureParametersTab.TabIndex = 1;
            this.ConfigureParametersTab.Text = "Configure Parameters";
            this.ConfigureParametersTab.UseVisualStyleBackColor = true;
            // 
            // ParameterHintSpecificsLabel
            // 
            this.ParameterHintSpecificsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterHintSpecificsLabel.Location = new System.Drawing.Point(3, 38);
            this.ParameterHintSpecificsLabel.Name = "ParameterHintSpecificsLabel";
            this.ParameterHintSpecificsLabel.Size = new System.Drawing.Size(551, 40);
            this.ParameterHintSpecificsLabel.TabIndex = 3;
            this.ParameterHintSpecificsLabel.Text = "Select an input on the previous tab to see what its parameters do.";
            // 
            // ParametersHintLabel
            // 
            this.ParametersHintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersHintLabel.Location = new System.Drawing.Point(3, 3);
            this.ParametersHintLabel.Name = "ParametersHintLabel";
            this.ParametersHintLabel.Size = new System.Drawing.Size(551, 35);
            this.ParametersHintLabel.TabIndex = 1;
            this.ParametersHintLabel.Text = "Some inputs can be parameterized, allowing a specific consideration to control th" +
    "e values at which the input is considered 0 or 1.";
            // 
            // ParamFlowPanel
            // 
            this.ParamFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParamFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ParamFlowPanel.Location = new System.Drawing.Point(3, 81);
            this.ParamFlowPanel.Name = "ParamFlowPanel";
            this.ParamFlowPanel.Size = new System.Drawing.Size(551, 156);
            this.ParamFlowPanel.TabIndex = 0;
            // 
            // ResponseCurveTab
            // 
            this.ResponseCurveTab.Controls.Add(this.ResponseCurveDescriptionLabel);
            this.ResponseCurveTab.Controls.Add(this.ResponseCurveEditor);
            this.ResponseCurveTab.Location = new System.Drawing.Point(4, 22);
            this.ResponseCurveTab.Name = "ResponseCurveTab";
            this.ResponseCurveTab.Size = new System.Drawing.Size(557, 278);
            this.ResponseCurveTab.TabIndex = 2;
            this.ResponseCurveTab.Text = "Apply Response Curve";
            this.ResponseCurveTab.UseVisualStyleBackColor = true;
            // 
            // ResponseCurveDescriptionLabel
            // 
            this.ResponseCurveDescriptionLabel.Location = new System.Drawing.Point(3, 3);
            this.ResponseCurveDescriptionLabel.Name = "ResponseCurveDescriptionLabel";
            this.ResponseCurveDescriptionLabel.Size = new System.Drawing.Size(212, 230);
            this.ResponseCurveDescriptionLabel.TabIndex = 1;
            this.ResponseCurveDescriptionLabel.Text = resources.GetString("ResponseCurveDescriptionLabel.Text");
            // 
            // ResponseCurveEditor
            // 
            this.ResponseCurveEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCurveEditor.Location = new System.Drawing.Point(221, 3);
            this.ResponseCurveEditor.Name = "ResponseCurveEditor";
            this.ResponseCurveEditor.Size = new System.Drawing.Size(335, 230);
            this.ResponseCurveEditor.TabIndex = 0;
            // 
            // NameConsiderationTab
            // 
            this.NameConsiderationTab.Controls.Add(this.NamingWikiLinkLabel);
            this.NameConsiderationTab.Controls.Add(this.NameHintLabel);
            this.NameConsiderationTab.Controls.Add(this.ConsiderationNameEditBox);
            this.NameConsiderationTab.Controls.Add(this.NameLabel);
            this.NameConsiderationTab.Location = new System.Drawing.Point(4, 22);
            this.NameConsiderationTab.Name = "NameConsiderationTab";
            this.NameConsiderationTab.Size = new System.Drawing.Size(557, 278);
            this.NameConsiderationTab.TabIndex = 4;
            this.NameConsiderationTab.Text = "Name Consideration";
            this.NameConsiderationTab.UseVisualStyleBackColor = true;
            // 
            // ConsiderationNameEditBox
            // 
            this.ConsiderationNameEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsiderationNameEditBox.Location = new System.Drawing.Point(3, 145);
            this.ConsiderationNameEditBox.Name = "ConsiderationNameEditBox";
            this.ConsiderationNameEditBox.Size = new System.Drawing.Size(551, 20);
            this.ConsiderationNameEditBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Location = new System.Drawing.Point(3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(551, 70);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = resources.GetString("NameLabel.Text");
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(415, 322);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(76, 30);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelWizardButton
            // 
            this.CancelWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelWizardButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelWizardButton.Location = new System.Drawing.Point(497, 322);
            this.CancelWizardButton.Name = "CancelWizardButton";
            this.CancelWizardButton.Size = new System.Drawing.Size(76, 30);
            this.CancelWizardButton.TabIndex = 2;
            this.CancelWizardButton.Text = "Cancel";
            this.CancelWizardButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(237, 277);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(115, 31);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NameHintLabel
            // 
            this.NameHintLabel.AutoSize = true;
            this.NameHintLabel.Location = new System.Drawing.Point(3, 129);
            this.NameHintLabel.Name = "NameHintLabel";
            this.NameHintLabel.Size = new System.Drawing.Size(38, 13);
            this.NameHintLabel.TabIndex = 2;
            this.NameHintLabel.Text = "Name:";
            // 
            // NamingWikiLinkLabel
            // 
            this.NamingWikiLinkLabel.AutoSize = true;
            this.NamingWikiLinkLabel.Location = new System.Drawing.Point(3, 93);
            this.NamingWikiLinkLabel.Name = "NamingWikiLinkLabel";
            this.NamingWikiLinkLabel.Size = new System.Drawing.Size(291, 13);
            this.NamingWikiLinkLabel.TabIndex = 3;
            this.NamingWikiLinkLabel.TabStop = true;
            this.NamingWikiLinkLabel.Text = "View the Consideration Naming Guide on the Curvature Wiki";
            this.NamingWikiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NamingWikiLinkLabel_LinkClicked);
            // 
            // CurveWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 365);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelWizardButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.WizardTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CurveWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curvature - Curve Wizard";
            this.WizardTabs.ResumeLayout(false);
            this.GettingStartedTab.ResumeLayout(false);
            this.GettingStartedTab.PerformLayout();
            this.SelectInputTab.ResumeLayout(false);
            this.ConfigureParametersTab.ResumeLayout(false);
            this.ResponseCurveTab.ResumeLayout(false);
            this.NameConsiderationTab.ResumeLayout(false);
            this.NameConsiderationTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl WizardTabs;
        private System.Windows.Forms.TabPage SelectInputTab;
        private System.Windows.Forms.TabPage ConfigureParametersTab;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelWizardButton;
        private System.Windows.Forms.TabPage ResponseCurveTab;
        private System.Windows.Forms.TabPage GettingStartedTab;
        private System.Windows.Forms.Label WizardTitleLabel;
        private System.Windows.Forms.Label WizardDescriptionLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox InputComboBox;
        private System.Windows.Forms.Label InputDescriptionLabel;
        private EditWidgetResponseCurve ResponseCurveEditor;
        private System.Windows.Forms.TabPage NameConsiderationTab;
        private System.Windows.Forms.Label ResponseCurveDescriptionLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ConsiderationNameEditBox;
        private System.Windows.Forms.FlowLayoutPanel ParamFlowPanel;
        private System.Windows.Forms.Label ParametersHintLabel;
        private System.Windows.Forms.Label ParameterHintSpecificsLabel;
        private System.Windows.Forms.Label NameHintLabel;
        private System.Windows.Forms.LinkLabel NamingWikiLinkLabel;
    }
}