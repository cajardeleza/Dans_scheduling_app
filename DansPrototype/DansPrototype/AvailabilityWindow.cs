using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections;
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
        private MySqlDataReader dr;

        private List<int> days = new List<int>();
        private List<int> availability = new List<int>();
        private ArrayList db_dates = new ArrayList();
        private String ID; 

        public AvailabilityWindow()
        {
            InitializeComponent();

            Location = new Point(Screen.FromControl(this).Bounds.Width - Width, 0);
        }

        private void AvailabilityWindow_Load(object sender, EventArgs e)
        {
            // Restrict dates to current month
            comboBox1.Items.Clear();
            selectedList.Items.Clear();
            DateTime date = DateTime.Today;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            monthCalendar1.MaxDate = lastDayOfMonth;
            monthCalendar1.MinDate = firstDayOfMonth;


            // Refresh currently selected
            monthCalendar1.SetDate(firstDayOfMonth);

            cmd.Connection = cn;
            }

        private void AvailabilityWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void UpdateData(object sender)
        {
            // Update everything

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HomeScreen().Show();
            Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void getSelectedDates(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//submit availability
        {

            db_dates.ToArray();

            cn.Open();
            for(int i=0; i<db_dates.Count; i++)
            {
                
                if(i%2==0)
                {
                    
                    cmd.CommandText = "UPDATE employees SET day"+db_dates[0]+"='"+db_dates[i+1]+"' where id_num ='"+ID+"'";
                    cmd.ExecuteNonQuery();
                   

        }


           }
            cn.Close();




       }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = true;
            selectedList.Enabled = true;
            amBtn.Enabled = true;
            pmBtn.Enabled = true;
            submitBtn.Enabled = true;
           selectedList.Items.Clear();
           days.Clear();
           availability.Clear();

           string employee = (string) comboBox1.SelectedItem;
           int size = employee.Length;


           employee.ToCharArray();

           for(int i =0; i < size; i++)
           {
               if (employee[i].Equals(' '))
               {
                   i = size; 
               }

               else
               {
                   ID += employee[i];
               }

           }






        }

        private void fill_combo_box(string position)
        {
            comboBox1.Items.Clear();
            cn.Open();
            cmd.CommandText = "select * from employees where Employee_position = '" + position + "'";
           dr = cmd.ExecuteReader();

            var count = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (count == 0)
                        {
                            comboBox1.Text = dr[1].ToString() + " " + dr[2].ToString();
                        }

                        comboBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
                        count++;
                    }
                }
                cn.Close();
            
        }

        private void add_to_comboBox()
        {
            List<string> positions = new List<string>();
            if (serverBtn.Checked)
                positions.Add("Server");
            if (bartenderBtn.Checked)
                positions.Add("Bartender");
            if (busBtn.Checked)
                positions.Add("Bus");
            if (hostBtn.Checked)
                positions.Add("Host");
            if (expoBtn.Checked)
                positions.Add("Expo");
            if (managerBtn.Checked)
                positions.Add("Manager");

            
            // if no filters are selected, do nothing
            if (positions.Count == 0)
                return;

            cn.Open();
            //cmd.CommandText = "select * from employees where Employee_position=";
            if (positions.Count == 1)
            {
                cmd.CommandText = "select * from employees where Employee_position='" + positions[0] + "'";
            }

            else
            {

                cmd.CommandText = "select * from employees where Employee_position in ('" + positions[0] + "'";
                //WHERE id in (3,4)
                for (var i = 1; i < positions.Count; i++)
                {
                    cmd.CommandText += ",'" + positions[i] + "'";
                }


                cmd.CommandText += ")";
            }


            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   
                   comboBox1.Items.Add(dr[0] + "     " +dr[1].ToString() + " " + dr[2].ToString());
                   
                    
                }
            }
            cn.Close();

        }

        private void serverBtn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            //fill_combo_box("Server");
            add_to_comboBox();
        }

        private void bartenderBtn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            //fill_combo_box("Bartender");
            add_to_comboBox();
        }

        private void busBtn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            //fill_combo_box("Bus");
            add_to_comboBox();
        }

        private void hostBtn_CheckedChanged(object sender, EventArgs e)
            {
            comboBox1.Items.Clear();
            //fill_combo_box("Host");
            add_to_comboBox();
        }

        private void expoBtn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            //fill_combo_box("Expo");
            add_to_comboBox();
        }

        private void managerBtn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            //fill_combo_box("Manager");
            add_to_comboBox();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;
            // check in-between dates
            for (var i = start.Day; i <= end.Day; i++)
            {
                DateTime day = start.AddDays(start.Day - i);
                int index = days.IndexOf(i);
                if (index == -1) // add to list
            {
                    days.Add(i);
                   monthCalendar1.AddBoldedDate(day);
                    availability.Add(0);
                   db_dates.Add(i);
                   db_dates.Add(0);
               } else
                {
                    days.RemoveAt(index);
                   monthCalendar1.RemoveBoldedDate(day);
                    availability.RemoveAt(index);
                   db_dates.RemoveAt(index);
                   db_dates.RemoveAt(index+1);
                }
                }
            // sort
            ArrayList sort = new ArrayList();
            foreach (var o in days)
                {
                sort.Add(o);
                }

            sort.Sort();

            selectedList.Items.Clear();
            foreach (var i in sort)
            {
                selectedList.Items.Add(i);
            }


       }

      private void pmBtn_CheckedChanged(object sender, EventArgs e)

           //1 = working, 2 = am off, 3 = pm off, 0= off all day. 
       {
            int day = (int)selectedList.SelectedItem;

            int i = int.Parse(ID);
            int amday = db_dates.IndexOf(day) + 1;


            db_dates.Insert((db_dates.IndexOf(day) + 1), 2);
            db_dates.RemoveAt(db_dates.IndexOf(day) + 2);
            }

        private void amBtn_CheckedChanged(object sender, EventArgs e)
        {
            int day = (int)selectedList.SelectedItem;
            
            int i = int.Parse(ID);
            int amday = db_dates.IndexOf(day)+1;

            
            db_dates.Insert((db_dates.IndexOf(day) + 1),2);
            db_dates.RemoveAt(db_dates.IndexOf(day) + 2);

            //Console.WriteLine(amday);
            

            //foreach(var a in )
            /*cn.Open();


            cmd.CommandText = "update employees set " + day +"=2 where id_num =" +i+"";
            cmd.ExecuteNonQuery();
            cn.Close();
            */
        }
    }
}
