using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_Application.Database;

namespace CRM_Application
{
    public partial class NewAppointmentCreate : Form
    {
        private DailyViewForm dailyViewForm;

        public NewAppointmentCreate(DailyViewForm dailyViewForm)
        {
            InitializeComponent();
            Text = "Create new appointment";
            this.dailyViewForm = dailyViewForm;
            DateTime currentTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 
                DateTime.Today.Day, DateTime.Now.Hour + 1, 00, 00);
            startTimePicker.Value = currentTime;
            DateTime endTimeWithHourIncrease = currentTime.AddHours(1);
            endTimePicker.Value = endTimeWithHourIncrease;

            appDatePicker.Value = dailyViewForm.DailyViewDate;
        }

        private void saveAppointmentButton_Click(object sender, EventArgs e) {

            bool patientNameErrord = false;
            bool roomNumberErrored = false;

            string patientName = patientNameTextbox.Text;
            DateTime startTime = new DateTime(appDatePicker.Value.Year, appDatePicker.Value.Month,
                appDatePicker.Value.Day, startTimePicker.Value.Hour, startTimePicker.Value.Minute, 0);
            DateTime endTime = new DateTime(appDatePicker.Value.Year, appDatePicker.Value.Month,
                appDatePicker.Value.Day, endTimePicker.Value.Hour, endTimePicker.Value.Minute, 0);
            int roomNumber = roomBox.SelectedIndex + 1;

            if (String.IsNullOrWhiteSpace(patientName)) {
                patientNameEmptyErrorLabel.Visible = true;
                patientNameErrord = true;
            }
            else {
                patientNameEmptyErrorLabel.Visible = false;
            }

            if (roomBox.SelectedIndex == -1) {
                roomNumberErrorLabel.Visible = true;
                roomNumberErrored = true;
            }
            else {
                roomNumberErrorLabel.Visible = false;
            }

            if (patientNameErrord || roomNumberErrored) return;

            Appointment newAppointment = new Appointment(startTime, endTime, patientName, "", roomNumber);

            if (newAppointment.IsAppointmentEndTimeBeforeStartTime()) {
                MessageBox.Show("Appointment start time must be before the end time.", "Time input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                AppointmentTableManager.AddAppointmentDatabaseEntry(newAppointment);
                MessageBox.Show("Saved");
                dailyViewForm.Reload();
                this.Close();
            }
        }

        private void newAppointmentCreate_Load(object sender, EventArgs e)
        {
            appDatePicker.Text = mainSchedular.static_month+ "/" +UserControlDays.static_day + "/" + mainSchedular.static_year;
        }
    }
}
