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
        public Dictionary<KnowledgeBase.Record, object> Properties;

        [DataMember]
        public Dictionary<KnowledgeBase.Record, object> StartProperties;


        public override string ToString()
        {
            return Name;
        }


        public ScenarioLocation(string name)
        {
            Name = name;

            Position = new PointF(0.0f, 0.0f);
            Radius = 2.5f;

            Properties = new Dictionary<KnowledgeBase.Record, object>();
        }


        public string GetName()
        {
            return Name;
        }

        public PointF GetPosition()
        {
            return Position;
        }

        public object GetProperty(KnowledgeBase.Record kbrec)
        {
            if (Properties == null || !Properties.ContainsKey(kbrec))
                return 0.0;

            return Properties[kbrec];
        }

        public float GetRadius()
        {
            return Radius;
        }

        public void GenerateStartProperties(KnowledgeBase kb)
        {
            var oldstarts = StartProperties;
            if (oldstarts == null)
                oldstarts = new Dictionary<KnowledgeBase.Record, object>();

            StartProperties = new Dictionary<KnowledgeBase.Record, object>();

            foreach (var rec in kb.Records)
            {
                if (rec.Computed)
                    continue;

                if (oldstarts.ContainsKey(rec))
                    StartProperties.Add(rec, oldstarts[rec]);
                else
                    StartProperties.Add(rec, rec.MinimumValue);
            }
        }
    }
}
