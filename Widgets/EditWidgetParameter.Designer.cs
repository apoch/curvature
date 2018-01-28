namespace Curvature
{
    partial class EditWidgetParameter
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
            this.ParameterNameLabel = new System.Windows.Forms.Label();
            this.MinimumValue = new System.Windows.Forms.NumericUpDown();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MaximumValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ParameterNameLabel
            // 
            this.ParameterNameLabel.AutoSize = true;
            this.ParameterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParameterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ParameterNameLabel.Name = "ParameterNameLabel";
            this.ParameterNameLabel.Size = new System.Drawing.Size(147, 18);
            this.ParameterNameLabel.TabIndex = 0;
            this.ParameterNameLabel.Text = "(Parameter Name)";
            // 
            // MinimumValue
            // 
            this.MinimumValue.DecimalPlaces = 3;
            this.MinimumValue.Location = new System.Drawing.Point(60, 21);
            this.MinimumValue.Name = "MinimumValue";
            this.MinimumValue.Size = new System.Drawing.Size(94, 20);
            this.MinimumValue.TabIndex = 2;
            this.MinimumValue.ValueChanged += new System.EventHandler(this.MinimumValue_ValueChanged);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(3, 23);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(51, 13);
            this.MinLabel.TabIndex = 1;
            this.MinLabel.Text = "Minimum:";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(160, 23);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(54, 13);
            this.MaxLabel.TabIndex = 3;
            this.MaxLabel.Text = "Maximum:";
            // 
            // MaximumValue
            // 
            this.MaximumValue.DecimalPlaces = 3;
            this.MaximumValue.Location = new System.Drawing.Point(220, 21);
            this.MaximumValue.Name = "MaximumValue";
            this.MaximumValue.Size = new System.Drawing.Size(94, 20);
            this.MaximumValue.TabIndex = 4;
            this.MaximumValue.ValueChanged += new System.EventHandler(this.MaximumValue_ValueChanged);
            // 
            // EditWidgetParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaximumValue);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MinimumValue);
            this.Controls.Add(this.ParameterNameLabel);
            this.Name = "EditWidgetParameter";
            this.Size = new System.Drawing.Size(319, 49);
            ((System.ComponentModel.ISupportInitialize)(this.MinimumValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParameterNameLabel;
        private System.Windows.Forms.NumericUpDown MinimumValue;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.NumericUpDown MaximumValue;
    }
}
