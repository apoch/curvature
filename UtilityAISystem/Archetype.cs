using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Archetype : INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public List<BehaviorSet> BehaviorSets;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        public Archetype(string name)
        {
            ReadableName = name;
            BehaviorSets = new List<BehaviorSet>();
        }

        public override string ToString()
        {
            return ReadableName;
        }

        public string GetName()
        {
            return ReadableName;
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
            DialogRebuildNeeded?.Invoke();
        }
    }
}
