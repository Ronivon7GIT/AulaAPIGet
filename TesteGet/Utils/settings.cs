using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGet.Utils
{
    public static class settings
    {
        public static IServiceProvider serviceProvider = null;

        public static void writeLog() 
        {
            ControllerLog c = new(ILog);
        }
            
    }
}
