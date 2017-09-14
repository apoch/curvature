using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class BehaviorSet : INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public HashSet<Behavior> EnabledBehaviors;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        internal BehaviorSet()
        {
        }

        public BehaviorSet(string name)
        {
            ReadableName = name;
            EnabledBehaviors = new HashSet<Behavior>();
        }

        public override string ToString()
        {
            return ReadableName;
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
            DialogRebuildNeeded?.Invoke();
        }

        public string GetName()
        {
            return ReadableName;
        }
    }
}
