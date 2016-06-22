using System;
using log4net;

namespace Hsp.GenericFramework.Commons.Logging
{
    public interface ILogManager<TObjectLog>  where TObjectLog : class 
    {
        ILog GetLog();
    }
}
