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
    public class Behavior : IUserEditable, INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public List<Consideration> Considerations;

        [DataMember]
        public double Weight;


        internal Behavior()
        {
        }

        public Behavior(string name)
        {
            ReadableName = name;
            Considerations = new List<Consideration>();
            Weight = 1.0;
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetBehavior(this);
        }

        public override string ToString()
        {
            return ReadableName;
        }

        internal double Score(IInputBroker broker)
        {
            double result = Weight;
            foreach (Consideration c in Considerations)
            {
                result *= c.Score(broker);
            }

            return result;
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
        }
    }
}
