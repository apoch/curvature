using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    public class ScenarioLocation : Scenario.IScenarioMember
    {
        public string Name;
        public PointF Position;
        public float Radius;

        public HashSet<string> Tags;


        public ScenarioLocation(string name)
        {
            Name = name;

            Position = new PointF(0.0f, 0.0f);
            Radius = 1.0f;

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

        public double GetProperty(string name)
        {
            return 0.0;
        }
    }
}
