public class BinaryHeap<T> where T : IComparable<T>
{
    private class Node
    {
        public T value;
        public int priority;
        public Node(T value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }
    }
    private List<Node> list = new List<Node>();

    public int heapSize
    {
        get
        {
            return this.list.Count();
        }
    }

    //adds value to binary heap
    public void Add(T value, int priority)
    {
        Node newNode = new Node(value, priority);
        list.Add(newNode);
        int i = heapSize - 1;
        int parent = (i - 1) / 2;

        while (i > 0 && list[parent].priority < list[i].priority)
        {
            Node temp = list[i];
            list[i] = list[parent];
            list[parent] = temp;

            i = parent;
            parent = (i - 1) / 2;
        }
    }

    //returns max element from heap
    public T getMax()
    {
        T result = list[0].value;
        list[0] = list[heapSize - 1];
        list.RemoveAt(heapSize - 1);
        return result;
    }
}