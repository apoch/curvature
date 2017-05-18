using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Curvature
{
    [DataContract(Namespace = "")]
    public class Project : INameable
    {
        [DataMember]
        public string ReadableName;

        [DataMember]
        public KnowledgeBase KB;

        [DataMember]
        public List<Archetype> Archetypes;

        [DataMember]
        public List<Behavior> Behaviors;

        [DataMember]
        public List<BehaviorSet> BehaviorSets;

        [DataMember]
        public List<InputAxis> Inputs;

        [DataMember]
        public List<Scenario> Scenarios;


        internal class ProjectEventArgs : EventArgs
        {
            internal IUserEditable Editable;
        }

        internal delegate void NavigationEventHandler(object sender, ProjectEventArgs args);
        internal event NavigationEventHandler Navigate;


        private Dictionary<string, InputAxis> InputLookupByName;

        public Project()
        {
            ReadableName = "New Project";
            KB = new KnowledgeBase();
            Archetypes = new List<Archetype>();
            Inputs = new List<InputAxis>();
            Behaviors = new List<Behavior>();
            BehaviorSets = new List<BehaviorSet>();
            Scenarios = new List<Scenario>();

            InputLookupByName = new Dictionary<string, InputAxis>();
        }


        internal void NavigateTo(IUserEditable editable)
        {
            Navigate(this, new ProjectEventArgs() { Editable = editable });
        }

        public void RegisterInput(InputAxis axis)
        {
            Inputs.Add(axis);
            InputLookupByName.Add(axis.ReadableName, axis);
        }

        public string GenerateNewInputAxisName()
        {
            string newname = "New input";

            int counter = 2;
            while (InputLookupByName.ContainsKey(newname))
            {
                newname = $"New input {counter}";
                ++counter;
            }

            return newname;
        }

        public void Rename(string name)
        {
            ReadableName = name;
        }


        public void SaveToFile(string filename)
        {
            var settings = new DataContractSerializerSettings();
            settings.PreserveObjectReferences = true;

            var serializer = new DataContractSerializer(typeof(Project), settings);

            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;

            var file = XmlWriter.Create(new FileStream(filename, FileMode.Create), xmlSettings);

            serializer.WriteObject(file, this);
            file.Close();
        }

        public static Project Deserialize(string filename)
        {
            var settings = new DataContractSerializerSettings();
            settings.PreserveObjectReferences = true;

            var deserializer = new DataContractSerializer(typeof(Project), settings);

            var file = new FileStream(filename, FileMode.Open);
            var ret = deserializer.ReadObject(file) as Project;

            file.Close();

            return ret;
        }
    }
}
