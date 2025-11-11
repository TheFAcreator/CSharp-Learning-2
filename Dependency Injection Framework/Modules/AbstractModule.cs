using Dependency_Injection_Framework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dependency_Injection_Framework.Modules
{
    public abstract class AbstractModule : IModule
    {
        private Dictionary<Type, Dictionary<string, Type>> classes;
        private Dictionary<Type, object> instances;

        protected AbstractModule()
        {
            classes = new Dictionary<Type, Dictionary<string, Type>>();
            instances = new Dictionary<Type, object>();
        }

        protected void CreateMapping<TInterface, TClass>()
        {
            if (!classes.ContainsKey(typeof(TInterface)))
            {
                classes[typeof(TInterface)] = new Dictionary<string, Type>();
            }
            classes[typeof(TInterface)].Add(typeof(TClass).Name, typeof(TClass));
        }

        public abstract void Configure();

        public Type GetMapping(Type currentInterface, object attribute)
        {
            var currentImplementation = classes[currentInterface];

            Type type = null;

            if (attribute is InjectAttribute)
            {
                if (currentImplementation.Count == 1)
                {
                    type = currentImplementation.Values.First();
                }
                else
                {
                    throw new ArgumentException("No mapping available for " + currentInterface.FullName);
                }
            }
            else if (attribute is NameAttribute)
            {
                type = currentImplementation[(attribute as NameAttribute).Name];
            }

            return type;
        }

        public object GetInstance(Type currentClass)
        {
            instances.TryGetValue(currentClass, out object instance);
            return instance;
        }

        public void SetInstance(Type currentClass, object instance)
        {
            if (!instances.ContainsKey(currentClass))
            {
                instances.Add(currentClass, instance);
            }
        }
    }
}
