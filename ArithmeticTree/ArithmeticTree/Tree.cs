using ArithmeticTree.Exceptions;
using System.Runtime.CompilerServices;

namespace ArithmeticTree
{
    public class Tree
    {
        INode root;
        int pointer;

        public Tree(string input)
        {
            string[] inputs = input.Replace("(", "").Replace(")", "").Split(" ", StringSplitOptions.RemoveEmptyEntries);
            pointer = 0;
            root = GetTreeNode(inputs[pointer]);
            ++pointer;
            BuildTree(root, inputs, ref pointer);
        }

        /// <summary>
        /// gets operation or nubmer from arithmetic expression
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public INode GetTreeNode(string value)
        {
            if (int.TryParse(value, out int number))
            {
                return new NumberNode(number);
            }

            return new OperationNode(value);
        }

        /// <summary>
        /// Builds arithmetic tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="inputs"></param>
        /// <param name="pointer"></param>
        /// <exception cref="BadArithmeticExpressionException"></exception>
        public void BuildTree(INode node, string[] inputs, ref int pointer)
        {
            if (node is NumberNode)
            {
                return;
            }

            if (pointer >= inputs.Length - 1)
            {
                throw new BadArithmeticExpressionException();
            }

            INode firstOperand = GetTreeNode(inputs[pointer]);
            ++pointer;
            InsertNode((OperationNode)node, firstOperand, 1, inputs, ref pointer);

            INode secondOperand = GetTreeNode(inputs[pointer]);
            ++pointer;
            InsertNode((OperationNode)node, secondOperand, 2, inputs, ref pointer);

            if (pointer < inputs.Length - 1)
            {
                throw new BadArithmeticExpressionException("");
            }
        }

        /// <summary>
        /// fills inforamtion into node
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="operand"></param>
        /// <param name="position"></param>
        /// <param name="inputs"></param>
        /// <param name="pointer"></param>
        /// <exception cref="BadArithmeticExpressionException"></exception>
        public void InsertNode(OperationNode operation, INode operand, int position, string[] inputs, ref int pointer)
        {
            if (pointer > inputs.Length)
            {
                throw new BadArithmeticExpressionException("Wrong input");
            }
            if (operand is OperationNode)
            {
                BuildTree(operand, inputs, ref pointer);
            }

            if (position == 1)
            {
                operation.First = operand;
            }
            else
            {
                operation.Second = operand;
            }
        }

        /// <summary>
        /// calculates aritmetic expression
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return root.Calculate();
        }

        /// <summary>
        /// creates represenations of arithmetic tree
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return root.ToString();
        }
    }
}
