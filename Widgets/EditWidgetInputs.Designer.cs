namespace Curvature
{
    partial class EditWidgetInputs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetInputs));
            this.InputsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // InputsFlowPanel
            // 
            this.InputsFlowPanel.AutoScroll = true;
            this.InputsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InputsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.InputsFlowPanel.Name = "InputsFlowPanel";
            this.InputsFlowPanel.Size = new System.Drawing.Size(426, 255);
            this.InputsFlowPanel.TabIndex = 0;
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            // 
            // EditWidgetInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputsFlowPanel);
            this.Name = "EditWidgetInputs";
            this.Size = new System.Drawing.Size(426, 255);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel InputsFlowPanel;
        private System.Windows.Forms.ImageList IconImageList;
    }
}
