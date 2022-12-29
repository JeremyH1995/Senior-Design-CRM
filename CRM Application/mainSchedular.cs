using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Application
{
    public partial class mainSchedular : Form
    {
        int month;
        int year;
        public static int static_month, static_year;
        public mainSchedular()
        {
            InitializeComponent();
            this.Load += mainSchedular_Load;
            WindowState = FormWindowState.Maximized;
        }

        private void mainSchedular_Load(object sender, EventArgs e)
        {
            DisplayDays();
            Console.WriteLine("HERE");

        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonth.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysOftheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;
            Console.WriteLine("DAYS:" + daysOftheWeek);

            for(int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank usercontrolBlank = new UserControlBlank();
                dayContainer.Controls.Add(usercontrolBlank);
                
            }

            for(int i = 1; i <= days; i++)
            {
                UserControlDays usercontrolDays = new UserControlDays(new DateTime(year, month, i));
                usercontrolDays.days(i);
                dayContainer.Controls.Add(usercontrolDays);
            }
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();


            //year = DateTime.Now.Year;
            if (month != 12)
            {
                month++;
                static_month = month;
                //static_year = year;
            }
            else
            {
                month = 1;
                static_month = month;
                year++;
                static_year = year;
            }

            //month++;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonth.Text = monthName + " " + year;

            DateTime now = DateTime.Now;

            DateTime startOfMonth = new DateTime(year, month, 1);


            int days = DateTime.DaysInMonth(year, month);

            int daysOftheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;
            Console.WriteLine("DAYS:" + daysOftheWeek);

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank usercontrolBlank = new UserControlBlank();
                dayContainer.Controls.Add(usercontrolBlank);

            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays usercontrolDays = new UserControlDays(new DateTime(year, month, i));
                usercontrolDays.days(i);
                dayContainer.Controls.Add(usercontrolDays);
            }
        }


        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            if (month == 1)
            {
                month = 13;
                month--;
                static_month = month;
                year--;
                static_year = year;
            }
            else
            {
                month--;
            //    month = 12;
            //    static_month = month;
           //     year--;
           //     static_year = year;
           }

            //month--;
            //static_month = month;
            //static_year = year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonth.Text = monthName + " " + year;

            DateTime now = DateTime.Now;

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysOftheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;
            Console.WriteLine("DAYS:" + daysOftheWeek);

            for (int i = 1; i < daysOftheWeek; i++)
            {
                UserControlBlank usercontrolBlank = new UserControlBlank();
                dayContainer.Controls.Add(usercontrolBlank);

            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays usercontrolDays = new UserControlDays(new DateTime(year, month, i));
                usercontrolDays.days(i);
                dayContainer.Controls.Add(usercontrolDays);
            }
        }

        //private void dailyViewButton_Click(object sender, EventArgs e)
        //{
        //    DailyViewForm newDailyViewForm = new DailyViewForm();
        //    newDailyViewForm.ShowDialog();
        //}

    }
}
