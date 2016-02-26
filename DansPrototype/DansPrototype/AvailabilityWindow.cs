using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DansPrototype
{
    public partial class AvailabilityWindow : Form
    {
        MySqlConnection cn = new MySqlConnection(@"server=localhost;user id=root;password=Inception2194;database=dans_test;persistsecurityinfo=True");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public AvailabilityWindow()
        {
            InitializeComponent();
        }

        private void AvailabilityWindow_Load (object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            new HomeScreen().Show();
            this.Hide();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void getSelectedDates(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//submit availability
        {

        }

        /*private void fillComboBox()
        {
            comboBox1.Items.Clear();
            cn.Open();
            cmd.CommandText = "select * from employees";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    comboBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString());

                }
            }
            cn.Close();


        }
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand("SELECT Employee_FirstName from employees WHERE Employee_position = 'Server' ");
            try
            {
                cn.Open();
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
                }
                dr.Close();
                dr.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AvailabilityWindow_Load_1(object sender, EventArgs e)
        {

        }
    }
}
