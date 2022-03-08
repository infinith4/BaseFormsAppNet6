using BaseFormsApp.Utils;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config.xml", Watch = true)]
namespace BaseFormsApp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }

    private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        //UIスレッド以外での予期しない例外発生時にプロセスを落とす
        try
        {
            var logUtil = new LogUtil();
            logUtil.ErrorLog("Failed CollectLogs.Application_UnhandledException: ", (Exception)e.ExceptionObject);
        }
        finally
        {
            Environment.Exit(1);
        }
    }
}
