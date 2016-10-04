using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 文件夹加锁工具精美版;

namespace 文件夹加锁工具精美版
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
