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
    public partial class EditWidgetConsiderationScore : UserControl
    {
        private Consideration EditConsideration;
        private IInputBroker InputBroker;

        internal EditWidgetConsiderationScore(Consideration consideration, IInputBroker broker)
        {
            InitializeComponent();
            EditConsideration = consideration;
            InputBroker = broker;

            ConsiderationNameLabel.Text = EditConsideration.ReadableName + " (0.0) x";

            ResponseCurvePictureBox.Paint += (e, args) =>
            {
                Point previousPoint = ConvertXYToPoint(0.0, EditConsideration.Curve.ComputeValue(0.0));

                for (double x = 0.0; x <= 1.0; x += 0.001)
                {
                    double y = EditConsideration.Curve.ComputeValue(x);
                    Point p = ConvertXYToPoint(x, y);

                    args.Graphics.DrawLine(Pens.Blue, previousPoint, p);
                    previousPoint = p;
                }

                double inputX = InputBroker.GetInputValue(EditConsideration.Input);
                double inputY = EditConsideration.Curve.ComputeValue(inputX);

                string name = EditConsideration.ReadableName;
                ConsiderationNameLabel.Text = $"{name} ({inputX:f3}) x";
                ScoreLabel.Text = $"= {inputY:f3}";

                Point offsetPoint = ConvertXYToPoint(inputX, inputY);
                offsetPoint.X -= 4;
                offsetPoint.Y -= 4;

                args.Graphics.FillEllipse(Brushes.Blue, new Rectangle(offsetPoint, new Size(8, 8)));
            };
        }

        private Point ConvertXYToPoint(double x, double y)
        {
            var rect = ResponseCurvePictureBox.ClientRectangle;
            double height = (double)rect.Height;
            double width = (double)rect.Width;

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
    }
}
