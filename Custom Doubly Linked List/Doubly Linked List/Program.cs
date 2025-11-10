// You can find an upgraded version (with generics) of this code at: Generics/Exercise/09. Custom linked list (!)
// You can find an upgraded version (with generics and IEnumerable) of this code at: Iterators and Comparators/Exercise/08. Custom linked list

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        class ListNode
        {
            public int Value { get; set; }
            public ListNode? Next { get; set; }
            public ListNode? Previous { get; set; }

            public ListNode(int value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public DoublyLinkedList(int value)
        {
            head = new ListNode(value);
            tail = head;
            Count = 1;
        }

        private ListNode? head;
        private ListNode? tail;
        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                
                ListNode? current = head;
                for(int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Value;
            }
            set
            {
                if(index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                
                ListNode? current = head;
                for(int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        public void AddFirst(int value)
        {
            if(Count == 0)
            {
                head = tail = new ListNode(value);
            }
            else
            {
                ListNode newNode = new(value);
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            Count++;
        }

        public void AddLast(int value)
        {
            if(Count == 0)
            {
                head = tail = new ListNode(value);
            }
            else
            {
                ListNode newNode = new(value);
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
        }

        public int RemoveFirst()
        {
            if(Count == 0) throw new InvalidOperationException("List is empty.");
            int value = head.Value;
            
            if(Count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }

            Count--;
            return value;
        }

        public int RemoveLast()
        {
            if(Count == 0) throw new InvalidOperationException("List is empty.");
            int value = tail.Value;
            
            if(Count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }

            Count--;
            return value;
        }

        public void ForEach(Action<int> action)
        {
            ListNode? current = head;

            while(current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public void ForEachReverse(Action<int> action)
        {
            ListNode? current = tail;
            while(current != null)
            {
                action(current.Value);
                current = current.Previous;
            }
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }

        public void Print() => ForEach(v => Console.Write(v + " "));

        public void PrintLine() => ForEach(v => Console.WriteLine(v));

        public void PrintReverse()
        {
            ListNode? current = tail;

            while(current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Previous;
            }

            Console.WriteLine();
        }

        public void PrintLineReverse()
        {
            ListNode? current = tail;

            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }

            Console.WriteLine();
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            ListNode? current = head;

            int index = 0;
            while(current != null)
            {
                array[index++] = current.Value;
                current = current.Next;
            }

            return array;
        }

        public void Insert(int index, int value)
        {
            if(index < 0 || index > Count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            if(index == 0)
            {
                AddFirst(value);
            }
            else if(index == Count)
            {
                AddLast(value);
            }
            else
            {
                ListNode newNode = new(value);
                ListNode? current = head;

                for(int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                newNode.Previous = current;
                
                if(current.Next != null)
                {
                    current.Next.Previous = newNode;
                }
                
                current.Next = newNode;
                
                Count++;
            }
        }
    }
}