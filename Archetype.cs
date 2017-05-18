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

        [DataMember]
        public List<BehaviorSet> BehaviorSets;


        public Archetype(string name)
        {
            ReadableName = name;
            BehaviorSets = new List<BehaviorSet>();
        }
    }
}
