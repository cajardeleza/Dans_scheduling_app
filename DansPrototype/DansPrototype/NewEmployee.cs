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
        private ListViewItem newItem = null;

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            loadList();
        }

        private void NewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (newItem != null)
                newItem.Remove();
            Hide();
        }

        private void loadList()
        {
            listView1.Items.Clear();
            cn.Open();
            cmd.CommandText = "select * from employees";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dr[1].ToString()));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dr[2].ToString()));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, dr[3].ToString()));
                    listView1.Items.Add(item);
                }
            }
            cn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtid.Text = listView1.SelectedItems[0].Text;
                txtfname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtlastname.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtposition.Text = listView1.SelectedItems[0].SubItems[3].Text;
                deleteEmployee.Enabled = true;
                txtid.Enabled = true;
                txtfname.Enabled = true;
                txtlastname.Enabled = true;
                txtposition.Enabled = true;
                submitBtn.Enabled = true;
                if ((newItem != null) && (newItem != listView1.SelectedItems[0]))
                {
                    newItem.Remove();
                }
            } else
            {
                deleteEmployee.Enabled = false;
                txtid.Enabled = false;
                txtfname.Enabled = false;
                txtlastname.Enabled = false;
                txtposition.Enabled = false;
                submitBtn.Enabled = false;
            }
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            // delete employee
            //int id = listBox1.SelectedIndex;
        }

        private void txtposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtposition.Text = (string)txtposition.SelectedItem;
        }

        private void submitBtn_Click(object sender, EventArgs e)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (newItem != null)
                newItem.Remove();
            newItem = new ListViewItem(((int.Parse(listView1.Items[listView1.Items.Count - 1].Text)) + 1).ToString());
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, "First"));
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, "Last"));
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem(newItem, "Server"));
            listView1.Items.Add(newItem);
            newItem.Selected = true;
            listView1.EnsureVisible(newItem.Index);
        }
    }
}
