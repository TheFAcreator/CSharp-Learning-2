namespace Template
{
    public abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the {0} bread.", GetType().Name);
        }

        public void Prepare()
        {
            MixIngredients();
            Console.WriteLine();

            Bake();
            Console.WriteLine();

            Slice();
            Console.WriteLine();

            Console.WriteLine("The {0} bread is ready to be served!", GetType().Name);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
