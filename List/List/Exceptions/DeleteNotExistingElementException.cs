namespace List.Exceptions
{

	[Serializable]
	public class DeleteNotExistingElementException : Exception
	{
		public DeleteNotExistingElementException() { }
		public DeleteNotExistingElementException(string message) : base(message) { }
		public DeleteNotExistingElementException(string message, Exception inner) : base(message, inner) { }
		protected DeleteNotExistingElementException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
