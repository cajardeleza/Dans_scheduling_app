using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DansPrototype
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

            // Test for auto login
            if (!File.Exists("login"))
            {
                Application.Run(new Login());

                Application.Run(new HomeScreen());

            }
            else
            {
                // Todo: Add loading from login file
                IEnumerable<string> lines = File.ReadLines("login");
                Login.host = lines.ElementAt(0);
                Login.user = lines.ElementAt(1);
                Login.pass = lines.ElementAt(2);
                
            }


            /* string query = @"CREATE TABLE first (" + a.Columns[0] + " int(20) NOT NULL auto_increment, "
                      + a.Columns[1].ToString() + " varchar(100) NOT NULL default,
                      PRIMARY KEY (" + a.Columns[0]+")"
                      */

            DateTime current_day = DateTime.Now;
            //if
            Application.Run(new HomeScreen());
        }
    }
}
