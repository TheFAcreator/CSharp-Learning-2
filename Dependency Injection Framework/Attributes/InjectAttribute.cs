using System;

namespace Dependency_Injection_Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Field)]
    public class InjectAttribute : Attribute
    {

    }
}
