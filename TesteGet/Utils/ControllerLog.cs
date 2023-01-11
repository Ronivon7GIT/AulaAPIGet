using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGet.Utils
{
    internal class ControllerLog
    {
        private readonly ILog _log;
        private string restMessage;

        public ControllerLog(ILog log)
        {
            log = log ?? throw new ArgumentNullException(nameof(log));
        }

        public string RestMessage
        {
            get 
            {
                return restMessage; 
            } 
            set
            {
                restMessage = value;
            }
        }
        public Logger writeLogCTRL() => _log.CurrentLog; 
        public void closeLogCTRL() => _log.CloseLog();
    }
}
