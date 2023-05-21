namespace program
{
    public class List
    {
        Node? head;
        protected class Node
        {
            public int value;
            public Node? next;
        }

        public int Count { get; private set; }

        /// <summary>
        /// adds element to list
        /// </summary>
        /// <param name="value"></param>
        virtual public void Add(int value)
        {
            if (head == null)
            {
                head = new Node();
                head.value = value;
                return;
            }

            Node currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = new Node();
            currentNode.next.value = value;
            ++Count;
        }

        /// <summary>
        /// deletes element from list
        /// </summary>
        /// <param name="value"></param>
        virtual public void Delete(int value)
        {
            if (head == null)
            {
                return;
            }

            if (head.value == value)
            {
                head = head.next;
                return;
            }

            Node? currentNode = head.next;
            Node previousNode = head;


            while (currentNode != null)
            {
                if (currentNode.value == value)
                {
                    --Count;
                    previousNode.next = currentNode.next;
                    return;
                }

                previousNode = currentNode;
                currentNode = currentNode.next;

            }
        }

        /// <summary>
        /// resetes element at particular index to another
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        virtual public void Reset(int index, int value)
        {
            if (head == null || index < 0)
            {
                throw new IndexOutOfRangeException("Element with that index is not exist");
            }

            Node? currentNode = head;
            for (int i = 0; i < index; ++i)
            {
                currentNode = currentNode.next;
                if (currentNode == null)
                {
                    return;
                }
            }
            currentNode.value = value;
        }

        /// <summary>
        /// returns true if list contains this element
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(int value)
        {
            Node? currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.value == value)
                {
                    return true;
                }
                currentNode = currentNode.next;
            }

            return false;
        }

        /// <summary>
        /// prints the list
        /// </summary>
        public void print()
        {
            Node? currentNode = head;
            Console.Write("List: ");
            while (currentNode != null)
            {
                Console.Write($"{currentNode.value} ");
                currentNode = currentNode.next;
            }

            Console.WriteLine();
        }
    }
}
