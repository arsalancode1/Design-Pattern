using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class SingletonPattern
    {
        public void TestSingletonPattern()
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log();
            logger2.Log();
        }
    }

    public class Logger
    {
        private static Logger logger;

        private Logger()
        {

        }

        public void Log()
        {

        }

        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
                return logger;
            }
            else
            {
                return logger;
            }
        }
    }
}
