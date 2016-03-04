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
        private CalendarWindow calendar;
        private AvailabilityWindow availability;
        private NewEmployee employee;

        public HomeScreen()
        {
            InitializeComponent();
            // center it on screen
            CenterToScreen();
            calendar = new CalendarWindow();
            availability = new AvailabilityWindow();
            employee = new NewEmployee();
            // set up update events
            employee.OnUpdateData += availability.UpdateData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calendar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            availability.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employee.Show();
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            availability.Close();
        }
    }
}
