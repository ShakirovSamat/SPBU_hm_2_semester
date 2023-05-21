using System.Reflection.Metadata.Ecma335;

namespace Delegates
{
    // заменить делигаты на анонимыные функции
    public delegate int Map(int x);
    public delegate bool Filter(int x);
    public delegate int Fold(int x, int y);
    public static class FunctionCollector
    {
        //возвращать новый список, не менять старый список
        public static List<int> Map(List<int> list, Func<int ,int> map)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                list[i] = map(list[i]);
            }
            return list;
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

        public static int Fold(List<int> list, int accumulator, Fold fold)
        {
            foreach(int x in list)
            {
                accumulator = fold(x, accumulator);
            }
            return accumulator;
        }
    }
}
