namespace Curvature.Widgets
{
    partial class EditWidgetKnowledgeBaseParameter
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
            this.ValueSlider = new System.Windows.Forms.TrackBar();
            this.ValueUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ValueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueSlider
            // 
            this.ValueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueSlider.Location = new System.Drawing.Point(3, 3);
            this.ValueSlider.Name = "ValueSlider";
            this.ValueSlider.Size = new System.Drawing.Size(141, 45);
            this.ValueSlider.TabIndex = 0;
            // 
            // ValueUpDown
            // 
            this.ValueUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueUpDown.DecimalPlaces = 3;
            this.ValueUpDown.Location = new System.Drawing.Point(3, 54);
            this.ValueUpDown.Name = "ValueUpDown";
            this.ValueUpDown.Size = new System.Drawing.Size(141, 20);
            this.ValueUpDown.TabIndex = 1;
            this.ValueUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditWidgetKnowledgeBaseParameter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ValueUpDown);
            this.Controls.Add(this.ValueSlider);
            this.Name = "EditWidgetKnowledgeBaseParameter";
            this.Size = new System.Drawing.Size(147, 83);
            ((System.ComponentModel.ISupportInitialize)(this.ValueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar ValueSlider;
        private System.Windows.Forms.NumericUpDown ValueUpDown;
    }
}
