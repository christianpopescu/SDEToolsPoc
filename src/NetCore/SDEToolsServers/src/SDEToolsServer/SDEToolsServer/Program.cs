using System;
using System.Reflection;
using log4net;

namespace SDEToolsServer
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            ThreadContext.Stacks["NDC"].Push("Main function");
            log.Info("----- SDEToolsServer - Started! ------");


        }
    }
}
