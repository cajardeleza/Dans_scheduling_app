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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calanderWindow calander = new calanderWindow();
            calander.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvailabilityWindow availability = new AvailabilityWindow();
            availability.Show();
            this.Hide();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewEmployee employee = new NewEmployee();
            employee.Show();
            this.Hide();
        }
    }
}
