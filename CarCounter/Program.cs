using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServer_dll;

namespace CarCounter
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary> 
        /// 连接数据库
        public static DbConnection dbc = new DbConnection("server=localhost;database=;uid=sa;pwd=lzq1998415");
        public static DbOperate dbo = new DbOperate(dbc);
        [STAThread]
        static void Main()
        {
            dbc.DbOpen();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
