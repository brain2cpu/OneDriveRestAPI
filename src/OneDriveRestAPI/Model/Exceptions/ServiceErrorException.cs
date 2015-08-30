using System;

namespace OneDriveRestAPI.Model.Exceptions
{
    public class ServiceErrorException : Exception
    {
        public ServiceErrorException()
        {
        }

        public ServiceErrorException(string code)
        {
            Code = code;
        }

        public ServiceErrorException(string code, string message)
            : base(message)
        {
            Code = code;
        }

        public ServiceErrorException(string code, string message, Exception innerException)
            : base(message, innerException)
        {
            Code = code;
        }

        public string Code { get; set; }
    }
}