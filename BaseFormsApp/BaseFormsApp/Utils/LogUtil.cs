using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFormsApp.Utils;

public class LogUtil
{
    private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    public void InfoLog(object message)
    {
        this.logger.Info(message);
    }

    public void ErrorLog(object message, Exception exception)
    {
        this.logger.Error(message, exception);
    }
}