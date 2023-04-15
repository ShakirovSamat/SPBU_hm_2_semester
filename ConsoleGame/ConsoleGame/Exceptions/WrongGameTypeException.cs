[Serializable]
public class WrongGameTypeException : Exception
{
	public WrongGameTypeException() { }
	public WrongGameTypeException(string message) : base(message) { }
	public WrongGameTypeException(string message, Exception inner) : base(message, inner) { }
	protected WrongGameTypeException(
	  System.Runtime.Serialization.SerializationInfo info,
	  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}