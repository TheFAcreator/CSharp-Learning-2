namespace Stack_and_Queue
{
    public class Stack
    {
        private const int DefaultCapacity = 4;
        private int[] buffer;
        public int Count { get; private set; }

        public Stack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");
            }

            buffer = new int[capacity];
            Count = 0;
        }
        public Stack(): this(DefaultCapacity) { }

        public void Push(int item)
        {
            if (Count == buffer.Length)
            {
                Resize();
            }

            buffer[Count++] = item;
        }

        public int Peek()
        {
            IsEmpty();

            return buffer[Count - 1];
        }

        public int Pop()
        {
            IsEmpty();
            int item = buffer[--Count];
            buffer[Count] = default; // Clear the reference for garbage collection
            return item;
        }

        public int[] ToArray()
        {
            int[] result = new int[Count];
            Array.Copy(buffer, result, Count);

            return result;
        }

        public void Clear()
        {
            Array.Clear(buffer, 0, Count);
            Count = 0;
        }

        internal void IsEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        private void TrimExcess()
        {
            if (Count < buffer.Length / 4)
            {
                int[] newBuffer = new int[buffer.Length / 2];
                Array.Copy(buffer, newBuffer, Count);
                buffer = newBuffer;
            }
        }

        private void Resize()
        {
            int[] newBuffer = new int[buffer.Length * 2];
            Array.Copy(buffer, newBuffer, Count);
            buffer = newBuffer;
        }
    }
}
