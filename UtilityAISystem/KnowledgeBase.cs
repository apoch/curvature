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
    public class KnowledgeBase
    {

        [DataContract(Namespace = "")]
        public class Record
        {
            public enum Prefabs
            {
                NoPrefab,
                Distance,
                SimulationTime,
            }

            public enum Parameterization
            {
                FixedRange,
                ConfigurableRange,
                Enumeration
            }

            [DataMember]
            public string ReadableName;

            [DataMember]
            public bool Computed;

            [DataMember]
            public double MinimumValue;

            [DataMember]
            public double MaximumValue;

            [DataMember]
            public List<string> EnumerationValues;

            [DataMember]
            public Prefabs Prefab;


            [DataMember]
            private Parameterization Parameters;

            public Parameterization Params
            {
                get { return Parameters; }
                set
                {
                    Parameters = value;
                    PropertyChanged?.Invoke(this, null);
                }
            }


            public delegate void PropertyChangedHandler(object o, EventArgs a);
            public event PropertyChangedHandler PropertyChanged;


            internal Record()
            {
            }

            public Record(string name, bool computed, Parameterization param)
            {
                ReadableName = name;
                Computed = computed;
                Params = param;
                Prefab = Prefabs.NoPrefab;

                MinimumValue = 0.0;
                MaximumValue = 1.0;
            }

            public override string ToString()
            {
                return ReadableName;
            }
        }

        [DataMember]
        internal List<Record> Records;


        public KnowledgeBase()
        {
            Records = new List<Record>();
        }
    }
}
