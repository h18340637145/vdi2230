﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Login;
using WindowsFormsApp1.MutiBoltsConnVdiCal;

namespace WindowsFormsApp1
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
            //Application.Run(new JiHeParamFrm());
            //Application.Run(new MutliBoltsDesginForm());
            Application.Run(new FrmSplash());

        }
    }
}
