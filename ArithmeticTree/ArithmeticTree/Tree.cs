using ArithmeticTree.Exceptions;
using System.Runtime.CompilerServices;

namespace ArithmeticTree
{
    public class Tree
    {
        INodeable root;
        int pointer;

        public Tree(string input)
        {
            string[] inputs = input.Replace("(", "").Replace(")", "").Split(" ");
            pointer = 0;
            root = GetTreeNode(inputs[pointer]);
            ++pointer;
            BuildTree(root, inputs, ref pointer);
        }

        //gets operation or nubmer from arithmetic expression
        public INodeable GetTreeNode(string value)
        {
            if (int.TryParse(value, out int number))
            {
                return new NumberNode(number);
            }

            return new OperationNode(value);
        }

        //Builds arithmetic tree
        public void BuildTree(INodeable node, string[] inputs, ref int pointer)
        {
            if (node is NumberNode)
            {
                return;
            }

            if (pointer >= inputs.Length - 1)
            {
                throw new BadArithmeticExpressionException();
            }

            INodeable firstOperand = GetTreeNode(inputs[pointer]);
            ++pointer;
            InsertNode((OperationNode)node, firstOperand, 1, inputs, ref pointer);

            INodeable secondOperand = GetTreeNode(inputs[pointer]);
            ++pointer;
            InsertNode((OperationNode)node, secondOperand, 2, inputs, ref pointer);
        }

        // fills inforamtion into node
        public void InsertNode(OperationNode operation, INodeable operand, int position, string[] inputs, ref int pointer)
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

        // calculates aritmetic expression
        public double Calculate()
        {
            return root.Calculate();
        }

        // creates represenations of arithmetic tree
        public string ToString()
        {
            return root.ToString();
        }
    }
}
