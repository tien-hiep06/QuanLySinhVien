﻿using QLSinhVienHunre;
using quanlisinhvienHUNRE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLSinhVienHunre
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new KetQuaHocPhanForm("GV1"));
            //Application.Run(new MenuADMIN());
        }
    }
}
