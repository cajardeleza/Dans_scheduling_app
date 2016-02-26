using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DansPrototype
{
    public partial class Login : Form
    {
        public static string host = "";
        public static string user = "";
        public static string pass = "";

        public Login()
        {
            InitializeComponent();
            AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            host = hostText.Text;
            user = userText.Text;
            pass = passText.Text;

            loginButton.Enabled = false;
            // test connection
            MySqlConnection cn = new MySqlConnection(@"server=" + host + ";user id=" + user + ";password=" + pass + ";database=dans_test;persistsecurityinfo=True");
            try {
                cn.Open();
                cn.Close();
                if (checkBox1.Checked) // save login info
                {
                    using(StreamWriter newTask = new StreamWriter("login", false))
                    {
                        newTask.WriteLine(host);
                        newTask.WriteLine(user);
                        newTask.WriteLine(pass);
                    }
                }
                Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loginButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
