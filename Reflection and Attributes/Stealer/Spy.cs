using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, string[] fields)
        {
            StringBuilder result = new("Class under investigation: " + className);
            result.AppendLine();

            Type type = Type.GetType(className)!;
            object instance = Activator.CreateInstance(type)!;

            foreach (var field in fields)
            {
                FieldInfo fieldInfo = type.GetField(field, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)!;
                result.AppendLine(fieldInfo.Name + " = " + fieldInfo.GetValue(instance));
            }

            return result.ToString().TrimEnd();
        }
    }
}
