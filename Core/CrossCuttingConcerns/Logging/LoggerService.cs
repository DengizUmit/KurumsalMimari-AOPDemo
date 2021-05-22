using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
}
