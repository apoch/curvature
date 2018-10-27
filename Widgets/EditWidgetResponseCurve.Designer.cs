namespace Curvature
{
    partial class EditWidgetResponseCurve
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
            this.SlopeLabel = new System.Windows.Forms.Label();
            this.ExponentLabel = new System.Windows.Forms.Label();
            this.HorizontalShiftLabel = new System.Windows.Forms.Label();
            this.VerticalShiftLabel = new System.Windows.Forms.Label();
            this.CurveTypeDropdown = new System.Windows.Forms.ComboBox();
            this.CurvePictureBox = new System.Windows.Forms.PictureBox();
            this.SlopeEditBox = new System.Windows.Forms.NumericUpDown();
            this.ExponentEditBox = new System.Windows.Forms.NumericUpDown();
            this.HorizontalShiftEditBox = new System.Windows.Forms.NumericUpDown();
            this.VerticalShiftEditBox = new System.Windows.Forms.NumericUpDown();
            this.ShiftLeftButton = new System.Windows.Forms.Button();
            this.ShiftRightButton = new System.Windows.Forms.Button();
            this.ShiftUpButton = new System.Windows.Forms.Button();
            this.ShiftDownButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurvePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlopeEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExponentEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalShiftEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalShiftEditBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SlopeLabel
            // 
            this.SlopeLabel.AutoSize = true;
            this.SlopeLabel.Location = new System.Drawing.Point(20, 37);
            this.SlopeLabel.Name = "SlopeLabel";
            this.SlopeLabel.Size = new System.Drawing.Size(37, 13);
            this.SlopeLabel.TabIndex = 1;
            this.SlopeLabel.Text = "Slope:";
            this.SlopeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ExponentLabel
            // 
            this.ExponentLabel.AutoSize = true;
            this.ExponentLabel.Location = new System.Drawing.Point(2, 63);
            this.ExponentLabel.Name = "ExponentLabel";
            this.ExponentLabel.Size = new System.Drawing.Size(55, 13);
            this.ExponentLabel.TabIndex = 3;
            this.ExponentLabel.Text = "Exponent:";
            this.ExponentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HorizontalShiftLabel
            // 
            this.HorizontalShiftLabel.AutoSize = true;
            this.HorizontalShiftLabel.Location = new System.Drawing.Point(12, 89);
            this.HorizontalShiftLabel.Name = "HorizontalShiftLabel";
            this.HorizontalShiftLabel.Size = new System.Drawing.Size(45, 13);
            this.HorizontalShiftLabel.TabIndex = 5;
            this.HorizontalShiftLabel.Text = "H. Shift:";
            // 
            // VerticalShiftLabel
            // 
            this.VerticalShiftLabel.AutoSize = true;
            this.VerticalShiftLabel.Location = new System.Drawing.Point(13, 115);
            this.VerticalShiftLabel.Name = "VerticalShiftLabel";
            this.VerticalShiftLabel.Size = new System.Drawing.Size(44, 13);
            this.VerticalShiftLabel.TabIndex = 7;
            this.VerticalShiftLabel.Text = "V. Shift:";
            // 
            // CurveTypeDropdown
            // 
            this.CurveTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurveTypeDropdown.FormattingEnabled = true;
            this.CurveTypeDropdown.Items.AddRange(new object[] {
            "Linear",
            "Polynomial",
            "Logistic",
            "Logit",
            "Normal",
            "Sine"});
            this.CurveTypeDropdown.Location = new System.Drawing.Point(3, 3);
            this.CurveTypeDropdown.Name = "CurveTypeDropdown";
            this.CurveTypeDropdown.Size = new System.Drawing.Size(129, 21);
            this.CurveTypeDropdown.TabIndex = 0;
            this.CurveTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.CurveTypeDropdown_SelectedIndexChanged);
            // 
            // CurvePictureBox
            // 
            this.CurvePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurvePictureBox.BackColor = System.Drawing.Color.White;
            this.CurvePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurvePictureBox.Location = new System.Drawing.Point(138, 3);
            this.CurvePictureBox.Name = "CurvePictureBox";
            this.CurvePictureBox.Size = new System.Drawing.Size(220, 199);
            this.CurvePictureBox.TabIndex = 9;
            this.CurvePictureBox.TabStop = false;
            // 
            // SlopeEditBox
            // 
            this.SlopeEditBox.DecimalPlaces = 3;
            this.SlopeEditBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SlopeEditBox.Location = new System.Drawing.Point(63, 35);
            this.SlopeEditBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SlopeEditBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SlopeEditBox.Name = "SlopeEditBox";
            this.SlopeEditBox.Size = new System.Drawing.Size(69, 20);
            this.SlopeEditBox.TabIndex = 2;
            this.SlopeEditBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // ExponentEditBox
            // 
            this.ExponentEditBox.DecimalPlaces = 3;
            this.ExponentEditBox.Location = new System.Drawing.Point(63, 61);
            this.ExponentEditBox.Name = "ExponentEditBox";
            this.ExponentEditBox.Size = new System.Drawing.Size(69, 20);
            this.ExponentEditBox.TabIndex = 4;
            this.ExponentEditBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // HorizontalShiftEditBox
            // 
            this.HorizontalShiftEditBox.DecimalPlaces = 3;
            this.HorizontalShiftEditBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HorizontalShiftEditBox.Location = new System.Drawing.Point(63, 87);
            this.HorizontalShiftEditBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.HorizontalShiftEditBox.Name = "HorizontalShiftEditBox";
            this.HorizontalShiftEditBox.Size = new System.Drawing.Size(69, 20);
            this.HorizontalShiftEditBox.TabIndex = 6;
            // 
            // VerticalShiftEditBox
            // 
            this.VerticalShiftEditBox.DecimalPlaces = 3;
            this.VerticalShiftEditBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.VerticalShiftEditBox.Location = new System.Drawing.Point(63, 113);
            this.VerticalShiftEditBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.VerticalShiftEditBox.Name = "VerticalShiftEditBox";
            this.VerticalShiftEditBox.Size = new System.Drawing.Size(69, 20);
            this.VerticalShiftEditBox.TabIndex = 8;
            // 
            // ShiftLeftButton
            // 
            this.ShiftLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShiftLeftButton.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ShiftLeftButton.Location = new System.Drawing.Point(140, 25);
            this.ShiftLeftButton.Name = "ShiftLeftButton";
            this.ShiftLeftButton.Size = new System.Drawing.Size(20, 157);
            this.ShiftLeftButton.TabIndex = 12;
            this.ShiftLeftButton.Text = "×";
            this.ShiftLeftButton.UseVisualStyleBackColor = true;
            this.ShiftLeftButton.Click += new System.EventHandler(this.ShiftLeftButton_Click);
            // 
            // ShiftRightButton
            // 
            this.ShiftRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftRightButton.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ShiftRightButton.Location = new System.Drawing.Point(335, 25);
            this.ShiftRightButton.Name = "ShiftRightButton";
            this.ShiftRightButton.Size = new System.Drawing.Size(20, 157);
            this.ShiftRightButton.TabIndex = 13;
            this.ShiftRightButton.Text = "Ø";
            this.ShiftRightButton.UseVisualStyleBackColor = true;
            this.ShiftRightButton.Click += new System.EventHandler(this.ShiftRightButton_Click);
            // 
            // ShiftUpButton
            // 
            this.ShiftUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftUpButton.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ShiftUpButton.Location = new System.Drawing.Point(159, 5);
            this.ShiftUpButton.Name = "ShiftUpButton";
            this.ShiftUpButton.Size = new System.Drawing.Size(177, 20);
            this.ShiftUpButton.TabIndex = 10;
            this.ShiftUpButton.Text = "Ù";
            this.ShiftUpButton.UseVisualStyleBackColor = true;
            this.ShiftUpButton.Click += new System.EventHandler(this.ShiftUpButton_Click);
            // 
            // ShiftDownButton
            // 
            this.ShiftDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShiftDownButton.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ShiftDownButton.Location = new System.Drawing.Point(159, 181);
            this.ShiftDownButton.Name = "ShiftDownButton";
            this.ShiftDownButton.Size = new System.Drawing.Size(177, 20);
            this.ShiftDownButton.TabIndex = 11;
            this.ShiftDownButton.Text = "Ú";
            this.ShiftDownButton.UseVisualStyleBackColor = true;
            this.ShiftDownButton.Click += new System.EventHandler(this.ShiftDownButton_Click);
            // 
            // EditWidgetResponseCurve
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.ShiftDownButton);
            this.Controls.Add(this.ShiftUpButton);
            this.Controls.Add(this.ShiftRightButton);
            this.Controls.Add(this.ShiftLeftButton);
            this.Controls.Add(this.VerticalShiftEditBox);
            this.Controls.Add(this.HorizontalShiftEditBox);
            this.Controls.Add(this.ExponentEditBox);
            this.Controls.Add(this.SlopeEditBox);
            this.Controls.Add(this.CurvePictureBox);
            this.Controls.Add(this.CurveTypeDropdown);
            this.Controls.Add(this.VerticalShiftLabel);
            this.Controls.Add(this.HorizontalShiftLabel);
            this.Controls.Add(this.ExponentLabel);
            this.Controls.Add(this.SlopeLabel);
            this.Name = "EditWidgetResponseCurve";
            this.Size = new System.Drawing.Size(361, 209);
            ((System.ComponentModel.ISupportInitialize)(this.CurvePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlopeEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExponentEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalShiftEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalShiftEditBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SlopeLabel;
        private System.Windows.Forms.Label ExponentLabel;
        private System.Windows.Forms.Label HorizontalShiftLabel;
        private System.Windows.Forms.Label VerticalShiftLabel;
        private System.Windows.Forms.ComboBox CurveTypeDropdown;
        private System.Windows.Forms.PictureBox CurvePictureBox;
        private System.Windows.Forms.NumericUpDown SlopeEditBox;
        private System.Windows.Forms.NumericUpDown ExponentEditBox;
        private System.Windows.Forms.NumericUpDown HorizontalShiftEditBox;
        private System.Windows.Forms.NumericUpDown VerticalShiftEditBox;
        private System.Windows.Forms.Button ShiftLeftButton;
        private System.Windows.Forms.Button ShiftRightButton;
        private System.Windows.Forms.Button ShiftUpButton;
        private System.Windows.Forms.Button ShiftDownButton;
    }
}
