namespace program
{
    public interface IStack
    {
        // cheacks if stack is empty
        public bool isEmpty { get; }
        //gets value from stack
        public (bool, double) Pop();

        // adds value to stack
        public void Push(double value);
    }
}
