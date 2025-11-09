namespace Stack_and_Queue
{
    public class LinkedStack
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node top;
        public int Count { get; private set; }

        public LinkedStack()
        {
            top = null;
            Count = 0;
        }

        public void Push(int item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;

            Count++;
        }

        public int Peek()
        {
            IsEmpty();

            return top.Value;
        }

        public int Pop()
        {
            IsEmpty();
            int item = top.Value;
            top = top.Next;
            Count--;
            return item;
        }

        public int[] ToArray()
        {
            int[] result = new int[Count];

            Node current = top;
            for (int i = 0; i < Count; i++)
            {
                result[i] = current.Value;
                current = current.Next;
            }

            return result;
        }

        public void Clear()
        {
            top = null;
            Count = 0;
        }

        private void IsEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Linked stack is empty.");
            }
        }
    }
}
