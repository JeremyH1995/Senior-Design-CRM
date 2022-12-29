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
    public partial class AppointmentDataView : Form {

        private Appointment appointment;
        private PartialBlock hourBlock;

        public AppointmentDataView() {
            InitializeComponent();
        }

        public AppointmentDataView(PartialBlock block, Appointment appointment) {
            InitializeComponent();

            this.appointment = appointment;
            hourBlock = block;

            this.Text = appointment.AppointmentStartTime.ToString("dddd MMMM dd: hh mmtt") + " - " + appointment.AppointmentEndTime.ToString("hh mmtt");

            DoubleBuffered = true;

            appDatePicker.Enabled = false;
            startTimePicker.Enabled = false;
            endTimePicker.Enabled = false;
            roomNumberSelector.Enabled = false;

            cancelPopup.Controls.Add(cancelCancelButton);
            cancelPopup.Controls.Add(confirmCancelButton);

            deleteConfirmPanel.Controls.Add(deleteConfirmButton);
            deleteConfirmPanel.Controls.Add(deleteCancelButton);

            PopulateAppointmentDataFields();
        }

        private void EnableEditingOfAppointmentData() {

            clientNameTextbox.ReadOnly = false;
            appDatePicker.Enabled = true;
            startTimePicker.Enabled = true;
            endTimePicker.Enabled = true;
            roomNumberSelector.Enabled = true;
            saveButton.Visible = true;
            cancelButton.Visible = true;
            editButton.Visible = false;
        }

        private void DisableEditingOfAppointmentData() {

            clientNameTextbox.ReadOnly = true;
            appDatePicker.Enabled = false;
            startTimePicker.Enabled = false;
            endTimePicker.Enabled = false;
            roomNumberSelector.Enabled = false;
            saveButton.Visible = false;
            cancelButton.Visible = false;
            editButton.Visible = true;
        }

        private void editButton_Click(object sender, EventArgs e) {

            if (deleteConfirmPanel.Visible) return;
            deleteButton.Hide();
            EnableEditingOfAppointmentData();
        }

        private void PopulateAppointmentDataFields() {

            clientNameTextbox.Text = appointment.ClientName;
            appDatePicker.Value = appointment.AppointmentStartTime;
            startTimePicker.Value = appointment.AppointmentStartTime;
            endTimePicker.Value = appointment.AppointmentEndTime;
            roomNumberSelector.SelectedIndex = appointment.RoomNumber - 1;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            cancelPopup.Show();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            DisableEditingOfAppointmentData();
            appointment.ClientName = clientNameTextbox.Text;
            appointment.AppointmentStartTime = new DateTime(appDatePicker.Value.Year, appDatePicker.Value.Month, 
                appDatePicker.Value.Day, startTimePicker.Value.Hour, startTimePicker.Value.Minute, 0);
            appointment.AppointmentEndTime = new DateTime(appDatePicker.Value.Year, appDatePicker.Value.Month,
                appDatePicker.Value.Day, endTimePicker.Value.Hour, endTimePicker.Value.Minute, 0);
            appointment.RoomNumber = roomNumberSelector.SelectedIndex + 1;
            AppointmentTableManager.UpdateAppointmentRecordInDatabase(appointment);
            cancelPopup.Hide();
            deleteButton.Show();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            cancelPopup.Hide();
        }

        private void confirmCancelButton_Click(object sender, EventArgs e) {
            cancelPopup.Hide();
            deleteButton.Show();
            DisableEditingOfAppointmentData();
            PopulateAppointmentDataFields();
        }

        private void cancelCancelButton_Click(object sender, EventArgs e) {
            cancelPopup.Hide();
        }

        private void deleteConfirmButton_Click(object sender, EventArgs e) {
            bool wasAppointmentRemoved = AppointmentTableManager.RemoveAppointmentsDatabaseEntry(appointment.AppointmentID);
            if (!wasAppointmentRemoved) {
                Logger.LogDebug("Failed to remove appointment from database");
            }
            hourBlock.AppointmentInBlock = null;
            hourBlock.Refresh();
            this.Close();
        }

        private void deleteCancelButton_Click(object sender, EventArgs e) {
            deleteConfirmPanel.Hide();
        }

        private void deleteCornerXButton_Click(object sender, EventArgs e) {
            deleteConfirmPanel.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            deleteConfirmPanel.Show();
        }
    }
}
