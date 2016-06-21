using System;
using log4net;

namespace Hsp.GenericFramework.Commons.Logging
{
    public interface ILogManager
    {
        ILog GetLog(Type typeAssociatedWithRequestedLog);
    }
}
