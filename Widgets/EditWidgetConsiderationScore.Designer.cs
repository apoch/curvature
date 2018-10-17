namespace Curvature
{
    partial class EditWidgetConsiderationScore
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ResponseCurvePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResponseCurvePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsiderationNameLabel
            // 
            this.ConsiderationNameLabel.Location = new System.Drawing.Point(3, 47);
            this.ConsiderationNameLabel.Name = "ConsiderationNameLabel";
            this.ConsiderationNameLabel.Size = new System.Drawing.Size(159, 23);
            this.ConsiderationNameLabel.TabIndex = 0;
            this.ConsiderationNameLabel.Text = "(Consideration Name) x";
            this.ConsiderationNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(284, 52);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(31, 13);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "= 0.0";
            // 
            // ResponseCurvePictureBox
            // 
            this.ResponseCurvePictureBox.BackColor = System.Drawing.Color.White;
            this.ResponseCurvePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResponseCurvePictureBox.Location = new System.Drawing.Point(168, 3);
            this.ResponseCurvePictureBox.Name = "ResponseCurvePictureBox";
            this.ResponseCurvePictureBox.Size = new System.Drawing.Size(110, 110);
            this.ResponseCurvePictureBox.TabIndex = 0;
            this.ResponseCurvePictureBox.TabStop = false;
            // 
            // EditWidgetConsiderationScore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ConsiderationNameLabel);
            this.Controls.Add(this.ResponseCurvePictureBox);
            this.Name = "EditWidgetConsiderationScore";
            this.Size = new System.Drawing.Size(347, 116);
            ((System.ComponentModel.ISupportInitialize)(this.ResponseCurvePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ResponseCurvePictureBox;
        private System.Windows.Forms.Label ConsiderationNameLabel;
        private System.Windows.Forms.Label ScoreLabel;
    }
}
