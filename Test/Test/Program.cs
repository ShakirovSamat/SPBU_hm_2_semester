namespace Test
{
    class PRogram
    {
        public static void Main()
        {
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            Console.WriteLine($"10 + 10 is {b(10, 10)}");
            Console.ReadLine();

        }
    }

}