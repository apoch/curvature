using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public partial class EditWidgetResponseCurve : UserControl
    {
        private ResponseCurve EditingCurve = null;
        private Project EditingProject = null;

        private static Pen ThickBlackArrowPen = new Pen(Color.Black, 2.0f);



        public EditWidgetResponseCurve()
        {
            InitializeComponent();
            CurveTypeDropdown.SelectedIndex = 0;

            var arrowcap = new System.Drawing.Drawing2D.AdjustableArrowCap(5.0f, 5.0f);
            ThickBlackArrowPen.CustomStartCap = arrowcap;
            ThickBlackArrowPen.CustomEndCap = arrowcap;

            CurvePictureBox.Paint += (e, args) =>
            {
                args.Graphics.DrawLine(ThickBlackArrowPen, ConvertXYToPoint(-0.2, 0.0), ConvertXYToPoint(1.2, 0.0));
                args.Graphics.DrawLine(ThickBlackArrowPen, ConvertXYToPoint(0.0, -0.2), ConvertXYToPoint(0.0, 1.2));

                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(-0.2, 1.0), ConvertXYToPoint(1.2, 1.0));
                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(1.0, -0.2), ConvertXYToPoint(1.0, 1.2));

                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(-0.035, 0.25), ConvertXYToPoint(0.035, 0.25));
                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(-0.04, 0.5), ConvertXYToPoint(0.04, 0.5));
                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(-0.035, 0.75), ConvertXYToPoint(0.035, 0.75));

                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(0.25, -0.035), ConvertXYToPoint(0.25, 0.035));
                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(0.5, -0.04), ConvertXYToPoint(0.5, 0.04));
                args.Graphics.DrawLine(Pens.Black, ConvertXYToPoint(0.75, -0.035), ConvertXYToPoint(0.75, 0.035));

                if (EditingCurve == null)
                    return;

                Point previousPoint = ConvertXYToPoint(0.0, EditingCurve.ComputeValue(0.0));

                for (double x = 0.0; x <= 1.0; x += 0.001)
                {
                    double y = EditingCurve.ComputeValue(x);
                    Point p = ConvertXYToPoint(x, y);

                    args.Graphics.DrawLine(Pens.Blue, previousPoint, p);
                    previousPoint = p;
                }
            };

            SlopeEditBox.ValueChanged += (e, args) =>
            {
                if (EditingCurve == null)
                    return;

                var prev = EditingCurve.Slope;

                EditingCurve.Slope = (double)SlopeEditBox.Value;

                if (prev != EditingCurve.Slope)
                    EditingProject.MarkDirty();

                CurvePictureBox.Refresh();
            };

            ExponentEditBox.ValueChanged += (e, args) =>
            {
                if (EditingCurve == null)
                    return;


                var prev = EditingCurve.Exponent;

                EditingCurve.Exponent = (double)ExponentEditBox.Value;

                if (prev != EditingCurve.Exponent)
                    EditingProject.MarkDirty();


                CurvePictureBox.Refresh();
            };

            HorizontalShiftEditBox.ValueChanged += (e, args) =>
            {
                if (EditingCurve == null)
                    return;


                var prev = EditingCurve.XShift;

                EditingCurve.XShift = (double)HorizontalShiftEditBox.Value;

                if (prev != EditingCurve.XShift)
                    EditingProject.MarkDirty();


                CurvePictureBox.Refresh();
            };

            VerticalShiftEditBox.ValueChanged += (e, args) =>
            {
                if (EditingCurve == null)
                    return;

                var prev = EditingCurve.YShift;

                EditingCurve.YShift = (double)VerticalShiftEditBox.Value;

                if (prev != EditingCurve.YShift)
                    EditingProject.MarkDirty();

                CurvePictureBox.Refresh();
            };

            Resize += (e, args) =>
            {
                SuspendLayout();
                CurvePictureBox.Height = Height - (CurvePictureBox.Top * 2);
                ShiftDownButton.Width = CurvePictureBox.Width - (2 * ShiftLeftButton.Width) - 3;
                ShiftDownButton.Top = CurvePictureBox.Bottom - ShiftDownButton.Height - 1;
                ShiftUpButton.Width = ShiftDownButton.Width;
                ShiftRightButton.Left = ShiftUpButton.Right;
                ShiftRightButton.Height = CurvePictureBox.Height - (2 * ShiftUpButton.Height) - 3;
                ShiftLeftButton.Height = ShiftRightButton.Height;
                ResumeLayout(false);
            };
        }

        internal void AttachCurve(ResponseCurve curve, Project project)
        {
            EditingProject = project;
            EditingCurve = curve;

            CurveTypeDropdown.SelectedIndex = (int)curve.Type;
            SlopeEditBox.Value = (decimal)curve.Slope;
            ExponentEditBox.Value = (decimal)curve.Exponent;
            HorizontalShiftEditBox.Value = (decimal)curve.XShift;
            VerticalShiftEditBox.Value = (decimal)curve.YShift;

            CurvePictureBox.Refresh();
        }

        private Point ConvertXYToPoint(double x, double y)
        {
            var rect = CurvePictureBox.ClientRectangle;
            double height = (double)rect.Height * 0.5;
            double width = (double)rect.Width * 0.5;

            if (height >= width)
                height = width;
            else
                width = height;

            double marginX = ((double)rect.Width - width) / 2.0;
            double marginY = ((double)rect.Height - height) / 2.0;

            double pixelX = x * width + marginX;
            double pixelY = (1.0 - y) * height + marginY;

            return new Point((int)pixelX, (int)pixelY);
        }

        private void CurveTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditingCurve == null)
                return;

            var prev = EditingCurve.Type;

            EditingCurve.Type = (ResponseCurve.CurveType)CurveTypeDropdown.SelectedIndex;
            CurvePictureBox.Refresh();

            if (EditingCurve.Type != prev)
                EditingProject.MarkDirty();
        }

        private void ShiftLeftButton_Click(object sender, EventArgs e)
        {
            HorizontalShiftEditBox.Value -= HorizontalShiftEditBox.Increment;
        }

        private void ShiftRightButton_Click(object sender, EventArgs e)
        {
            HorizontalShiftEditBox.Value += HorizontalShiftEditBox.Increment;
        }

        private void ShiftUpButton_Click(object sender, EventArgs e)
        {
            VerticalShiftEditBox.Value += VerticalShiftEditBox.Increment;
        }

        private void ShiftDownButton_Click(object sender, EventArgs e)
        {
            VerticalShiftEditBox.Value -= VerticalShiftEditBox.Increment;
        }
    }
}
