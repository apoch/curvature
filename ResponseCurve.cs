using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public class ResponseCurve
    {
        public enum CurveType
        {
            Linear,
            Polynomial,
            Logistic,
            Logit,
            Normal,
            Sine
        }


        public CurveType Type;
        public double Slope;
        public double Exponent;
        public double XShift;
        public double YShift;


        public ResponseCurve(CurveType type, double slope, double exponent, double xshift, double yshift)
        {
            Type = type;
            Slope = slope;
            Exponent = exponent;
            XShift = xshift;
            YShift = yshift;
        }


        public double ComputeValue(double x)
        {
            switch (Type)
            {
                case CurveType.Linear:
                    return Sanitize((Slope * (x - XShift)) + YShift);

                case CurveType.Polynomial:
                    return Sanitize((Slope * Math.Pow(x - XShift, Exponent)) + YShift);

                case CurveType.Logistic:
                    return Sanitize((Slope / (1 + Math.Exp(-10.0 * Exponent * (x - 0.5 - XShift)))) + YShift);

                case CurveType.Logit:
                    return Sanitize(Math.Log(Slope * (x - XShift) / (1.0 - (x - XShift))) / 5.0 + 0.5 + YShift);

                case CurveType.Normal:
                    break;

                case CurveType.Sine:
                    break;
            }

            return 0.0;
        }

        private double Sanitize(double y)
        {
            if (double.IsInfinity(y))
                return 0.0;

            if (double.IsNaN(y))
                return 0.0;

            return y;
        }
    }
}
