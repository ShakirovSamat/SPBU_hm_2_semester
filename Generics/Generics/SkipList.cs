using System.Collections;

namespace Generics
{
    public class SkipList<T> : System.Collections.Generic.IList<T> where T : IComparable<T>
    {
        const int MAX_LEVEL = 5;
        int currentMaxLevel = 1;
        Node[] head = new Node[MAX_LEVEL + 1];

        private class Node
        {
            public Node? next, down;
            public T value;

            public Node(T value)
            {
                this.value = value;
            }
            public Node()
            {

            }
        }

        public SkipList()
        {
            for (int i = 0; i <= MAX_LEVEL; ++i)
            {
                head[i] = new Node();
                if (i > 1)
                {
                    head[i].down = head[i - 1];
                }
            }
        }

        private int GetRandomLevel()
        {
            int level = 1;
            Random random = new Random();
            while (random.NextDouble() < 0.5 && level < MAX_LEVEL)
            {
                ++level;
            }
            return level;
        }

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T value)
        {
            ++Count;
            //behavior if list is empty
            if (head[currentMaxLevel].next == null)
            {
                int level = GetRandomLevel();
                for (int i = 1; i <= level; ++i)
                {
                    Node newNode = new Node(value);
                    newNode.down = head[i - 1].next;
                    head[i].next = newNode;
                }
                currentMaxLevel = level;
                return;
            }

            //behavior if value < every value in array
            if (head[1].next.value.CompareTo(value) > 0)
            {
                int level = GetRandomLevel();
                for (int i = 1; i <= level; ++i)
                {
                    Node newNode = new Node(value);
                    newNode.down = head[i - 1].next;
                    newNode.next = head[i].next;
                    head[i].next = newNode;
                }

                if (currentMaxLevel < level)
                {
                    currentMaxLevel = level;
                }
                return;
            }

            Node?[] update = new Node[MAX_LEVEL + 1];
            update[0] = new Node();
            Node currentNode = head[currentMaxLevel];
            for (int i = currentMaxLevel; i >= 1; --i)
            {
                while (currentNode.next != null && currentNode.next.value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.next;
                }

                update[i] = currentNode;
                if (currentNode.down != null)
                {
                    currentNode = currentNode.down;
                }
            }

            int lev = GetRandomLevel();
            if (lev > currentMaxLevel)
            {
                currentMaxLevel = lev;
            }
            for (int i = 1; i <= lev; ++i)
            {
                Node newNode = new Node(value);
                if (update[i] == null)
                {
                    newNode.down = update[i - 1].next;
                    head[i].next = newNode;
                    update[i] = head[i];
                    continue;
                }
                newNode.next = update[i].next;
                update[i].next = newNode;
                newNode.down = update[i - 1].next;
            }

        }

        public void Clear()
        {
            Count = 0;
            currentMaxLevel = 1;
            for (int i = 0; i <= MAX_LEVEL; ++i)
            {
                head[i] = new Node();
                if (i > 1)
                {
                    head[i].down = head[i - 1];
                }
            }
        }

        public bool Contains(T value)
        {
            Node currentNode = head[currentMaxLevel];
            for (int i = currentMaxLevel; i >= 1; --i)
            {
                while (currentNode.next != null && currentNode.next.value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.next;
                }

                if (currentNode.down != null)
                {
                    currentNode = currentNode.down;
                }
            }

            if (currentNode.next == null)
            {
                return false;
            }

            return currentNode.next.value.CompareTo(value) == 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentException();
            }

            if (array.Rank != 1)
            {
                throw new ArgumentException();
            }

            if (array.Length - arrayIndex < Count)
            {
                throw new ArgumentException();
            }

            if (array.GetType().GetElementType() is not T)
            {
                throw new ArgumentException();
            }

            Node currentNode = head[1].next;
            int i = 0;
            while (currentNode != null)
            {
                array[arrayIndex + i] = currentNode.value;
                currentNode = currentNode.next;
                ++i;
            }

        }

        public int IndexOf(T value)
        {
            Node currentNode = head[1].next;
            int i = 0;
            while (currentNode != null)
            {
                if (currentNode.value.CompareTo(value) == 0)
                {
                    return i;
                }
                currentNode = currentNode.next;
                ++i;
            }
            return -1;
        }

        public void Insert(int index, T value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T value)
        {
            //removing first element in the list
            if (head[1].next != null && head[1].next.value.CompareTo(value) == 0)
            {
                for (int i = 1; i <= currentMaxLevel; ++i)
                {
                    if (head[i].next == null || head[i].next.value.CompareTo(value) != 0)
                    {
                        break;
                    }

                    head[i].next = head[i].next.next;
                }

                for (int i = currentMaxLevel; i >= 1; --i)
                {
                    if (head[i].next != null)
                    {
                        currentMaxLevel = i;
                        break;
                    }
                }
                --Count;
                return true;
            }

            Node?[] update = new Node[MAX_LEVEL + 1];
            update[0] = new Node();
            Node currentNode = head[currentMaxLevel];
            for (int i = currentMaxLevel; i >= 1; --i)
            {
                while (currentNode.next != null && currentNode.next.value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.next;
                }

                update[i] = currentNode;
                if (currentNode.down != null)
                {
                    currentNode = currentNode.down;
                }
            }

            if (currentNode.next != null && currentNode.next.value.CompareTo(value) == 0)
            {
                for (int i = 1; i <= currentMaxLevel; ++i)
                {
                    if (update[i].next == null || update[i].next.value.CompareTo(value) != 0)
                    {
                        break;
                    }

                    update[i].next = update[i].next.next;
                }

                for (int i = currentMaxLevel; i >= 1; --i)
                {
                    if (head[i].next != null)
                    {
                        currentMaxLevel = i;
                        break;
                    }
                }
                --Count;
                return true;
            }


            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentException();
            }

            Node currentNode = head[1].next;
            for (int i = 0; i < index; ++i)
            {
                currentNode = currentNode.next;
            }
            T value = currentNode.value;
            Remove(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)new SkipListEnum(head[1]);
        }

        private class SkipListEnum : IEnumerator<T>
        {
            Node currentNode;
            Node head;
            public SkipListEnum(Node head)
            {
                currentNode = head;
                this.head = head;
            }
            public object Current { get { return currentNode.value; } }

            T IEnumerator<T>.Current { get { return currentNode.value; } }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                currentNode = currentNode.next;
                return currentNode != null;
            }

            public void Reset()
            {
                currentNode = head;
            }
        }
    }
}
