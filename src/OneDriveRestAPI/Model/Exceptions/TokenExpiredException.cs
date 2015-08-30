using System;
using System.Runtime.Serialization;

namespace OneDriveRestAPI.Model.Exceptions
{
    public class TokenExpiredException : Exception
    {
        public TokenExpiredException()
        {
        }

        public TokenExpiredException(string message) : base(message)
        {
        }

        public TokenExpiredException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}