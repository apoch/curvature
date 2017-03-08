using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    class Behavior
    {
        public string ReadableName;
        public List<Consideration> Considerations;

        public Behavior(string name)
        {
            ReadableName = name;
            Considerations = new List<Consideration>();
        }
    }
}
