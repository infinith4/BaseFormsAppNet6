using BaseFormsApp.Utils;

namespace BaseFormsApp
{
    public partial class Form1 : Form
    {
        private readonly LogUtil logUtil = new LogUtil();
        public Form1()
        {
            this.logUtil.InfoLog("Start App.");
            this.InitializeComponent();
            this.logUtil.InfoLog("InitializeComponent");
        }
    }
}