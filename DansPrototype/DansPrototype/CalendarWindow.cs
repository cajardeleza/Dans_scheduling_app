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

            Location = new Point(Screen.FromControl(this).Bounds.Left, Screen.FromControl(this).Bounds.Bottom - Height- 40);
        }

        private void CalendarWindow_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            monthCalendar1.MaxDate = lastDayOfMonth;
            monthCalendar1.MinDate = firstDayOfMonth;


            // Refresh currently selected
            monthCalendar1.SetDate(firstDayOfMonth);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CalendarWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void availableList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void workingList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToWorking_Click(object sender, EventArgs e)
        {

        }

        private void addToAvailable_Click(object sender, EventArgs e)
        {

        }

        private void serverChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bartenderChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void busChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hostChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void expoChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void managerChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
