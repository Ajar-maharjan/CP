using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockmgmtsystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*User user = new User();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool checkuser = user.CheckUserExist();
            if (checkuser == true)
               Application.Run(new InitialRegister());
            else
               Application.Run(new Login());*/
            Application.Run(new StockReport());
        }
    }
}
