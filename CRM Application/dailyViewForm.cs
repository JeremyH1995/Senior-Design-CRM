using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CRM_Application.Database;

namespace CRM_Application {
    public partial class DailyViewForm : Form {

        private Color[] blockColors = { Color.LightBlue, Color.LightYellow, Color.LightGreen, Color.LightPink, Color.LightGray, Color.LightSalmon };
        private List<ScheduleHourBlock> HourBlocks { get; set; }
        private List<Appointment> AppointmentsForToday { get; set; }

        public DateTime DailyViewDate { get; set; }

        public DailyViewForm(DateTime _dateTime) {
            HourBlocks = new List<ScheduleHourBlock>();
            AppointmentsForToday = GetAppointmentsForToday(_dateTime.Day);
            DailyViewDate = _dateTime;

            InitializeComponent();
            InitializeScheduleBlocks();
            if (AppointmentsForToday != null) {
                PopulateScheduleBlocks();
            }
            this.Load += dailyViewForm_Load;
            WindowState = FormWindowState.Maximized;
            Invalidate();
        }

        public void Reload() {
            AppointmentsForToday = GetAppointmentsForToday(DailyViewDate.Day);
            if (AppointmentsForToday != null) {
                PopulateScheduleBlocks();
            }
            Invalidate();
            Refresh();
        }

        private void dailyViewForm_Load(object sender, EventArgs e) {
            dailyViewDateLabel.Text = DailyViewDate.ToString("dddd MMMM dd, yyyy");
        }

        private void InitializeScheduleBlocks() {

            SetDoubleBuffered(dailyViewTableGrid);
            dailyViewTableGrid.SuspendLayout();
            int hourForBlock = 6;
            for (int i = 1; i < dailyViewTableGrid.RowCount; i++) {
                for (int j = 1; j < dailyViewTableGrid.ColumnCount; j++) {
                    ScheduleHourBlock hourBlock = new ScheduleHourBlock(blockColors[i % 6]);
                    HourBlocks.Add(hourBlock);
                    hourBlock.RoomNumber = j - 1;
                    hourBlock.BlockHour = hourForBlock;
                    SuspendLayoutUpdate.Suspend(hourBlock);
                    dailyViewTableGrid.Controls.Add(hourBlock);
                }
                hourForBlock++;
            }
            dailyViewTableGrid.ResumeLayout();
        }

        private void PopulateScheduleBlocks() {

            foreach (ScheduleHourBlock hourBlock in HourBlocks) {
                foreach (Appointment appointment in AppointmentsForToday) {
                    if (appointment.RoomNumber == hourBlock.RoomNumber) {
                        if (hourBlock.BlockHour == appointment.AppointmentStartTime.Hour) {
                            hourBlock.PartialBlocskForHour.ElementAt(0).AppointmentInBlock = appointment;
                        }
                    }
                }
                SuspendLayoutUpdate.Resume(hourBlock);
            }
        }

        private List<Appointment> GetAppointmentsForToday(int day) {

            List<Appointment> allAppointments = AppointmentTableManager.GetAllAppointmentsFromDatabase();
            List<Appointment> appointmentsForToday = new List<Appointment>();

            if (allAppointments == null) return null;

            foreach (Appointment iterator in allAppointments) {
                if (iterator.AppointmentStartTime.Day == day && iterator.AppointmentStartTime.Month == DailyViewDate.Month) {
                    appointmentsForToday.Add(iterator);
                }
            }
            return appointmentsForToday;
        }

        private void addAppointmentButton_Click(object sender, EventArgs e) {
            NewAppointmentCreate appointmentCreate = new NewAppointmentCreate(this);
            appointmentCreate.ShowDialog();
            appointmentCreate.Dispose();
        }

        /* 
         * By default the WinForms TableLayoutPanel does not support double buffering therefore there is considerable lag
         * when scrolling on the panel. This uses reflection to enable double buffering on any control that does not support
         * it.
         */
        public static void SetDoubleBuffered(Control controlToDoubleBuffer) {

            if (SystemInformation.TerminalServerSession) {
                return;
            }

            PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            property.SetValue(controlToDoubleBuffer, true, null);
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x02000000;
                return param;
            }
        }

        private void addRecurringAppointmentButton_Click(object sender, EventArgs e) {
            NewRecurringAppointmentForm newRecurringAppointmentForm = new NewRecurringAppointmentForm(this);
            newRecurringAppointmentForm.ShowDialog();
            newRecurringAppointmentForm.Dispose();
        }

        private void DailyViewForm_FormClosing(object sender, FormClosingEventArgs e) {
        }
    }
}
