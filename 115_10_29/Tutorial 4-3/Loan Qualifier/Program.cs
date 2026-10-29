using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 樣式並啟動主表單。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
