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
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.InputsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NewInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            // 
            // InputsLayoutPanel
            // 
            this.InputsLayoutPanel.AutoScroll = true;
            this.InputsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InputsLayoutPanel.ColumnCount = 1;
            this.InputsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputsLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.InputsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.InputsLayoutPanel.Name = "InputsLayoutPanel";
            this.InputsLayoutPanel.RowCount = 1;
            this.InputsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayoutPanel.Size = new System.Drawing.Size(426, 255);
            this.InputsLayoutPanel.TabIndex = 0;
            // 
            // NewInputButton
            // 
            this.NewInputButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewInputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewInputButton.ImageIndex = 0;
            this.NewInputButton.ImageList = this.IconImageList;
            this.NewInputButton.Location = new System.Drawing.Point(0, 225);
            this.NewInputButton.Name = "NewInputButton";
            this.NewInputButton.Size = new System.Drawing.Size(426, 30);
            this.NewInputButton.TabIndex = 1;
            this.NewInputButton.Text = "Create Input Axis";
            this.NewInputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewInputButton.UseVisualStyleBackColor = true;
            // 
            // EditWidgetInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewInputButton);
            this.Controls.Add(this.InputsLayoutPanel);
            this.Name = "EditWidgetInputs";
            this.Size = new System.Drawing.Size(426, 255);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IconImageList;
        private System.Windows.Forms.TableLayoutPanel InputsLayoutPanel;
        private System.Windows.Forms.Button NewInputButton;
    }
}
