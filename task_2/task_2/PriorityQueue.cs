namespace program
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        BinaryHeap<T> binaryHeap = new BinaryHeap<T>();

        public bool Empty { get { return binaryHeap.heapSize == 0; } }

        //adds value to queue
        public void Enqueue(T value, int priority)
        {
            binaryHeap.Add(value, priority);
        }

        // returns element with max priority
        public T Dequeue()
        {
            return binaryHeap.getMax();
        }
    }
}
