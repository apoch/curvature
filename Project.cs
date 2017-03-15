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
    public class Project : IUserEditable
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

            InputLookupByName = new Dictionary<string, InputAxis>();

            AddDummyInputs();
            AddDummyArchetypes();
            AddDummyBehaviors();
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


        public void PopulateUI(TreeView tree)
        {
            tree.BeginUpdate();
            tree.Nodes.Clear();

            var root = tree.Nodes.Add(ReadableName);
            root.Tag = this;

            var kbNode = root.Nodes.Add("Knowledge Base");
            kbNode.Tag = KB;

            var inputsFolder = root.Nodes.Add("Inputs");
            var archetypesFolder = root.Nodes.Add("Archetypes");
            var behaviorsFolder = root.Nodes.Add("Behaviors");
            var behaviorSetsFolder = root.Nodes.Add("Behavior Sets");

            foreach (Archetype archetype in Archetypes)
            {
                var node = archetypesFolder.Nodes.Add(archetype.ReadableName);
                node.Tag = archetype;
            }

            foreach (InputAxis axis in Inputs)
            {
                var node = inputsFolder.Nodes.Add(axis.ReadableName);
                node.Tag = axis;
            }

            foreach (Behavior behavior in Behaviors)
            {
                var node = behaviorsFolder.Nodes.Add(behavior.ReadableName);
                node.Tag = behavior;

                foreach (Consideration consideration in behavior.Considerations)
                {
                    var cnode = node.Nodes.Add(consideration.ReadableName);
                    cnode.Tag = consideration;
                }
            }

            foreach (BehaviorSet set in BehaviorSets)
            {
                var node = behaviorSetsFolder.Nodes.Add(set.ReadableName);
                node.Tag = set;
            }

            root.Expand();
            inputsFolder.Expand();
            archetypesFolder.Expand();
            behaviorsFolder.Expand();
            behaviorSetsFolder.Expand();

            tree.EndUpdate();
        }


        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetProject(this);
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


        private void AddDummyInputs()
        {
            var kbrecHealth = new KnowledgeBase.Record("Health", 0.0, 1.0, false);
            var kbrecDistance = new KnowledgeBase.Record("Distance to target", 0.0, 1e6, true);

            KB.Records.Add(kbrecDistance);
            KB.Records.Add(kbrecHealth);

            {
                var axis = new InputAxis("Distance to target", InputAxis.OriginType.ComputedValue);
                axis.KBRecord = kbrecDistance;
                axis.Parameters.Add(new InputParameter("Range", 0.0f, 1e5f));
                RegisterInput(axis);
            }

            {
                var axis = new InputAxis("My health", InputAxis.OriginType.PropertyOfSelf);
                axis.KBRecord = kbrecHealth;
                axis.Parameters.Add(new InputParameter("Limit", 0.0f, 1.0f));
                RegisterInput(axis);
            }
        }

        private void AddDummyArchetypes()
        {
            {
                var archetype = new Archetype("Tank");
                Archetypes.Add(archetype);
           }
        }

        private void AddDummyBehaviors()
        {
            var attackBehavior = new Behavior("Attack");

            {
                var c = new Consideration("As long as healthy");
                c.Input = InputLookupByName["My health"];
                c.Curve = new ResponseCurve(ResponseCurve.CurveType.Linear, 1.0, 0.0, 0.0, 0.0);
                c.Parameters.AddRange(c.Input.Parameters);
                attackBehavior.Considerations.Add(c);
            }
            {
                var c = new Consideration("Prioritize closer targets");
                c.Input = InputLookupByName["Distance to target"];
                c.Curve = new ResponseCurve(ResponseCurve.CurveType.Linear, -1.0, 0.0, 0.0, 1.0);
                c.Parameters.AddRange(c.Input.Parameters);
                attackBehavior.Considerations.Add(c);
            }

            Behaviors.Add(attackBehavior);

            {
                var s = new BehaviorSet("Combat");
                s.EnabledBehaviors.Add(attackBehavior);
                BehaviorSets.Add(s);
            }
        }
    }
}
