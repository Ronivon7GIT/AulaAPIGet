using NLog;

namespace TesteGet.Utils
{
    public class Log: ILog
    {
        private Logger _logger = null;

        public Logger CurrentLog 
        {
            get
            {
                if (_logger == null) 
                {
                    _logger = LogManager.GetCurrentClassLogger();
                    GlobalDiagnosticsContext.Set("logDirectory", Path.Combine(Directory.GetCurrentDirectory().Split("\\bin")[0], @"log"));
                }
                return _logger;
            } 
        }

        public void CloseLog() 
        {
            if (_logger == null)
            {
                LogManager.Shutdown();
                _logger = null;

            }
        }

    }
}
