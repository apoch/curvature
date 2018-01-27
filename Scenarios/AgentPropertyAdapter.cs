using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

    [TypeConverter(typeof(KBPropertyConverter))]
    class KBPropertyConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type t)
        {
            if (t == typeof(string))
                return true;

            return base.CanConvertFrom(context, t);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
                return true;

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                if (double.TryParse(value as string, out double result))
                   return result;
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
                return value.ToString();

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    class KBPropertyWrapper
    {
        Dictionary<KnowledgeBase.Record, double> PropertyDict;
        KnowledgeBase.Record Record;


        internal KBPropertyWrapper(Dictionary<KnowledgeBase.Record, double> dict, KnowledgeBase.Record key)
        {
            PropertyDict = dict;
            Record = key;
        }

        internal void SetProperty(double value)
        {
            if (value < Record.MinimumValue)
                value = Record.MinimumValue;

            if (value > Record.MaximumValue)
                value = Record.MaximumValue;

            PropertyDict[Record] = value;
        }

        public override string ToString()
        {
            return $"{PropertyDict[Record]}";
        }
    }

    class DictionaryPropertyDescriptor : PropertyDescriptor
    {
        KBPropertyWrapper Wrap;

        internal DictionaryPropertyDescriptor(Dictionary<KnowledgeBase.Record, double> dict, KnowledgeBase.Record key)
            : base(key.ReadableName, null)
        {
            Wrap = new KBPropertyWrapper(dict, key);
        }

        public override Type PropertyType
        {
            get { return typeof(KBPropertyConverter); }
        }

        public override void SetValue(object component, object value)
        {
            Wrap.SetProperty((double)value);
        }

        public override object GetValue(object component)
        {
            return Wrap;
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

        public override string Category => "Knowledge Base";
    }
}
