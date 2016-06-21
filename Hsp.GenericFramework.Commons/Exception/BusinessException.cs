using Hsp.GenericFramework.Commons.Exception.BaseEx;

namespace Hsp.GenericFramework.Commons.Exception
{
    public class BusinessException : BaseException
    {
        public BusinessException(int errorCode, string message)
            : base(errorCode, message)
        {
        }
        public BusinessException(ExceptionMessage exceptionMessage)
            : base(exceptionMessage)
        {
        }

        public BusinessException(string message)
            : base(message)
        {
        }
    }
}