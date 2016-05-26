using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(executable);
#if DEBUG
            path = Directory.GetParent(Directory.GetParent(System.IO.Path.GetDirectoryName(executable)).ToString()).ToString();
#endif 
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
