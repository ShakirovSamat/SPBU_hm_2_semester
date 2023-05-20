using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree
{
    public class NumberNode : INode
{
        public double Value { get; private set; }
        public NumberNode(double value)
        {
            Value = value;
        }

        /// <summary>
        /// returns value
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return Value;
        }

        /// <summary>
        /// resturs value in string
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return Value.ToString();
        }
    }
}
