using System.Reflection.Metadata.Ecma335;

namespace Delegates
{
    public delegate int Map(int x);
    public delegate bool Filter(int x);
    public delegate int Fold(int x, int y);
    public static class FunctionCollector
    {
        public static List<int> Map(List<int> list, Map map)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                list[i] = map(list[i]);
            }
            return list;
        }

        public static List<int> Filter(List<int> list, Filter filter)
        {
            List<int> result = new List<int>();
            foreach (int x in list)
            {
                if (filter(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public static int Fold(List<int> list, int startValue, Fold fold)
        {
            foreach(int x in list)
            {
                startValue = fold(x, startValue);
            }
            return startValue;
        }
    }
}
