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
            if (string.IsNullOrEmpty(ReadableName))
                return "(Untitled)";

            return ReadableName;
        }

        internal double Score(IInputBroker broker)
        {
            double compensationFactor = 1.0 - (1.0 / (double)Considerations.Count);
            double result = Weight;
            foreach (Consideration c in Considerations)
            {
                double considerationScore = c.Score(broker);
                double modification = (1.0 - considerationScore) * compensationFactor;
                considerationScore = considerationScore + (modification * considerationScore);

                result *= considerationScore;
            }

            return result;
        }

        public void Rename(string newname)
        {
            ReadableName = newname;
        }
    }
}
