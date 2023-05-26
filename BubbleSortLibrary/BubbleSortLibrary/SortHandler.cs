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
        private static void Swap<T>(int first, int second, List<T> list)
        {
            T temporary = list[first];
            list[first] = list[second];
            list[second] = temporary;
        }

        /// <summary>
        /// sorts list with data type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static List<T> BubbleSort<T>(List<T> list, IComparer<T> comparer)
        {
            List<T> sortedList = list;
            for (int i = 0; i < sortedList.Count; ++i)
            {
                for (int j = 0; j < sortedList.Count - i - 1; ++j)
                {
                    if (comparer.Compare(sortedList[j], sortedList[j + 1]) > 0)
                    {
                        Swap(j, j + 1, sortedList);
                    }
                }
            }
            return sortedList;
        }
    }
}
