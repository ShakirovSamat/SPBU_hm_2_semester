namespace program
{
    //stack based on an liked list realization
    public class StackBasedOnLinkedList : IStack
    {
        Node? head;
        public bool isEmpty { get { return head == null; } }
        internal class Node
        {
            public double Value { get; set; }
            public Node? Next { get; set; }

            public Node(double value)
            {
                this.Value = value;
            }
        }

        //gets value from stack
        public (bool, double) Pop()
        {
            if (head == null)
            {
                return (false, double.MinValue);
            }

            double result = head.Value;
            head = head.Next;
            return (true, result);
        }

        // adds value to stack
        public void Push(double value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }
    }
}
