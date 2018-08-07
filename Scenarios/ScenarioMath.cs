using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature.Scenarios
{
    class ScenarioMath
    {
        public static float Distance(PointF a, PointF b)
        {
            float dx = b.X - a.X;
            float dy = b.Y - a.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public static PointF Normalize(PointF input)
        {
            float length = (float)Math.Sqrt(input.X * input.X + input.Y * input.Y);
            if (length < 0.001f)
                return new PointF(0.0f, 0.0f);

            float invlength = 1.0f / length;
            return new PointF(input.X * invlength, input.Y * invlength);
        }


        public static float Magnitude(PointF p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }
    }
}
