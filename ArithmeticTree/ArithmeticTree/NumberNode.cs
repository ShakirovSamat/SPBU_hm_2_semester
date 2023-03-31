using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree
{
    public class NumberNode : INodeable
{
        public double Value { get; set; }
        public NumberNode(double value)
        {
            Value = value;
        }

        // returns value
        public double Calculate()
        {
            return Value;
        }

        // resturs value in string
        public string ToString()
        {
            return Value.ToString();
        }
    }
}
