namespace Curvature
{
    partial class CurvePresetForm
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
            this.CancelPresetsButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CurvePresetsWidget = new Curvature.Widgets.EditWidgetCurvePresets();
            this.SuspendLayout();
            // 
            // CancelPresetsButton
            // 
            this.CancelPresetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelPresetsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPresetsButton.Location = new System.Drawing.Point(501, 280);
            this.CancelPresetsButton.Name = "CancelPresetsButton";
            this.CancelPresetsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPresetsButton.TabIndex = 8;
            this.CancelPresetsButton.Text = "Cancel";
            this.CancelPresetsButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(420, 280);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CurvePresetsWidget
            // 
            this.CurvePresetsWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurvePresetsWidget.Location = new System.Drawing.Point(2, 2);
            this.CurvePresetsWidget.Name = "CurvePresetsWidget";
            this.CurvePresetsWidget.Size = new System.Drawing.Size(583, 272);
            this.CurvePresetsWidget.TabIndex = 9;
            // 
            // CurvePresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 315);
            this.Controls.Add(this.CurvePresetsWidget);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelPresetsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurvePresetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curve Preset Generator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelPresetsButton;
        private System.Windows.Forms.Button OKButton;
        private Widgets.EditWidgetCurvePresets CurvePresetsWidget;
    }
}