using log4net;

namespace PrinterTonerCheck.Helpers
{
    public static class LogManager
    {
        public static ILog MyLogger()
        {
            log4net.Config.BasicConfigurator.Configure();
            return log4net.LogManager.GetLogger(typeof(LogManager));
        }
    }
}
