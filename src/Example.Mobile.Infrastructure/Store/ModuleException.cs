﻿using System;
using System.Runtime.Serialization;

namespace Example.Mobile.Infrastructure.Store
{
    public class ModuleException : Exception
    {
        public ModuleException()
        {
        }

        public ModuleException(string message) : base(message)
        {
        }

        public ModuleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModuleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
