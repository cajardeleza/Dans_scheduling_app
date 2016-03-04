using MySql.Data.MySqlClient;
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
            }
            else
            {
                IEnumerable<string> lines = File.ReadLines("login");
                Login.host = lines.ElementAt(0);
                Login.user = lines.ElementAt(1);
                Login.pass = lines.ElementAt(2);
            }

            // check for new table and recreate table if it is a new month
            MySqlConnection cn = new MySqlConnection(@"server=" + Login.host + ";user id=" + Login.user + ";password=" + Login.pass + ";database=dans_test;persistsecurityinfo=True");
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SHOW TABLES LIKE 'employees'");
            cmd.Connection = cn;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                cmd.CommandText = @"CREATE TABLE employees (id_num INT(11) NOT NULL auto_increment";
            }
            cn.Close();

            DateTime dt = DateTime.Now;

                Application.Run(new HomeScreen());
            }
        }
    }
