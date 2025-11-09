namespace Stack_and_Queue
{
    public class LinkedQueue
    {
        private class Node
        {
            public int Value { get; set; }
            public Node? Next { get; set; }
            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

            private Node front;
            private Node rear;
            public int Count { get; private set; }
    
            public LinkedQueue()
            {
                front = null;
                rear = null;
                Count = 0;
            }
    
            public void Enqueue(int item)
            {
                Node newNode = new Node(item);

                if (rear != null) rear.Next = newNode;
                rear = newNode;
    
                if (front == null) // If the queue was empty, set front to the new node
                {
                    front = newNode;
                }
    
                Count++;
            }
    
            public int Peek()
            {
                IsEmpty();
                return front.Value;
            }
    
            public int Dequeue()
            {
                IsEmpty();

                int item = front.Value;
                front = front.Next;
                Count--;
    
                if (front == null)
                {
                    rear = null; // If the queue is empty, reset rear
                }
    
                return item;
            }
    
            public int[] ToArray()
            {
                int[] result = new int[Count];
                Node current = front;
    
                for (int i = 0; i < Count; i++)
                {
                    result[i] = current.Value;
                    current = current.Next;
                }
    
                return result;
            }
    
            public void Clear()
            {
                front = null;
                rear = null;
                Count = 0;
            }
    
            internal void IsEmpty()
            {
                if (Count == 0)
                    throw new InvalidOperationException("Linked queue is empty.");
        }
    }
}
