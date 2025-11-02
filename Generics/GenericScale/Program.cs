namespace GenericScale
{
    public class EqualityScale<T> where T : unmanaged
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            return Equals(left, right);
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            
        }
    }
}