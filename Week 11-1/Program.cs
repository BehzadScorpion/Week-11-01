using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_11_1
{
    public static class Program
    {
        public static StartForm startform;
        public static MainForm mainform;
        public static AboutForm aboutform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startform = new StartForm();
            mainform = new MainForm();
            aboutform = new AboutForm();

            Application.Run(startform);
        }
    }
}
