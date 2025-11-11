using Dependency_Injection_Framework.Modules;

namespace Dependency_Injection_Framework.Injectors
{
    public class DependencyInjector
    {
        public static Injector CreateInjector(IModule module)
        {
            module.Configure();
            return new Injector(module);
        }
    }
}
