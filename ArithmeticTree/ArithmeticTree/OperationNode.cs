using ArithmeticTree.Exceptions;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree
{
    public class OperationNode: INodeable
    {
        string operation;
        public INodeable? First { get; set; }
        public INodeable? Second { get; set; }


        public OperationNode(string operation)
        {
            this.operation = operation;
        }

        // calculates binary operation
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
                    if (Second.Calculate().Equals(0))
                    {
                        throw new DivideByZeroException();
                    }
                    
                    return First.Calculate() / Second.Calculate();
                
                default:
                    throw new BadArithmeticExpressionException("Only + - * / operations are allowed");

            }

            return 0;
        }

        // creates prespresenation of binary operation
        public string ToString()
        {
            return $"({operation} {First.ToString()} {Second.ToString()})";
        }
    }
}
