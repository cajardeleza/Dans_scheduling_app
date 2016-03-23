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
    public partial class CalendarWindow : Form
    {
        public delegate void UpdateDataHandler(object sender);
        public event UpdateDataHandler OnUpdateData;

        private MySqlConnection cn = new MySqlConnection(@"server=" + Login.host + ";user id=" + Login.user + ";password=" + Login.pass + ";database=dans_test;persistsecurityinfo=True");
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader dr;

        private List<int> days = new List<int>();
        private List<int> availability = new List<int>();
        //these two arrays will hold the emplyee names and the id so that I can find the id for each employee to update database
        private ArrayList available_employees = new ArrayList();
        private ArrayList available_IDs = new ArrayList();

        private ArrayList am_employees = new ArrayList();
        private ArrayList pm_Employees = new ArrayList();

        private ArrayList db_dates = new ArrayList();
        private String ID;
        private int selected_day;
        private String employee; 

        public CalendarWindow()
        {
            InitializeComponent();
        }

        private void calanderWindow_Load(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            

            DateTime date = DateTime.Today;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            monthCalendar1.MaxDate = lastDayOfMonth;
            monthCalendar1.MinDate = firstDayOfMonth;

            pmBtn.Enabled = false;
            am_Btn.Enabled = false;
            doubleBtn.Enabled = false;
            
            


            // Refresh currently selected
            monthCalendar1.SetDate(firstDayOfMonth);

            cmd.Connection = cn;
        }

        private void CalendarWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

   
        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;
            // check in-between dates

            selected_day = start.Day;
            Console.Write(selected_day);
            for (var i = start.Day; i <= end.Day; i++)
            {
                DateTime day = start.AddDays(start.Day - i);
                //Console.WriteLine(day);

                int index = days.IndexOf(i);
                if (index == -1) // add to list
                {
                    days.Add(i);
                    monthCalendar1.AddBoldedDate(day);
                    availability.Add(0);
                    db_dates.Add(i);
                    db_dates.Add(0);
                }
                else
                {
                    days.RemoveAt(index);
                    monthCalendar1.RemoveBoldedDate(day);
                    availability.RemoveAt(index);
                    db_dates.RemoveAt(index);
                    db_dates.RemoveAt(index + 1);
                }
            }
            // sort
            ArrayList sort = new ArrayList();
            foreach (var o in days)
            {
                sort.Add(o);
            }

            sort.Sort();

            if (serverBtn.Checked|| bartenderBtn.Checked || expoBtn.Checked||hostBtn.Checked||busBtn.Checked||managerBtn.Checked)
            {
                listBox3.Items.Clear();
                add_to_availableBox(selected_day);
            }


        }

       
        private void add_to_availableBox(int day)
        {
            
            Console.Write("available");
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
                cmd.CommandText = "select * from employees where Employee_position='" + positions[0] + "'and day" + selected_day + "='1'"; ;
            }

            else {
                cmd.CommandText = "select * from employees where Employee_position in ('" + positions[0] +"'";
                //WHERE id in (3,4)
                for (var i = 1; i < positions.Count; i++)
                {
                    cmd.CommandText += ",'" + positions[i] + "'";
                }

                cmd.CommandText += ") and day"+selected_day+"='1'";

            }
                
            


            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    listBox3.Items.Add(dr[0] + "  " + dr[1].ToString() + " " + dr[2].ToString());


                }
            }
            cn.Close();


        }
        

       

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen home = new HomeScreen();
            home.Show();
            this.Hide();

            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //listBox3.Items.Add("working");
            //fill_combo_box("Server");
            add_to_availableBox(selected_day);
            checkListBox();
        }

        private void bartenderBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //fill_combo_box("Bartender");
            add_to_availableBox(selected_day);
            checkListBox();
        }

        private void busBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //fill_combo_box("Bus");
            add_to_availableBox(selected_day);
            checkListBox();
        }

        private void expoBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //fill_combo_box("Expo");
            add_to_availableBox(selected_day);
            checkListBox();
        }

        private void hostBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //fill_combo_box("Host");
            add_to_availableBox(selected_day);
            checkListBox();
        }

        private void managerBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //fill_combo_box("Manager");
            add_to_availableBox(selected_day);
        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ID = "";

            if (listBox3.Items.Count > 0)
            {
                string emp = (string)listBox3.SelectedItem;

                employee = emp;
                selected_Employee.Text = emp;
                int size = emp.Length;


            emp.ToCharArray();


                for (int i = 0; i < size; i++)
                {
                    if (emp[i].Equals(' '))
                    {
                        i = size;
                    }

                    else
                    {
                        ID += emp[i];
                    }

                }
            }
            Console.Write(ID);
            pmBtn.Enabled = true;
            am_Btn.Enabled = true;
            doubleBtn.Enabled = true;

        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(employee);
            listBox2.Items.Add(employee);
            listBox3.Items.Remove(employee);

            //cn.Open();
            //cmd.CommandText = 
        }

        private void pmBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(employee);
            listBox3.Items.Remove(employee);
        }

        private void am_Btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(employee);
            listBox3.Items.Remove(employee);
        }

        private void checkListBox()
        {
            int pmlist = listBox2.Items.Count;
            int amlist = listBox1.Items.Count;
            int availableList = listBox3.Items.Count;

            for(int i= 0; i<amlist;i++)
            {
                for(int j =0; j< availableList; j++)
                {
                    if(listBox1.Items[i]==listBox3.Items[j])
                    {
                        listBox3.Items.Remove(listBox3.Items[j]);
                    }
                }
            }

            for (int i = 0; i < pmlist; i++)
            {
                for (int j = 0; j < availableList; j++)
                {
                    if (listBox2.Items[i] == listBox3.Items[j])
                    {
                        listBox3.Items.Remove(listBox3.Items[j]);
                    }
                }
            }


        }
    }
}
