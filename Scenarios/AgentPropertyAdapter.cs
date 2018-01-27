using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    class AgentPropertyAdapter : ICustomTypeDescriptor
    {
        private Dictionary<KnowledgeBase.Record, double> PropertyDict;

        public AgentPropertyAdapter(Dictionary<KnowledgeBase.Record, double> propdict)
        {
            PropertyDict = propdict;
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return PropertyDict;
        }

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return null;
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            return ((ICustomTypeDescriptor)this).GetProperties(new Attribute[0]);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            var properties = new List<PropertyDescriptor>();
            foreach (var kvp in PropertyDict)
                properties.Add(new DictionaryPropertyDescriptor(PropertyDict, kvp.Key));

            return new PropertyDescriptorCollection(properties.ToArray());
        }
    }

    class DictionaryPropertyDescriptor : PropertyDescriptor
    {
        Dictionary<KnowledgeBase.Record, double> PropertyDict;
        KnowledgeBase.Record Key;

        internal DictionaryPropertyDescriptor(Dictionary<KnowledgeBase.Record, double> dict, KnowledgeBase.Record key)
            : base(key.ReadableName, null)
        {

            // TODO - figure out how we can clamp the user-provided value to the KBRecord's min/max automatically here

            PropertyDict = dict;
            Key = key;
        }

        public override Type PropertyType
        {
            get { return PropertyDict[Key].GetType(); }
        }

        public override void SetValue(object component, object value)
        {
            PropertyDict[Key] = (double)value;
        }

        public override object GetValue(object component)
        {
            return PropertyDict[Key];
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type ComponentType
        {
            get { return null; }
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
