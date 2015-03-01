using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProgramRunNotifier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            if(args.Length > 2)
            {
                string path = args[1];
                string alert = args[2];

                MessageBox.Show(alert, "Alert!");

                try
                {
                    Process.Start(path);
                }
                catch
                {
                    MessageBox.Show("File not found: \n" + path, "Error");
                }

                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
