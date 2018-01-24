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
        private ResponseCurve EditCurve = null;
        private Project EditProject = null;

        private Pen ThickBlackArrowPen = new Pen(Color.Black, 2.0f);



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

                if (EditCurve == null)
                    return;

                Point previousPoint = ConvertXYToPoint(0.0, EditCurve.ComputeValue(0.0));

                for (double x = 0.0; x <= 1.0; x += 0.001)
                {
                    double y = EditCurve.ComputeValue(x);
                    Point p = ConvertXYToPoint(x, y);

                    args.Graphics.DrawLine(Pens.Blue, previousPoint, p);
                    previousPoint = p;
                }
            };

            SlopeEditBox.ValueChanged += (e, args) =>
            {
                if (EditCurve == null)
                    return;

                var prev = EditCurve.Slope;

                EditCurve.Slope = (double)SlopeEditBox.Value;

                if (prev != EditCurve.Slope)
                    EditProject.MarkDirty();

                CurvePictureBox.Refresh();
            };

            ExponentEditBox.ValueChanged += (e, args) =>
            {
                if (EditCurve == null)
                    return;


                var prev = EditCurve.Exponent;

                EditCurve.Exponent = (double)ExponentEditBox.Value;

                if (prev != EditCurve.Exponent)
                    EditProject.MarkDirty();


                CurvePictureBox.Refresh();
            };

            HorizontalShiftEditBox.ValueChanged += (e, args) =>
            {
                if (EditCurve == null)
                    return;


                var prev = EditCurve.XShift;

                EditCurve.XShift = (double)HorizontalShiftEditBox.Value;

                if (prev != EditCurve.XShift)
                    EditProject.MarkDirty();


                CurvePictureBox.Refresh();
            };

            VerticalShiftEditBox.ValueChanged += (e, args) =>
            {
                if (EditCurve == null)
                    return;

                var prev = EditCurve.YShift;

                EditCurve.YShift = (double)VerticalShiftEditBox.Value;

                if (prev != EditCurve.YShift)
                    EditProject.MarkDirty();

                CurvePictureBox.Refresh();
            };
        }

        internal void AttachCurve(ResponseCurve curve, Project project)
        {
            EditProject = project;
            EditCurve = curve;

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
            if (EditCurve == null)
                return;

            var prev = EditCurve.Type;

            EditCurve.Type = (ResponseCurve.CurveType)CurveTypeDropdown.SelectedIndex;
            CurvePictureBox.Refresh();

            if (EditCurve.Type != prev)
                EditProject.MarkDirty();
        }

        private void PresetButton_Click(object sender, EventArgs e)
        {
            (new CurvePresetForm(EditCurve)).ShowDialog();
            // TODO - mark project dirty if dialog commits changes
            AttachCurve(EditCurve, EditProject);
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
