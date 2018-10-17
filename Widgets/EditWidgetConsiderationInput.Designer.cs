namespace Curvature
{
    partial class EditWidgetConsiderationInput
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
            this.InputValueTrackBar = new System.Windows.Forms.TrackBar();
            this.InputCaption = new System.Windows.Forms.Label();
            this.InputValueDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputValueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // InputValueTrackBar
            // 
            this.InputValueTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputValueTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.InputValueTrackBar.Location = new System.Drawing.Point(6, 3);
            this.InputValueTrackBar.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.InputValueTrackBar.Name = "InputValueTrackBar";
            this.InputValueTrackBar.Size = new System.Drawing.Size(258, 45);
            this.InputValueTrackBar.TabIndex = 0;
            this.InputValueTrackBar.Scroll += new System.EventHandler(this.InputValueTrackBar_Scroll);
            // 
            // InputCaption
            // 
            this.InputCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCaption.Location = new System.Drawing.Point(3, 51);
            this.InputCaption.Name = "InputCaption";
            this.InputCaption.Size = new System.Drawing.Size(261, 23);
            this.InputCaption.TabIndex = 1;
            this.InputCaption.Text = "(Input Name)";
            this.InputCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputValueDropDown
            // 
            this.InputValueDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputValueDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputValueDropDown.FormattingEnabled = true;
            this.InputValueDropDown.Location = new System.Drawing.Point(6, 14);
            this.InputValueDropDown.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.InputValueDropDown.Name = "InputValueDropDown";
            this.InputValueDropDown.Size = new System.Drawing.Size(258, 21);
            this.InputValueDropDown.TabIndex = 2;
            this.InputValueDropDown.SelectedIndexChanged += new System.EventHandler(this.InputValueDropDown_SelectedIndexChanged);
            // 
            // EditWidgetConsiderationInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.InputValueDropDown);
            this.Controls.Add(this.InputCaption);
            this.Controls.Add(this.InputValueTrackBar);
            this.Name = "EditWidgetConsiderationInput";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Size = new System.Drawing.Size(277, 77);
            ((System.ComponentModel.ISupportInitialize)(this.InputValueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar InputValueTrackBar;
        private System.Windows.Forms.Label InputCaption;
        private System.Windows.Forms.ComboBox InputValueDropDown;
    }
}
