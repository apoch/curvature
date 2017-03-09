using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public class Archetype
    {
        public string ReadableName;
        public List<BehaviorSet> BehaviorSets;

        public Archetype(string name)
        {
            ReadableName = name;
            BehaviorSets = new List<BehaviorSet>();
        }
    }
}
