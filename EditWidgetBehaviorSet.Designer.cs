namespace Curvature
{
    partial class EditWidgetBehaviorSet
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
            this.BehaviorSetNameLabel = new System.Windows.Forms.Label();
            this.EnabledBehaviorsListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BehaviorSetNameLabel
            // 
            this.BehaviorSetNameLabel.AutoSize = true;
            this.BehaviorSetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehaviorSetNameLabel.Location = new System.Drawing.Point(3, 0);
            this.BehaviorSetNameLabel.Name = "BehaviorSetNameLabel";
            this.BehaviorSetNameLabel.Size = new System.Drawing.Size(180, 20);
            this.BehaviorSetNameLabel.TabIndex = 0;
            this.BehaviorSetNameLabel.Text = "Behavior Set: (Name)";
            // 
            // EnabledBehaviorsListBox
            // 
            this.EnabledBehaviorsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnabledBehaviorsListBox.FormattingEnabled = true;
            this.EnabledBehaviorsListBox.IntegralHeight = false;
            this.EnabledBehaviorsListBox.Location = new System.Drawing.Point(7, 23);
            this.EnabledBehaviorsListBox.Name = "EnabledBehaviorsListBox";
            this.EnabledBehaviorsListBox.Size = new System.Drawing.Size(447, 229);
            this.EnabledBehaviorsListBox.TabIndex = 1;
            // 
            // EditWidgetBehaviorSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnabledBehaviorsListBox);
            this.Controls.Add(this.BehaviorSetNameLabel);
            this.Name = "EditWidgetBehaviorSet";
            this.Size = new System.Drawing.Size(457, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BehaviorSetNameLabel;
        private System.Windows.Forms.CheckedListBox EnabledBehaviorsListBox;
    }
}
