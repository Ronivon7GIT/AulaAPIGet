//using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NLog;

namespace TesteGet.Utils
{
    public sealed class LogService
    {
        private static LogService _logger = new LogService();

        private static ControllerLog _controllerLog;

        private LogService() => _controllerLog = settings.serviceProvider.GetRequiredService<ControllerLog>();
        public static LogService Current_Logger
        {
            get
            {
                return _logger ??= new LogService();
            }
        }

        public Logger Write_Log() => _controllerLog.writeLogCTRL();
        public void Close_Log() => _controllerLog.closeLogCTRL(); 
    }
}
