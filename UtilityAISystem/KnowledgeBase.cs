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
            public enum Parameterization
            {
                FixedRange,
                ConfigurableRange,
                Enumeration
            }

            [DataMember]
            public string ReadableName;

            [DataMember]
            public double MinimumValue;

            [DataMember]
            public double MaximumValue;

            [DataMember]
            public bool Computed;

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

            public Record(string name, double min, double max, bool computed, Parameterization param)
            {
                ReadableName = name;
                MinimumValue = min;
                MaximumValue = max;
                Computed = computed;
                Params = param;
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
