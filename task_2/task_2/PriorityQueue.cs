namespace program
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        BinaryHeap<T> binaryHeap = new BinaryHeap<T>();

        public bool Empty { get { return binaryHeap.heapSize == 0; } }

        public void Enqueue(T value, int priority)
        {
            binaryHeap.Add(value, priority);
        }

        public T Dequeue()
        {
            return binaryHeap.getMax();
        }
    }
}
