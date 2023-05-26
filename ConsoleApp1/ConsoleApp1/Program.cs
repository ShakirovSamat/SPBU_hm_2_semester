// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 4; ++i)
{
    Console.WriteLine(8 * Math.Pow(Math.Pow(2, i), 4) - 6 * Math.Pow(Math.Pow(2, i), 3) + 6 * Math.Pow(2, i) - 1);
    if (8 * Math.Pow(Math.Pow(2, i),4) - 6* Math.Pow(Math.Pow(2, i),3) + 6 * Math.Pow(2, i) -1 ==  0)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine(8 * Math.Pow(Math.Pow(2, i), 4) + 6 * Math.Pow(Math.Pow(2, i), 3) - 6 * Math.Pow(2, i) - 1);
    if (8 * Math.Pow(Math.Pow(2, i), 4) + 6 * Math.Pow(Math.Pow(2, i), 3) - 6 * Math.Pow(2, i) - 1 == 0)
    {
        Console.WriteLine(i);
    }
}
