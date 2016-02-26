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
    public partial class CalendarWindow : Form
    {
        public CalendarWindow()
        {
            InitializeComponent();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
    }
}
