using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Evemu_DB_Editor
{
    static class Program
    {
        public static frMain m;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m = new frMain();
            Application.Run(m);
        }
    }
}
