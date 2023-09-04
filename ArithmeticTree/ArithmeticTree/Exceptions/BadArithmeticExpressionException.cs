using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree.Exceptions
{

    [Serializable]
    public class BadArithmeticExpressionException : Exception
    {
        public BadArithmeticExpressionException() : base("Bad input") { }
        public BadArithmeticExpressionException(string message) : base(message) { }
        public BadArithmeticExpressionException(string message, Exception inner) : base(message, inner) { }
        protected BadArithmeticExpressionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
