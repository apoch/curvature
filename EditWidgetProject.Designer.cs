namespace Curvature
{
    partial class EditWidgetProject
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
            this.WikiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.NameEditWidget = new Curvature.EditWidgetName();
            this.SuspendLayout();
            // 
            // WikiLinkLabel
            // 
            this.WikiLinkLabel.AutoSize = true;
            this.WikiLinkLabel.Location = new System.Drawing.Point(15, 49);
            this.WikiLinkLabel.Name = "WikiLinkLabel";
            this.WikiLinkLabel.Size = new System.Drawing.Size(128, 13);
            this.WikiLinkLabel.TabIndex = 1;
            this.WikiLinkLabel.TabStop = true;
            this.WikiLinkLabel.Text = "Curvature Wiki on GitHub";
            this.WikiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WikiLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resources:";
            // 
            // NameEditWidget
            // 
            this.NameEditWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameEditWidget.Location = new System.Drawing.Point(0, 0);
            this.NameEditWidget.Name = "NameEditWidget";
            this.NameEditWidget.Size = new System.Drawing.Size(610, 27);
            this.NameEditWidget.TabIndex = 0;
            // 
            // EditWidgetProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WikiLinkLabel);
            this.Controls.Add(this.NameEditWidget);
            this.Name = "EditWidgetProject";
            this.Size = new System.Drawing.Size(610, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EditWidgetName NameEditWidget;
        private System.Windows.Forms.LinkLabel WikiLinkLabel;
        private System.Windows.Forms.Label label1;
    }
}
