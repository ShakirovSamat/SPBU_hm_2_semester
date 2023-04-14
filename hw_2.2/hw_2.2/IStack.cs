namespace StackCalculator
{
    public interface IStack
    {
        //gets value from stack
        public bool Pop(out double result);

        // adds value to stack
        public bool Push(double value);

        // cheacks if stack is empty
        public bool isEmpty();
    }
}
