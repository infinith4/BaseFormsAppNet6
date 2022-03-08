using System;
using System.Windows.Forms;
using BaseFormsApp.Utils;

namespace BaseFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
}
