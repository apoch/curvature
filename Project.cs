using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    class Project : IUserEditable
    {
        public string ReadableName;
        public List<Archetype> Archetypes;
        public List<InputAxis> Inputs;

        private Dictionary<string, InputAxis> InputLookupByName;

        public Project()
        {
            ReadableName = "New Project";
            Archetypes = new List<Archetype>();
            Inputs = new List<InputAxis>();

            InputLookupByName = new Dictionary<string, InputAxis>();

            AddDummyInputs();
            AddDummyArchetypes();
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

            var inputsFolder = root.Nodes.Add("Inputs");
            var archetypesFolder = root.Nodes.Add("Archetypes");

            foreach (Archetype archetype in Archetypes)
            {
                var node = archetypesFolder.Nodes.Add(archetype.ReadableName);
                node.Tag = archetype;

                PopulateUIForArchetype(node, archetype);
            }

            foreach (InputAxis axis in Inputs)
            {
                var node = inputsFolder.Nodes.Add(axis.ReadableName);
                node.Tag = axis;
            }

            root.Expand();
            inputsFolder.Expand();
            archetypesFolder.Expand();

            tree.EndUpdate();
        }


        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetProject(this);
        }


        private void PopulateUIForArchetype(TreeNode node, Archetype archetype)
        {
            foreach (BehaviorSet set in archetype.BehaviorSets)
            {
                var setnode = node.Nodes.Add(set.ReadableName);
                setnode.Tag = set;

                foreach (Behavior b in set.Behaviors)
                {
                    var bnode = setnode.Nodes.Add(b.ReadableName);
                    bnode.Tag = b;

                    foreach (Consideration c in b.Considerations)
                    {
                        var cnode = bnode.Nodes.Add(c.ReadableName);
                        cnode.Tag = c;
                    }
                }
            }
        }


        private void AddDummyInputs()
        {
            {
                var axis = new InputAxis("Distance to target");
                axis.Parameters.Add(new InputParameter("Range", 0.0f, 1e10f));
                RegisterInput(axis);
            }

            {
                var axis = new InputAxis("My health");
                axis.Parameters.Add(new InputParameter("Limit", 0.0f, 1.0f));
                RegisterInput(axis);
            }
        }

        private void AddDummyArchetypes()
        {
            {
                var archetype = new Archetype("Tank");
                var behaviors = new BehaviorSet("Combat");

                {
                    var b = new Behavior("Attack");

                    {
                        var c = new Consideration("As long as healthy");
                        c.Input = InputLookupByName["My health"];
                        c.Curve = new ResponseCurve(ResponseCurve.CurveType.Linear, 1.0, 0.0, 0.0, 0.0);
                        b.Considerations.Add(c);
                    }
                    {
                        var c = new Consideration("Prioritize closer targets");
                        c.Input = InputLookupByName["Distance to target"];
                        c.Curve = new ResponseCurve(ResponseCurve.CurveType.Linear, -1.0, 0.0, 0.0, 1.0);
                        b.Considerations.Add(c);
                    }

                    behaviors.Behaviors.Add(b);
                }

                archetype.BehaviorSets.Add(behaviors);

                Archetypes.Add(archetype);
            }
        }
    }
}
