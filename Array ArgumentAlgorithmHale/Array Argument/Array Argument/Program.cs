﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Array_Argument
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArrayArgumentSorted());
        }
    }
}
