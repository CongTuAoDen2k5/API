using System;

namespace DAO.ExceptionHandle
{
    public class ExceptionHandle : Exception
    {
        public ExceptionHandle()
        {
        }

        public ExceptionHandle(string message)
            : base(message)
        {
        }

        public ExceptionHandle(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}