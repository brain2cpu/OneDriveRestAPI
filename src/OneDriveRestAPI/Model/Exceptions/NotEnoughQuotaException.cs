﻿using System;

namespace OneDriveRestAPI.Model.Exceptions
{
    public class NotEnoughQuotaException : Exception
    {
        public NotEnoughQuotaException()
        {
        }

        public NotEnoughQuotaException(string message)
            : base(message)
        {
        }

        public NotEnoughQuotaException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}