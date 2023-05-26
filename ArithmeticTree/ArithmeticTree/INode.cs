namespace ArithmeticTree
{
    public interface INode
    {
        /// <summary>
        /// calculates node 
        /// </summary>
        /// <returns></returns>
        public double Calculate();

        /// <summary>
        /// writes node
        /// </summary>
        /// <returns></returns>
        public string ToString();
    }
}
