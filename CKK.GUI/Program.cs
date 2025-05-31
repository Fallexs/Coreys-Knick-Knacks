using CKK.Logic.Models;
using CKK.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var Store = new FileStore();
            using (var login = new LoginPage()) {
                if (login.ShowDialog() == DialogResult.OK) {
                    Application.Run(new HomePage(Store));
                }
            }
        }
    }
}
