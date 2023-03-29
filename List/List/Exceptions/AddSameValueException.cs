namespace List.Exceptions
{
    public class AddSameValueException : Exception
    {
        public AddSameValueException() { }
        public AddSameValueException(string message) : base(message) { }
        public AddSameValueException(string message, Exception inner) : base(message, inner) { }
        protected AddSameValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
