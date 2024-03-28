using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain.Exceptions
{
    [Serializable]
    public class ValidacaoException : Exception
    {
        public ValidacaoException()
        {
        }

        public ValidacaoException(string? message) : base(message)
        {
        }

        public ValidacaoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ValidacaoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
