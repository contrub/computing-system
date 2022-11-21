namespace ComputingSystem.DoublyLinkedList
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        private int _data;
        public int Data 
        { 
            get { return _data; }
            set { _data = value; }
        }

        private Node? _next;
        public Node? Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private Node? _prev;
        public Node? Previous
        {
            get { return _prev; }
            set { _prev = value; }
        }
    }
}