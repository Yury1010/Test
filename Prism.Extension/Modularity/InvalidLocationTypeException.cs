using System;
using System.Runtime.Serialization;

namespace ABCS.Infrastructure
{
    [Serializable]
    public class InvalidLocationTypeException : Exception
    {
        public InvalidLocationTypeException()
        {
        }

        public InvalidLocationTypeException(string message)
          : base(message)
        {
        }

        public InvalidLocationTypeException(string message, int error)
          : base(message)
        {
            this.HResult = error;
        }

        public InvalidLocationTypeException(string message, Exception innerException)
          : base(message, innerException)
        {
        }
    }
}
