namespace RoutersNetwork
{


	public class BadFileInputException : Exception
	{
		public BadFileInputException() { }
		public BadFileInputException(string message) : base(message) { }
		public BadFileInputException(string message, BadFileInputException inner) : base(message, inner) { }
		protected BadFileInputException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
