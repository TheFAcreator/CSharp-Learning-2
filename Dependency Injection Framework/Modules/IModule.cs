using System;

namespace Dependency_Injection_Framework.Modules
{
    public interface IModule
    {
        void Configure();
        Type GetMapping(Type currentInterface, object attribute);
        object GetInstance(Type currentClass);
        void SetInstance(Type currentClass, object instance);
    }
}
