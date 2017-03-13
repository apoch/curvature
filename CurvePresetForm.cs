using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public partial class CurvePresetForm : Form
    {
        public CurvePresetForm()
        {
            InitializeComponent();

            SuggestedPresetList.SelectedIndexChanged += (e, args) =>
            {
                PreviewBox.Refresh();
            };

            PreviewBox.Paint += (e, args) =>
            {
                if (SuggestedPresetList.Items.Count <= 0 || SuggestedPresetList.SelectedItems.Count <= 0)
                    return;

                var curve = SuggestedPresetList.SelectedItems[0].Tag as ResponseCurve;

                Point previousPoint = ConvertXYToPoint(0.0, curve.ComputeValue(0.0));

                for (double x = 0.0; x <= 1.0; x += 0.001)
                {
                    double y = curve.ComputeValue(x);
                    Point p = ConvertXYToPoint(x, y);

                    args.Graphics.DrawLine(Pens.Blue, previousPoint, p);
                    previousPoint = p;
                }
            };

            PopulateSuggestions();
        }

        private void IncreasingDecreasingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSuggestions();
        }

        private void AccelerationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSuggestions();
        }

        private void LowInputLowScoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateSuggestions();
        }

        private void LowInputHighScoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateSuggestions();
        }


        private void PopulateSuggestions()
        {
            SuggestedPresetList.Items.Clear();

            if (IncreasingDecreasingComboBox.SelectedIndex < 0 && AccelerationComboBox.SelectedIndex < 0)
            {
                SuggestConstant();
                SuggestBasicLinear();
                SuggestInverseLinear();
                SuggestCooldown();
                SuggestRuntime();
                SuggestBasicQuadricLowerLeft();
                SuggestBasicQuadricLowerRight();
                SuggestBasicQuadricUpperLeft();
                SuggestBasicQuadricUpperRight();
            }
            else if (IncreasingDecreasingComboBox.SelectedIndex == 0)
            {
                // Increase left to right

                if (AccelerationComboBox.SelectedIndex == 0)
                {
                    // Constant/linear
                    SuggestBasicLinear();
                }
                else if (AccelerationComboBox.SelectedIndex == 1)
                {
                    // Slow then fast
                    SuggestBasicQuadricLowerRight();
                    SuggestCooldown();
                }
                else if (AccelerationComboBox.SelectedIndex == 2)
                {
                    // Fast then slow
                    SuggestBasicQuadricUpperLeft();
                }
                else if (AccelerationComboBox.SelectedIndex == 3)
                {
                    // Dynamic
                }
            }
            else if (IncreasingDecreasingComboBox.SelectedIndex == 1)
            {
                // Decrease left to right

                if (AccelerationComboBox.SelectedIndex == 0)
                {
                    // Constant/linear
                    SuggestInverseLinear();
                }
                else if (AccelerationComboBox.SelectedIndex == 1)
                {
                    // Slow then fast
                    SuggestBasicQuadricUpperRight();
                    SuggestRuntime();
                }
                else if (AccelerationComboBox.SelectedIndex == 2)
                {
                    // Fast then slow
                    SuggestBasicQuadricLowerLeft();
                }
                else if (AccelerationComboBox.SelectedIndex == 3)
                {
                    // Dynamic
                }
            }
            else if (IncreasingDecreasingComboBox.SelectedIndex == 2)
            {
                // Zero slope linear

                if (AccelerationComboBox.SelectedIndex == 0)
                {
                    // Constant/linear
                    SuggestConstant();
                }
                else if (AccelerationComboBox.SelectedIndex == 1)
                {
                    // Slow then fast
                }
                else if (AccelerationComboBox.SelectedIndex == 2)
                {
                    // Fast then slow
                }
                else if (AccelerationComboBox.SelectedIndex == 3)
                {
                    // Dynamic
                }
            }
            else if (IncreasingDecreasingComboBox.SelectedIndex == 3)
            {
                // Fluctuations

                if (AccelerationComboBox.SelectedIndex == 0)
                {
                    // Constant/linear
                }
                else if (AccelerationComboBox.SelectedIndex == 1)
                {
                    // Slow then fast
                }
                else if (AccelerationComboBox.SelectedIndex == 2)
                {
                    // Fast then slow
                }
                else if (AccelerationComboBox.SelectedIndex == 3)
                {
                    // Dynamic
                }
            }

            if(SuggestedPresetList.Items.Count > 0)
                SuggestedPresetList.SelectedIndices.Add(0);
        }

        private void SuggestBasicLinear()
        {
            SuggestedPresetList.Items.Add("Basic linear").Tag = new ResponseCurve(ResponseCurve.CurveType.Linear, 1.0, 0.0, 0.0, 0.0);
        }

        private void SuggestBasicQuadricLowerLeft()
        {
            SuggestedPresetList.Items.Add("Basic quadric lower left").Tag = new ResponseCurve(ResponseCurve.CurveType.Polynomial, 1.0, 4.0, 1.0, 0.0);
        }

        private void SuggestBasicQuadricLowerRight()
        {
            SuggestedPresetList.Items.Add("Basic quadric lower right").Tag = new ResponseCurve(ResponseCurve.CurveType.Polynomial, 1.0, 4.0, 0.0, 0.0);
        }

        private void SuggestBasicQuadricUpperLeft()
        {
            SuggestedPresetList.Items.Add("Basic quadric upper left").Tag = new ResponseCurve(ResponseCurve.CurveType.Polynomial, -1.0, 4.0, 1.0, 1.0);
        }

        private void SuggestBasicQuadricUpperRight()
        {
            SuggestedPresetList.Items.Add("Basic quadric upper right").Tag = new ResponseCurve(ResponseCurve.CurveType.Polynomial, -1.0, 4.0, 0.0, 1.0);
        }

        private void SuggestInverseLinear()
        {
            SuggestedPresetList.Items.Add("Inverse linear").Tag = new ResponseCurve(ResponseCurve.CurveType.Linear, -1.0, 0.0, 0.0, 1.0);
        }

        private void SuggestConstant()
        {
            SuggestedPresetList.Items.Add("Constant").Tag = new ResponseCurve(ResponseCurve.CurveType.Linear, 0.0, 0.0, 0.0, 0.5);
        }

        private void SuggestCooldown()
        {
            SuggestedPresetList.Items.Add("Standard cooldown").Tag = new ResponseCurve(ResponseCurve.CurveType.Polynomial, 1.0, 6.0, 0.0, 0.0);
        }

        private void SuggestRuntime()
        {
            SuggestedPresetList.Items.Add("Standard runtime").Tag = new ResponseCurve(ResponseCurve.CurveType.Polynomial, -1.0, 6.0, 0.0, 1.0);
        }

        private Point ConvertXYToPoint(double x, double y)
        {
            var rect = PreviewBox.ClientRectangle;
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
