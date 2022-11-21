using System.Collections;

namespace ComputingSystem.DoublyLinkedList
{
    public class LinkedList : IEnumerable<Node>
    {
        private Node? head;
        public Node? First => head;

        private Node? tail;
        public Node? Last => tail;

        public int Length
        {
            get;
            private set;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            Node? current = head;
            
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable GetEnumeratorReverse()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current;
                current = current.Previous;
            }
        }

        public void Add(int data)
        {
            Node newNode = new(data);
            
            if (tail == null) 
            {
                head = newNode;
            }
            else 
            {
                newNode.Previous = tail;
                tail.Next = newNode;
            }
        }

        public void AddFirst(int data)
        {
            Node? newNode = new(data)
            {
                Next = head
            };

            if (head == null)
            {
                tail = newNode;
            }
            else
            {
                head.Previous = newNode;
            }

            head = newNode;
            Length++;
        }

        public bool Contains(int value)
        {
            Node? current = head;

            while (current != null)
            {
                if (current.Data == value) return true;

                current = current.Next;
            }

            return false;
        }

        public Node? Find(int value)
        {
            Node? current = head;

            while (current != null) 
            {
                if (current.Data == value) return current;
            
                current = current.Next;
            }

            return null;
        }

        public Node? FindLast(int value) 
        {
            Node? current = tail;

            while (current != null)
            {
                if (current.Data == value) return current;

                current = current.Previous;
            }

            return null;
        }

        public bool Remove(int value) 
        {
            Node? current = head;

            while (current != null)
            {
                if (current.Data != value) return false;

                // end of list
                if (current.Next == null)
                {
                    // removing item in the list
                    tail = current.Previous;
                }
                else
                {
                    current.Next.Previous = current.Previous;
                }

                // start of the line 
                if (current.Previous == null)
                {
                    head = current.Next;
                }
                else
                {
                    // tie the nodes back together
                    current.Previous.Next = current.Next;
                }

                current = null;
                Length--;
                return true;
            }

            return false;
        }

        public void RemoveFirst()
        {
            if (head == null) return;

            head = head.Next;

            if (head == null) tail = null;

            Length--;
        }

        public void RemoveLast()
        {
            if (tail == null) return;

            tail = tail.Previous;

            if (tail == null) head = null;

            Length--;
        }
    }
}
