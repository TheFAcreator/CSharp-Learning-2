using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            StringBuilder result = new();

            Type type = Type.GetType(className);
            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {type.BaseType.Name}");

            MethodInfo[] privateMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MethodInfo method in privateMethods)
            {
                result.AppendLine(method.Name);
            }

            return result.ToString().TrimEnd();
        }
    }
}

