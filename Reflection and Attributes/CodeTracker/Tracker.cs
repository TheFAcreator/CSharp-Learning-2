using System.Reflection;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor(string author)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                foreach (var method in methods)
                {
                    var attribute = method.GetCustomAttribute<AuthorAttribute>();

                    if (attribute != null && attribute.Name == author)
                        continue;

                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}