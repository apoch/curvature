using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Archetype
    {
        [DataMember]
        public string ReadableName;

        public List<BehaviorSet> BehaviorSets;

        internal Archetype()
        {
        }

        public Archetype(string name)
        {
            ReadableName = name;
            BehaviorSets = new List<BehaviorSet>();
        }
    }
}
