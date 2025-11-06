using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder result = new();

            PropertyInfo[] properties = Type.GetType(className)
                .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var property in properties)
            {
                var getMethod = property.GetGetMethod(true);
                if (getMethod != null)
                {
                    result.AppendLine($"{getMethod.Name} will return {getMethod.ReturnType.FullName}");
                }

                var setMethod = property.GetSetMethod(true);
                if (setMethod != null)
                {
                    result.AppendLine($"{setMethod.Name} will set field of {setMethod.GetParameters()[0].ParameterType.FullName}");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}

