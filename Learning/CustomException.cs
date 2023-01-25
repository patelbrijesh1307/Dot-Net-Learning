using System;
using System.IO;
using System.Runtime.Serialization;

namespace Learning
{
    class CustomException
    {
        
    }
[Serializable]
    class NewCustomException : Exception
    {
        public NewCustomException() : base()
        {
        }
        public NewCustomException(string message) : base(message)
        {
        }
        public NewCustomException(string message, Exception innerexception) : base(message, innerexception)
        {
        }

        public NewCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
