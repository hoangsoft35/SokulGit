using Hsp.GenericFramework.Commons.Exception.BaseEx;

namespace Hsp.GenericFramework.Commons.Exception
{
    public class InternalException : BaseException
    {

        public InternalException(int errorCode, string message)
            : base(errorCode, message)
        {

        }

        public InternalException(ExceptionMessage exceptionMessage)
            : base(exceptionMessage)
        {
        }
    }
}