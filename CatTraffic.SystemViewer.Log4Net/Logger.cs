using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace CatTraffic.SystemViewer.Log4Net
{
    public class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static Logger()
        {
            XmlConfigurator.Configure(new FileInfo("Log4net.config"));
        }

        public static void LogInformation(string message)
        {
            Log.Info(message);
        }

        public static void LogError(string message)
        {
            Log.Error(message);
        }

        public static void LogFatal(string message)
        {
            Log.Fatal(message);
        }

        public static void LogDebug(string message)
        {
            Log.Debug(message);
        }

        public static void LogWarn(string message)
        {
            Log.Warn(message);
        }
    }
}
