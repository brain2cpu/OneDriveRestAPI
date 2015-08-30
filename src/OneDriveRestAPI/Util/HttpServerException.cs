using System;

namespace OneDriveRestAPI.Util
{
    public class HttpServerException : Exception
    {
        private int hr;
        private int httpCode;

        public HttpServerException(string message) : base(message)
        {
        }

        public HttpServerException()
        {
        }

        public HttpServerException(string message, int hr) : base(message)
        {
            this.hr = hr;
        }

        public HttpServerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public HttpServerException(int httpCode, string message, Exception innerException) : base(message, innerException)
        {
            this.httpCode = httpCode;
        }

        public HttpServerException(int httpCode, string message, int hr) : base(message)
        {
            this.httpCode = httpCode;
            this.hr = hr;
        }

        public HttpServerException(int httpCode, string message) : base(message)
        {
            this.httpCode = httpCode;
        }

        public int? Attempts { get; set; }
    }
}