using log4net;

namespace Hsp.GenericFramework.Commons.Logging
{
    public class LogManager<TObjectLog>: ILogManager<TObjectLog> where TObjectLog : class 
    {
        public LogManager()
        {
            
        }
        public ILog GetLog()
        {
            return LogManager.GetLogger(typeof(TObjectLog));
        }
    }
}
