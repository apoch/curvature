using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    class ResponseCurve
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
                    return (Slope * (x - XShift)) + YShift;

                case CurveType.Polynomial:
                    return (Slope * Math.Pow(x - XShift, Exponent)) + YShift;

                case CurveType.Logistic:
                    break;

                case CurveType.Logit:
                    break;

                case CurveType.Normal:
                    break;

                case CurveType.Sine:
                    break;
            }

            return 0.0;
        }
    }
}
