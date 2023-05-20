namespace program
{
    //stack based on an array realization
    public class StackBasedOnArray : IStack
    {

        int size = 0;
        double[] stackArray = new double[128];
        public bool isEmpty { get { return size == 0; } }

        //gets value from stack
        public (bool, double) Pop()
        {
            if (size == 0)
            {
                return (false, double.MinValue);
            }
            --size;
            return (true, stackArray[size]);
        }

        // adds value to stack
        public void Push(double value)
        {
            if (size == stackArray.Length)
            {
                Array.Resize(ref stackArray, stackArray.Length * 2);
            }

            stackArray[size] = value;
            ++size;
        }
    }
}
