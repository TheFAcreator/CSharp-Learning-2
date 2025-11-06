using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder result = new();

            FieldInfo[] fields = Type.GetType(className)!.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if (field.IsPublic) 
                    result.AppendLine(field.Name + " must be private!");
            }

            PropertyInfo[] properties = Type.GetType(className)!.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var property in properties)
            {
                if(property.GetMethod.IsPrivate)
                    result.AppendLine(property.GetMethod.Name + " have to be public!");

                if (property.SetMethod.IsPublic)
                    result.AppendLine(property.SetMethod.Name + " have to be private!");
            }

            return result.ToString().TrimEnd();
        }
    }
}

