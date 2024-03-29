﻿using System.Runtime.Serialization;

namespace Domain.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        private string v;
        private object id;

        public NotFoundException()
        {
        }

        public NotFoundException(string? message) : base(message)
        {
        }

        public NotFoundException(string v, object id)
        {
            this.v = v;
            this.id = id;
        }

        public NotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}