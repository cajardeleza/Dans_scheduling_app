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
        public delegate void UpdateDataHandler(object sender);
        public event UpdateDataHandler OnUpdateData;

        private MySqlConnection cn = new MySqlConnection(@"server=" + Login.host + ";user id=" + Login.user + ";password=" + Login.pass + ";database=dans_test;persistsecurityinfo=True");
        private MySqlCommand cmd = new MySqlCommand();

        public AvailabilityWindow()
        {
            InitializeComponent();
        }

        private void AvailabilityWindow_Load (object sender, EventArgs e)
        {
            // Restrict dates to current month
            DateTime date = DateTime.Today;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            monthCalendar1.MinDate = firstDayOfMonth;
            monthCalendar1.MaxDate = lastDayOfMonth;

            // Refresh currently selected
            monthCalendar1.SetDate(firstDayOfMonth);

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

        public void UpdateData(object sender)
        {
            // Update everything

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

        private void AvailabilityWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;
            // check in-between dates
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                if (Selected.Items.Contains(dt))
                {
                    Selected.Items.Remove(dt);
                }
                else
                {
                    Selected.Items.Add(dt);
                }

            }
        }
    }
}
