using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public class BehaviorSet
    {
        public string ReadableName;
        public List<Behavior> Behaviors;

        public BehaviorSet(string name)
        {
            ReadableName = name;
            Behaviors = new List<Behavior>();
        }
    }
}
