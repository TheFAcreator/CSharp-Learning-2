using Dependency_Injection_Framework.Attributes;
using Dependency_Injection_Framework.Modules;
using System;
using System.Linq;
using System.Reflection;

namespace Dependency_Injection_Framework.Injectors
{
    public class Injector
    {
        private IModule module;

        public Injector(IModule module)
        {
            this.module = module;
        }

        private bool CheckForFieldInjection<TClass>()
        {
            return typeof(TClass).GetFields((BindingFlags)62)
                .Any(f => f.GetCustomAttributes(typeof(InjectAttribute), true).Any());
        }

        private bool CheckForConstructorInjection<TClass>()
        {
            return typeof(TClass).GetConstructors()
                .Any(c => c.GetCustomAttributes(typeof(InjectAttribute), true).Any());
        }

        private TClass CreateConstructorInjection<TClass>()
        {
            var classParameter = typeof(TClass);

            if (classParameter == null)
                return default(TClass);

            var constructors = classParameter.GetConstructors();
            foreach (var constructor in constructors)
            {
                if (!CheckForConstructorInjection<TClass>())
                    continue;

                InjectAttribute inject = (InjectAttribute)constructor
                    .GetCustomAttributes(typeof(InjectAttribute), true)
                    .FirstOrDefault();

                var parameters = constructor.GetParameters();
                var constructorParams = new object[parameters.Length];

                int i = 0;
                foreach (var parameter in parameters)
                {
                    var name = parameter.GetCustomAttributes(typeof(NameAttribute), true).FirstOrDefault();

                    Type dependency = null;
                    if (name == null)
                    {
                        dependency = module.GetMapping(parameter.ParameterType, inject);
                    }
                    else
                    {
                        dependency = module.GetMapping(parameter.ParameterType, name);
                    }

                    if (parameter.ParameterType.IsAssignableFrom(dependency))
                    {
                        object instance = module.GetInstance(dependency);
                        if (instance != null)
                        {
                            constructorParams[i++] = instance;
                        }
                        else
                        {
                            instance = Activator.CreateInstance(dependency);
                            constructorParams[i++] = instance;
                            module.SetInstance(parameter.ParameterType, instance);
                        }
                    }
                }

                return (TClass)Activator.CreateInstance(classParameter, constructorParams);
            }

            return default;
        }

        private TClass CreateFieldInjection<TClass>()
        {
            var classParameter = typeof(TClass);
            var classInstance = module.GetInstance(classParameter);

            if (classInstance == null)
            {
                classInstance = Activator.CreateInstance(classParameter);
                module.SetInstance(classParameter, classInstance);
            }

            var fields = classParameter.GetFields((BindingFlags)62);
            foreach (var field in fields)
            {
                if (field.GetCustomAttributes(typeof(InjectAttribute), true).Any())
                {
                    var inject = (InjectAttribute)field
                        .GetCustomAttributes(typeof(InjectAttribute), true)
                        .FirstOrDefault();

                    Type dependency = null;

                    var name = field.GetCustomAttributes(typeof(NameAttribute), true);
                    var type = field.FieldType;

                    if (name == null)
                    {
                        dependency = module.GetMapping(type, inject);
                    }
                    else
                    {
                        dependency = module.GetMapping(type, name);
                    }

                    if (type.IsAssignableFrom(dependency))
                    {
                        object instance = module.GetInstance(dependency);
                        if (instance == null)
                        {
                            instance = Activator.CreateInstance(dependency);
                            module.SetInstance(dependency, instance);
                        }

                        field.SetValue(classInstance, instance);
                    }
                }
            }

            return (TClass)classInstance;
        }

        public TClass Inject<TClass>()
        {
            bool hasConstructorAttribute = CheckForConstructorInjection<TClass>();
            bool hasFieldAttribute = CheckForFieldInjection<TClass>();

            if (hasConstructorAttribute && hasFieldAttribute)
            {
                throw new ArgumentException("There must be either a field or a constructor with the Inject attribute.");
            }

            if (hasConstructorAttribute)
            {
                return CreateConstructorInjection<TClass>();
            }
            else if (hasFieldAttribute)
            {
                return CreateFieldInjection<TClass>();
            }

            return default;
        }
    }
}
