using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    class InputParameter
    {
        public string ReadableName;
        public float MinimumValue;
        public float MaximumValue;

        public InputParameter(string name, float min, float max)
        {
            ReadableName = name;
            MinimumValue = min;
            MaximumValue = max;
        }
    }
}
