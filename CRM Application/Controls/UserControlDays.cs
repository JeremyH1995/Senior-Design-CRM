using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Application
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        private DateTime dateTime;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public UserControlDays(DateTime _dateTime) {
            InitializeComponent();
            dateTime = _dateTime;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            labelDays.Text = numdays.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day =  labelDays.Text;
            DailyViewForm newAppointment = new DailyViewForm(dateTime);
            newAppointment.Show();
        }
    }
}
