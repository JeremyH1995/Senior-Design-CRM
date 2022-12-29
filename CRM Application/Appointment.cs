using System;
using System.Reflection;

namespace CRM_Application {
    public class Appointment {

        public static readonly int ROOM_NUMBER_MINIMUM = 1;
        public static int ROOM_NUMBER_MAXIMUM;

        public int AppointmentID { get; set; }
        public DateTime AppointmentStartTime { get; set; }
        public DateTime AppointmentEndTime { get; set; }
        public string ClientName { get; set; }
        public string GraduateStudentName { get; set; }
        public int RoomNumber { get; set; }
        

        public Appointment(DateTime startTime, DateTime endTime, string clientName, string graduateStudentName, int roomNumber) {
            AppointmentStartTime = startTime;
            AppointmentEndTime = endTime;
            ClientName = clientName;
            GraduateStudentName = graduateStudentName;
            RoomNumber = roomNumber;
        }

        public bool AreAllAppointmentFieldsNotNull() {

            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties()) {

                if (propertyInfo.GetValue(this) == null) {
                   return false;
                }
            }
            return true;
        }

        // If this method ever returns true, the user has either entered invalid information (we shouldn't allow this to begin with)
        // or has managed to travel back in time.
        public bool IsAppointmentEndTimeBeforeStartTime() {
            return (AppointmentEndTime - AppointmentEndTime) < TimeSpan.Zero;
        }

        // We don't check the AppointmentID because the ID is set by the database itself.
        public override bool Equals(object obj) {
            return (this.AppointmentStartTime == ((Appointment)obj).AppointmentStartTime) && 
                (this.AppointmentEndTime == ((Appointment)obj).AppointmentEndTime) && 
                (this.ClientName == ((Appointment)obj).ClientName) && 
                (this.GraduateStudentName == ((Appointment)obj).GraduateStudentName) && 
                (this.RoomNumber == ((Appointment)obj).RoomNumber);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return "ID: " + AppointmentID + ", Start Time: " + 
                AppointmentStartTime.ToString() + ", End Time: " + 
                AppointmentEndTime.ToString() + ", Client Name: " +
                ClientName + ", Gradute Student Name: " + GraduateStudentName +
                ", Room Number: " + RoomNumber;
        }
    }
}
