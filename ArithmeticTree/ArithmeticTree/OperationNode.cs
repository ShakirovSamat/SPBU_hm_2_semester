using ArithmeticTree.Exceptions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree
{
    public class OperationNode: INode
    {
        string operation;
        public INode First { get; set; }
        public INode Second { get; set; }


        public OperationNode(string operation)
        {
            this.operation = operation;
        }

        /// <summary>
        /// calculates binary operation
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        /// <exception cref="BadArithmeticExpressionException"></exception>
        public double Calculate()
        {
            switch (operation)
            {
                case "+":
                    return First.Calculate() + Second.Calculate();

                case "-":
                    return First.Calculate() - Second.Calculate();

                case "*":
                    return First.Calculate() * Second.Calculate();

                case "/":
                    if (Math.Abs(Second.Calculate() - 0) <= 0.000000001)
                    {
                        throw new DivideByZeroException();
                    }
                    
                    return First.Calculate() / Second.Calculate();
                
                default:
                    throw new BadArithmeticExpressionException("Only + - * / operations are allowed");

            }

            return 0;
        }

        /// <summary>
        /// creates prespresenation of binary operation
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return $"({operation} {First.ToString()} {Second.ToString()})";
        }
    }
}
