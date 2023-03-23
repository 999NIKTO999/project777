using project777.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project777
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var context = new Context();
               // context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Application.Run(new Form1());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
