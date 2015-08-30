using System;

namespace OneDriveRestAPI.Model.Exceptions
{
    public class RetryLaterException : Exception
    {
        public RetryLaterException()
        {
        }

        public RetryLaterException(string message)
            : base(message)
        {
        }

        public RetryLaterException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public int? RetryAfter { get; set; }
    }
}