namespace Stack_and_Queue
{
    public class Queue
    {
        private const int DefaultCapacity = 4;
        private int[] buffer;
        public int Count { get; private set; }

        private int start = 0;
        private int end = -1;
        public Queue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");
            }

            buffer = new int[capacity];
            Count = 0;
        }
        public Queue() : this(DefaultCapacity) { }

        public void Enqueue(int item)
        {
            if (Count == buffer.Length)
            {
                Resize();
            }

            end = (end + 1) % buffer.Length;
            buffer[end] = item;
            Count++;
        }

        public int Peek()
        {
            IsEmpty();
            return buffer[start];
        }

        public int Dequeue()
        {
            IsEmpty();

            int item = buffer[start];

            buffer[start] = default; // Clear the reference for garbage collection
            start = (start + 1) % buffer.Length;
            Count--;

            return item;
        }

        public int[] ToArray()
        {
            int[] result = new int[Count];

            if (start <= end)
            {
                Array.Copy(buffer, start, result, 0, Count);
            }
            else
            {
                int firstPartLength = buffer.Length - start;
                Array.Copy(buffer, start, result, 0, firstPartLength);
                Array.Copy(buffer, 0, result, firstPartLength, end + 1);
            }

            return result;
        }

        public void Clear()
        {
            Array.Clear(buffer, 0, buffer.Length);

            start = 0;
            end = -1;
            Count = 0;
        }

        private void Resize()
        {
            int[] newBuffer = new int[buffer.Length * 2];

            if (start <= end)
            {
                Array.Copy(buffer, start, newBuffer, 0, Count);
            }
            else
            {
                int firstPartLength = buffer.Length - start;
                Array.Copy(buffer, start, newBuffer, 0, firstPartLength);
                Array.Copy(buffer, 0, newBuffer, firstPartLength, end + 1);
            }

            buffer = newBuffer;
            start = 0;
            end = Count - 1;
        }

        private void IsEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
        }
    }
}
