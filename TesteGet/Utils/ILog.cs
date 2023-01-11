using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGet.Utils
{
    internal interface ILog
    {
        public Logger CurrentLog { get; }

        public void CloseLog();

    }
}
