using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new GlobalState();
            DataBase.Connect("localhost", "postgres", "11111111", "storage");
            Application.Run(new LoginForm());
        }
        
    }
}
