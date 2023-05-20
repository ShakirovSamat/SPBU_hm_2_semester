using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Exceptions
{
	[Serializable]
	public class ResetingToAldreadyExisingElementException : Exception
	{
		public ResetingToAldreadyExisingElementException() { }
		public ResetingToAldreadyExisingElementException(string message) : base(message) { }
		public ResetingToAldreadyExisingElementException(string message, Exception inner) : base(message, inner) { }
		protected ResetingToAldreadyExisingElementException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
