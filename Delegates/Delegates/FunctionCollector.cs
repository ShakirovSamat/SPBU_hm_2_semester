using System.Reflection.Metadata.Ecma335;

namespace Delegates
{
    public static class FunctionCollector
    {
        public static List<int> Map(List<int> list, Func<int, int> map)
        {
            var result = new List<int>();
            for (int i = 0; i < list.Count; ++i)
            {
                result.Add(map(list[i]));
            }
            return result;
        }

        public static List<int> Filter(List<int> list, Func<int, bool> filter)
        {
            var result = new List<int>();
            foreach (int x in list)
            {
                if (filter(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public static int Fold(List<int> list, int accumulator, Func<int, int, int> fold)
        {
            foreach (int x in list)
            {
                accumulator = fold(x, accumulator);
            }
            return accumulator;
        }
    }
}
