﻿using System;
using System.Runtime.Serialization;

namespace DongFeng.Jellyfish
{
    [Serializable]
    public class HandlerException : Exception
    {
        public HandlerException()
        {
        }

        public HandlerException(string message) : base(message)
        {
        }

        public HandlerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HandlerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
