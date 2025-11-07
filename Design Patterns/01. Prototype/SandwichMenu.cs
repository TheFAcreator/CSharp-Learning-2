namespace Prototype
{
    public class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> sandwiches = new();

        public SandwichPrototype this[string key]
        {
            get => sandwiches[key];
            set => sandwiches[key] = value;
        }
    }
}
