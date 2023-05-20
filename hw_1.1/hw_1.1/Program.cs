using System;

class Program
{
    static void Swap(int[] array, int firstIndex, int secondIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }

    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; ++i)
        {
            for (int j = 0; j < array.Length - i - 1; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                }
            }
        }
    }
    static void Main(string[] args)
    {
        int length = -1;
        bool isNumber = false;

        while (length <= 0 || !isNumber)
        {
            Console.Write("Enter length of the array:");
            string number = Console.ReadLine();
            isNumber = int.TryParse(number, out length);
            if (!isNumber)
            {
                Console.WriteLine("Wrong input. Please, enter positive number");
            }
        }

        var array = new int[length];

        for (int i = 0; i < length; ++i)
        {
            isNumber = false;

            while (true)
            {
                Console.Write($"Enter {i + 1} number: ");
                string number = Console.ReadLine();
                isNumber = int.TryParse(number, out array[i]);

                if (isNumber && array[i] >= 0)
                {
                    break;
                }
                Console.WriteLine("Wrong input. Please, enter positive number");
            }
        }

        BubbleSort(array);

        Console.Write("Sorted array: ");
        for (int i = 0; i < length; ++i)
        {
            Console.Write($"{array[i]} ");
        }
    }
}