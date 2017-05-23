namespace Curvature
{
    partial class EditWidgetName
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
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EditIcon = new System.Windows.Forms.PictureBox();
            this.ObjectNameLabel = new System.Windows.Forms.Label();
            this.ObjectTypeLabel = new System.Windows.Forms.Label();
            this.FlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanel.Controls.Add(this.ObjectTypeLabel);
            this.FlowPanel.Controls.Add(this.ObjectNameLabel);
            this.FlowPanel.Controls.Add(this.EditIcon);
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(398, 141);
            this.FlowPanel.TabIndex = 3;
            this.FlowPanel.WrapContents = false;
            // 
            // EditIcon
            // 
            this.EditIcon.Image = global::Curvature.Properties.Resources._00ffff_pencil_32;
            this.EditIcon.Location = new System.Drawing.Point(197, 3);
            this.EditIcon.Name = "EditIcon";
            this.EditIcon.Size = new System.Drawing.Size(12, 16);
            this.EditIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditIcon.TabIndex = 5;
            this.EditIcon.TabStop = false;
            this.EditIcon.Click += new System.EventHandler(this.EditIcon_Click);
            // 
            // ObjectNameLabel
            // 
            this.ObjectNameLabel.AutoSize = true;
            this.ObjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectNameLabel.Location = new System.Drawing.Point(136, 0);
            this.ObjectNameLabel.Name = "ObjectNameLabel";
            this.ObjectNameLabel.Size = new System.Drawing.Size(55, 20);
            this.ObjectNameLabel.TabIndex = 4;
            this.ObjectNameLabel.Text = "Name";
            // 
            // ObjectTypeLabel
            // 
            this.ObjectTypeLabel.AutoSize = true;
            this.ObjectTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.ObjectTypeLabel.Name = "ObjectTypeLabel";
            this.ObjectTypeLabel.Size = new System.Drawing.Size(127, 20);
            this.ObjectTypeLabel.TabIndex = 3;
            this.ObjectTypeLabel.Text = "Named Object:";
            // 
            // EditWidgetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowPanel);
            this.Name = "EditWidgetName";
            this.Size = new System.Drawing.Size(398, 141);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label ObjectTypeLabel;
        private System.Windows.Forms.Label ObjectNameLabel;
        private System.Windows.Forms.PictureBox EditIcon;
    }
}
