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
            this.InputAxisNameLabel = new System.Windows.Forms.Label();
            this.ParameterGroupBox = new System.Windows.Forms.GroupBox();
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.InputTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DataSourceComboBox = new System.Windows.Forms.ComboBox();
            this.ParamFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ParameterGroupBox.SuspendLayout();
            this.PropertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputAxisNameLabel
            // 
            this.InputAxisNameLabel.AutoSize = true;
            this.InputAxisNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAxisNameLabel.Location = new System.Drawing.Point(3, 0);
            this.InputAxisNameLabel.Name = "InputAxisNameLabel";
            this.InputAxisNameLabel.Size = new System.Drawing.Size(157, 20);
            this.InputAxisNameLabel.TabIndex = 0;
            this.InputAxisNameLabel.Text = "Input Axis: (Name)";
            // 
            // ParameterGroupBox
            // 
            this.ParameterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterGroupBox.Controls.Add(this.ParamFlowPanel);
            this.ParameterGroupBox.Location = new System.Drawing.Point(7, 110);
            this.ParameterGroupBox.Name = "ParameterGroupBox";
            this.ParameterGroupBox.Size = new System.Drawing.Size(390, 91);
            this.ParameterGroupBox.TabIndex = 1;
            this.ParameterGroupBox.TabStop = false;
            this.ParameterGroupBox.Text = "Parameters";
            // 
            // PropertiesGroupBox
            // 
            this.PropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertiesGroupBox.Controls.Add(this.DataSourceComboBox);
            this.PropertiesGroupBox.Controls.Add(this.InputTypeComboBox);
            this.PropertiesGroupBox.Location = new System.Drawing.Point(7, 23);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Size = new System.Drawing.Size(390, 81);
            this.PropertiesGroupBox.TabIndex = 2;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Properties";
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
            this.InputTypeComboBox.Size = new System.Drawing.Size(333, 21);
            this.InputTypeComboBox.TabIndex = 0;
            this.InputTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.InputTypeComboBox_SelectedIndexChanged);
            // 
            // DataSourceComboBox
            // 
            this.DataSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataSourceComboBox.FormattingEnabled = true;
            this.DataSourceComboBox.Location = new System.Drawing.Point(6, 46);
            this.DataSourceComboBox.Name = "DataSourceComboBox";
            this.DataSourceComboBox.Size = new System.Drawing.Size(333, 21);
            this.DataSourceComboBox.Sorted = true;
            this.DataSourceComboBox.TabIndex = 1;
            // 
            // ParamFlowPanel
            // 
            this.ParamFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamFlowPanel.Location = new System.Drawing.Point(3, 16);
            this.ParamFlowPanel.Name = "ParamFlowPanel";
            this.ParamFlowPanel.Size = new System.Drawing.Size(384, 72);
            this.ParamFlowPanel.TabIndex = 0;
            // 
            // EditWidgetInputAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.ParameterGroupBox);
            this.Controls.Add(this.InputAxisNameLabel);
            this.Name = "EditWidgetInputAxis";
            this.Size = new System.Drawing.Size(400, 204);
            this.ParameterGroupBox.ResumeLayout(false);
            this.PropertiesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputAxisNameLabel;
        private System.Windows.Forms.GroupBox ParameterGroupBox;
        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.ComboBox InputTypeComboBox;
        private System.Windows.Forms.ComboBox DataSourceComboBox;
        private System.Windows.Forms.FlowLayoutPanel ParamFlowPanel;
    }
}
