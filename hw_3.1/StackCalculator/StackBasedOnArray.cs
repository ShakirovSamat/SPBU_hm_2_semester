namespace program
{
    //stack based on an array realization
    public class StackBasedOnArray: IStack
    {

        int head = 0;
        double[] stackArray = new double[128];

        //gets value from stack
        public bool Pop(out double  result)
        {
            if (head == 0)
            {
                result = 0;
                return false;
            }
            --head;
            result = stackArray[head];
            return true;
        }

        // adds value to stack
        public bool Push(double value)
        {
            if (head == stackArray.Length)
            {
                Array.Resize(ref stackArray, stackArray.Length * 2);
            }

            stackArray[head] = value;
            ++head;
            return true;
        }

        // cheacks if stack is empty
        public bool isEmpty()
        {
            return head == 0;
        }
    }
}
