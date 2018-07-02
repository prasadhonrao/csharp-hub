using System;

namespace Learn.CSharp.Language
{
    [Serializable]
    public class InvalidAccountException : Exception
    {
        public InvalidAccountException() { }

        public InvalidAccountException(string message) : base(message) { }

        public InvalidAccountException(string message, Exception innerException) : base(message, innerException) { }
    }
}
