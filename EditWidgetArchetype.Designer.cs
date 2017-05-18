namespace Curvature
{
    partial class EditWidgetArchetype
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
            this.ArchetypeNameLabel = new System.Windows.Forms.Label();
            this.EnabledBehaviorSetsListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ArchetypeNameLabel
            // 
            this.ArchetypeNameLabel.AutoSize = true;
            this.ArchetypeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchetypeNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ArchetypeNameLabel.Name = "ArchetypeNameLabel";
            this.ArchetypeNameLabel.Size = new System.Drawing.Size(244, 20);
            this.ArchetypeNameLabel.TabIndex = 0;
            this.ArchetypeNameLabel.Text = "Archetype: (Archetype Name)";
            // 
            // EnabledBehaviorSetsListBox
            // 
            this.EnabledBehaviorSetsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnabledBehaviorSetsListBox.FormattingEnabled = true;
            this.EnabledBehaviorSetsListBox.Location = new System.Drawing.Point(7, 23);
            this.EnabledBehaviorSetsListBox.Name = "EnabledBehaviorSetsListBox";
            this.EnabledBehaviorSetsListBox.Size = new System.Drawing.Size(429, 319);
            this.EnabledBehaviorSetsListBox.TabIndex = 1;
            // 
            // EditWidgetArchetype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnabledBehaviorSetsListBox);
            this.Controls.Add(this.ArchetypeNameLabel);
            this.Name = "EditWidgetArchetype";
            this.Size = new System.Drawing.Size(439, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArchetypeNameLabel;
        private System.Windows.Forms.CheckedListBox EnabledBehaviorSetsListBox;
    }
}
