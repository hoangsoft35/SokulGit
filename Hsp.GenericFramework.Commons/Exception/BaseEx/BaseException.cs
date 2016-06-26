using System.Collections;

namespace Hsp.GenericFramework.Commons.Exception.BaseEx
{
    using System;
    public class BaseException : Exception
    {
        public ExceptionMessage ExceptionMessage { get; set; }

        public BaseException(int errorCode, string message)
        {
            ExceptionMessage = new ExceptionMessage
            {
                ErrorCode = errorCode,
                ErrorMessage = message
            };

         
        }



        public BaseException(ExceptionMessage exceptionMessage)
        {
            ExceptionMessage = exceptionMessage;
        }

        public BaseException(string message)
        {
            ExceptionMessage = new ExceptionMessage
            {
                ErrorMessage = message
            };
        }
        

    }
}