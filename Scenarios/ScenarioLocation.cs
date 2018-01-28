using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class ScenarioLocation : Scenario.IScenarioMember
    {
        [DataMember]
        public string Name;

        [DataMember]
        public PointF Position;

        [DataMember]
        public float Radius;

        [DataMember]
        public HashSet<string> Tags;


        public override string ToString()
        {
            return Name;
        }


        public ScenarioLocation(string name)
        {
            Name = name;

            Position = new PointF(0.0f, 0.0f);
            Radius = 2.5f;

            Tags = new HashSet<string>();
        }


        public string GetName()
        {
            return Name;
        }

        public PointF GetPosition()
        {
            return Position;
        }

        public double GetProperty(KnowledgeBase.Record kbrec)
        {
            return 0.0;
        }

        public float GetRadius()
        {
            return Radius;
        }
    }
}
