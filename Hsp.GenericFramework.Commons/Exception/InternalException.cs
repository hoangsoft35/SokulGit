using System;
using Hsp.GenericFramework.Commons.Exception.BaseEx;
using log4net;

namespace Hsp.GenericFramework.Commons.Exception
{
    public class InternalException : BaseException
    {
        public InternalException(int errorCode, string message, ILog log, System.Exception ex)
          : base(errorCode, message)
        {
            log.ErrorFormat("This is internal exception error something went wrong when excute the database proccessing. {0}Error code: {1}{2} Message:{3}{4} Detail:{5}", Environment.NewLine, errorCode, Environment.NewLine, message,
                Environment.NewLine, ex);
        }
    }
}