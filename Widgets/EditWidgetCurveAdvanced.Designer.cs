namespace Curvature.Widgets
{
    partial class EditWidgetCurveAdvanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetCurveAdvanced));
            this.ResponseCurveDescriptionLabel = new System.Windows.Forms.Label();
            this.ResponseCurveEditor = new Curvature.EditWidgetResponseCurve();
            this.SuspendLayout();
            // 
            // ResponseCurveDescriptionLabel
            // 
            this.ResponseCurveDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.ResponseCurveDescriptionLabel.Name = "ResponseCurveDescriptionLabel";
            this.ResponseCurveDescriptionLabel.Size = new System.Drawing.Size(212, 230);
            this.ResponseCurveDescriptionLabel.TabIndex = 2;
            this.ResponseCurveDescriptionLabel.Text = resources.GetString("ResponseCurveDescriptionLabel.Text");
            // 
            // ResponseCurveEditor
            // 
            this.ResponseCurveEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseCurveEditor.Location = new System.Drawing.Point(221, 3);
            this.ResponseCurveEditor.Name = "ResponseCurveEditor";
            this.ResponseCurveEditor.Size = new System.Drawing.Size(376, 227);
            this.ResponseCurveEditor.TabIndex = 3;
            // 
            // EditWidgetCurveAdvanced
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ResponseCurveDescriptionLabel);
            this.Controls.Add(this.ResponseCurveEditor);
            this.Name = "EditWidgetCurveAdvanced";
            this.Size = new System.Drawing.Size(604, 237);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ResponseCurveDescriptionLabel;
        private EditWidgetResponseCurve ResponseCurveEditor;
    }
}
