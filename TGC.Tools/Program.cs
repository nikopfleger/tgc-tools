﻿using System;
using System.Windows.Forms;
using TGC.Tools.Forms;

namespace TGC.Tools
{
    internal static class Program
    {
        /// <summary>
        ///     Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ToolsForm());
        }
    }
}