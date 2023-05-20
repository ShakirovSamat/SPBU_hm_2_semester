namespace program
{
    //stack based on an liked list realization
    public class StackBasedOnLinkedList : IStack
    {
        Node? head;
        internal class Node
        {
            public double Value { get; set; }
            public Node? Next {get;set;}

            public Node (double value)
            {
                this.Value = value;
            }
        }

        //gets value from stack
        public bool Pop(out double result)
        {
            result = 0;
            if (head == null)
            {
                return false;
            }

            result = head.Value;
            head = head.Next;
            return true;
        }

        // adds value to stack
        public bool Push(double value)
        {
            if (head == null)
            {
                head = new Node(value);
                return true;
            }

            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            return true;
        }

        // cheacks if stack is empty
        public bool isEmpty()
        {
            return head == null;
        }
    }
}
