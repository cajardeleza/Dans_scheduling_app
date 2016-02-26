using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DansPrototype
{
    public partial class NewEmployee : Form
    {
        public delegate void UpdateDataHandler(object sender);
        public event UpdateDataHandler OnUpdateData;

        private MySqlConnection cn = new MySqlConnection(@"server=" + Login.host + ";user id=" + Login.user + ";password=" + Login.pass + ";database=dans_test;persistsecurityinfo=True");
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataReader dr;

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            loadList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HomeScreen().Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" & txtfname.Text != "" & txtlastname.Text != "" & txtposition.Text != "")
            {
                cn.Open();

                cmd.CommandText = "insert into employees (id_num, Employee_FirstName, Employee_LastName, Employee_position) values ('" + txtid.Text + "','" + txtfname.Text + " ',' " + txtlastname.Text + " ',' " + txtposition.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("record inserted", "programming at c.Jard");
                cn.Close();
                txtid.Text = "";
                txtfname.Text = "";
                txtlastname.Text = "";
                txtposition.Text = "";
                loadList();
            }
        }

        private void loadList()
        {
            listBox1.Items.Clear();
            cn.Open();
            cmd.CommandText = "select * from employees";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    listBox1.Items.Add(dr[1].ToString() + " " + dr[2].ToString());
                }
            }
            cn.Close();
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            // delete employee
            int id = listBox1.SelectedIndex;
        }

        private void NewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

       
            deleteEmployee.Enabled = true;
        }
    }
}
