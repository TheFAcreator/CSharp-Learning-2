using System;

namespace Dependency_Injection_Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
