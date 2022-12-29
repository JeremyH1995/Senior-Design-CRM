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

namespace CRM_Application {
    public partial class NewRecurringAppointmentForm : Form {

        private DailyViewForm dailyViewForm;

        public NewRecurringAppointmentForm(DailyViewForm _dailyViewForm) {
            InitializeComponent();
            dailyViewForm = _dailyViewForm;
            DateTime currentTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                DateTime.Today.Day, DateTime.Now.Hour + 1, 00, 00);
            startTimePicker.Value = currentTime;
            DateTime endTimeWithHourIncrease = currentTime.AddHours(1);
            endTimePicker.Value = endTimeWithHourIncrease;

            appStartDatePicker.Value = dailyViewForm.DailyViewDate;
            dateEndTimePicker.Value = dailyViewForm.DailyViewDate;
        }

        private void saveAppointmentButton_Click(object sender, EventArgs e) {

            bool patientNameErrord = false;
            bool roomNumberErrored = false;
            

            Dictionary<DayOfWeek, bool> daysChecked = GetDaysMarked();

            List<Appointment> recurringAppointments = new List<Appointment>();

            string patientName = patientNameTextbox.Text;
            DateTime startTime = new DateTime(appStartDatePicker.Value.Year, appStartDatePicker.Value.Month,
               appStartDatePicker.Value.Day, startTimePicker.Value.Hour, startTimePicker.Value.Minute, 0);
            DateTime endTime = new DateTime(appStartDatePicker.Value.Year, appStartDatePicker.Value.Month,
                appStartDatePicker.Value.Day, endTimePicker.Value.Hour, endTimePicker.Value.Minute, 0);
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

            foreach (DateTime iteratorDay in EachDay(appStartDatePicker.Value, dateEndTimePicker.Value)) {
                for (int i = 0; i < daysChecked.Count; i++) {
                    if (daysChecked.ElementAt(i).Key == iteratorDay.DayOfWeek && daysChecked.ElementAt(i).Value == true) {

                        DateTime start = new DateTime(iteratorDay.Year, iteratorDay.Month, iteratorDay.Day, startTimePicker.Value.Hour, startTimePicker.Value.Minute, 0);
                        DateTime end = new DateTime(iteratorDay.Year, iteratorDay.Month, iteratorDay.Day, endTimePicker.Value.Hour, endTimePicker.Value.Minute, 0);

                        recurringAppointments.Add(new Appointment(start, end, patientName, "", roomNumber));
                        Logger.LogDebug("Recurring List Add: " + (new Appointment(start, end, patientName, "", roomNumber)).ToString());
                    }
                }
            }

            Appointment newAppointment = new Appointment(startTime, endTime, patientName, "", roomNumber);

            if (newAppointment.IsAppointmentEndTimeBeforeStartTime()) {
                MessageBox.Show("Appointment start time must be before the end time.", "Time input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                AppointmentTableManager.AddAppointmentListToDatabase(recurringAppointments);
                MessageBox.Show("Saved");
                dailyViewForm.Reload();
                this.Close();
            }
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru) {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        private Dictionary<DayOfWeek, bool> GetDaysMarked() {

            Dictionary<DayOfWeek, bool> daysChecked = new Dictionary<DayOfWeek, bool>();
            daysChecked.Add(DayOfWeek.Sunday, sundayCheckbox.Checked);
            daysChecked.Add(DayOfWeek.Monday, mondayCheckbox.Checked);
            daysChecked.Add(DayOfWeek.Tuesday, tuesdayCheckbox.Checked);
            daysChecked.Add(DayOfWeek.Wednesday, wednesdayCheckbox.Checked);
            daysChecked.Add(DayOfWeek.Thursday, thurdsayCheckbox.Checked);
            daysChecked.Add(DayOfWeek.Friday, fridayCheckbox.Checked);
            daysChecked.Add(DayOfWeek.Saturday, saturdayCheckbox.Checked);

            return daysChecked;
        }
    }
}
