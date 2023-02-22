using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Services
{
    [Serializable]
    internal class DbConcurrencyException : System.Exception
    {
        public DbConcurrencyException()
        {
        }

        public DbConcurrencyException(string message) : base(message)
        {
        }

        public DbConcurrencyException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected DbConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}