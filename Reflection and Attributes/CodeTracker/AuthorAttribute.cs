namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
