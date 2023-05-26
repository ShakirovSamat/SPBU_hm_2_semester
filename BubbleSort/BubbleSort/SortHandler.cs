namespace BubbleSort
{
    public static class SortHandler
    {
        /// <summary>
        /// swaprs two element
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private static void Swap<T>(ref T first, ref T second)
        {
            T temporary = first;
            first = second;
            second = temporary;
        }

        /// <summary>
        /// sorts array with data type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static T[] BubbleSort<T>(T[] array, IComparer<T> comparer)
        {
            T[] sortedArray = array;
            for (int i = 0; i < sortedArray.Length; ++i)
            {
                for (int j = 0; j < sortedArray.Length - i - 1; ++j)
                {
                    if (comparer.Compare(sortedArray[j], sortedArray[j + 1]) > 0)
                    {
                        Swap(ref sortedArray[j], ref sortedArray[j + 1]);
                    }
                }
            }
            return sortedArray;
        }
    }
}
