using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties()
                .Where(p => p.CustomAttributes
                .Any(c => typeof(MyValidationAttribute).IsAssignableFrom(c.AttributeType))).ToArray();

            foreach (var property in properties)
            {
                IEnumerable<MyValidationAttribute> attributes = property
                    .GetCustomAttributes()
                    .Where(a => typeof(MyValidationAttribute).IsAssignableFrom(a.GetType()))
                    .Cast<MyValidationAttribute>();

                foreach (var attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
