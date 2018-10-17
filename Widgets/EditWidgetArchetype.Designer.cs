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
            this.EnabledBehaviorSetsListBox = new System.Windows.Forms.CheckedListBox();
            this.NameEditWidget = new Curvature.EditWidgetName();
            this.SuspendLayout();
            // 
            // EnabledBehaviorSetsListBox
            // 
            this.EnabledBehaviorSetsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnabledBehaviorSetsListBox.FormattingEnabled = true;
            this.EnabledBehaviorSetsListBox.Location = new System.Drawing.Point(7, 38);
            this.EnabledBehaviorSetsListBox.Name = "EnabledBehaviorSetsListBox";
            this.EnabledBehaviorSetsListBox.Size = new System.Drawing.Size(493, 304);
            this.EnabledBehaviorSetsListBox.TabIndex = 1;
            // 
            // NameEditWidget
            // 
            this.NameEditWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameEditWidget.Location = new System.Drawing.Point(0, 0);
            this.NameEditWidget.Name = "NameEditWidget";
            this.NameEditWidget.Size = new System.Drawing.Size(503, 30);
            this.NameEditWidget.TabIndex = 0;
            // 
            // EditWidgetArchetype
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.NameEditWidget);
            this.Controls.Add(this.EnabledBehaviorSetsListBox);
            this.Name = "EditWidgetArchetype";
            this.Size = new System.Drawing.Size(503, 350);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox EnabledBehaviorSetsListBox;
        private EditWidgetName NameEditWidget;
    }
}
