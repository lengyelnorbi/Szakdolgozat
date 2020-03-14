using System;
using System.Runtime.Serialization;

namespace Szakdolgozat.Repository
{
    [Serializable]
    internal class TaroloException : Exception
    {
        public TaroloException()
        {
        }

        public TaroloException(string message) : base(message)
        {
        }

        public TaroloException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TaroloException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}