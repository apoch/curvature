namespace Curvature
{
    partial class EditWidgetInputAxis
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
            this.ParameterGroupBox = new System.Windows.Forms.GroupBox();
            this.ParamFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.DataSourceComboBox = new System.Windows.Forms.ComboBox();
            this.InputTypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameEditWidget = new Curvature.EditWidgetName();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ParameterGroupBox.SuspendLayout();
            this.PropertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParameterGroupBox
            // 
            this.ParameterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterGroupBox.AutoSize = true;
            this.ParameterGroupBox.Controls.Add(this.ParamFlowPanel);
            this.ParameterGroupBox.Location = new System.Drawing.Point(7, 91);
            this.ParameterGroupBox.MinimumSize = new System.Drawing.Size(475, 50);
            this.ParameterGroupBox.Name = "ParameterGroupBox";
            this.ParameterGroupBox.Size = new System.Drawing.Size(475, 50);
            this.ParameterGroupBox.TabIndex = 1;
            this.ParameterGroupBox.TabStop = false;
            this.ParameterGroupBox.Text = "Parameters";
            // 
            // ParamFlowPanel
            // 
            this.ParamFlowPanel.AutoSize = true;
            this.ParamFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ParamFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ParamFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.ParamFlowPanel.Name = "ParamFlowPanel";
            this.ParamFlowPanel.Size = new System.Drawing.Size(469, 31);
            this.ParamFlowPanel.TabIndex = 0;
            this.ParamFlowPanel.WrapContents = false;
            // 
            // PropertiesGroupBox
            // 
            this.PropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertiesGroupBox.Controls.Add(this.DataSourceComboBox);
            this.PropertiesGroupBox.Controls.Add(this.InputTypeComboBox);
            this.PropertiesGroupBox.Location = new System.Drawing.Point(7, 36);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Size = new System.Drawing.Size(475, 49);
            this.PropertiesGroupBox.TabIndex = 2;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Knowledge";
            // 
            // DataSourceComboBox
            // 
            this.DataSourceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataSourceComboBox.FormattingEnabled = true;
            this.DataSourceComboBox.Location = new System.Drawing.Point(260, 19);
            this.DataSourceComboBox.Name = "DataSourceComboBox";
            this.DataSourceComboBox.Size = new System.Drawing.Size(209, 21);
            this.DataSourceComboBox.Sorted = true;
            this.DataSourceComboBox.TabIndex = 1;
            this.DataSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.DataSourceComboBox_SelectedIndexChanged);
            // 
            // InputTypeComboBox
            // 
            this.InputTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputTypeComboBox.FormattingEnabled = true;
            this.InputTypeComboBox.Items.AddRange(new object[] {
            "Reads a property from myself",
            "Reads a property of the target",
            "Computes a value using a known equation"});
            this.InputTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.InputTypeComboBox.Name = "InputTypeComboBox";
            this.InputTypeComboBox.Size = new System.Drawing.Size(248, 21);
            this.InputTypeComboBox.TabIndex = 0;
            this.InputTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.InputTypeComboBox_SelectedIndexChanged);
            // 
            // NameEditWidget
            // 
            this.NameEditWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameEditWidget.Location = new System.Drawing.Point(0, 0);
            this.NameEditWidget.Name = "NameEditWidget";
            this.NameEditWidget.Size = new System.Drawing.Size(485, 30);
            this.NameEditWidget.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(407, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditWidgetInputAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NameEditWidget);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.ParameterGroupBox);
            this.Name = "EditWidgetInputAxis";
            this.Size = new System.Drawing.Size(485, 148);
            this.ParameterGroupBox.ResumeLayout(false);
            this.ParameterGroupBox.PerformLayout();
            this.PropertiesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ParameterGroupBox;
        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.ComboBox InputTypeComboBox;
        private System.Windows.Forms.ComboBox DataSourceComboBox;
        private System.Windows.Forms.FlowLayoutPanel ParamFlowPanel;
        private EditWidgetName NameEditWidget;
        private System.Windows.Forms.Button DeleteButton;
    }
}
