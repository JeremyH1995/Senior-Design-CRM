using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CRM_Application.Database {

    /*
     * Modifying, or pulling records from, the appointments table in the database should be done through this class.
     * This class does not check the database returns for validity. It only checks that the operation was completed
     * successfully.
     */
    public sealed class AppointmentTableManager {

        public static bool AddAppointmentDatabaseEntry(Appointment itemToAdd) {

            if (itemToAdd == null || !itemToAdd.AreAllAppointmentFieldsNotNull() || DoesAppointmentExist(itemToAdd)) {
                return false;
            }

            try {
                using (SqlConnection sqlconnection = new SqlConnection(ConfigurationHandler.CONNECTION_STRING[1].ConnectionString)) {
                    sqlconnection.Open();

                    string query = @"Insert Into [Appointments] (AppointmentStartTime, AppointmentEndTime, ClientName, GraduateStudentName, RoomNumber) Values(@StartTime, @EndTime, @CName, @GSName, @RoomNum)";

                    using (SqlCommand command = new SqlCommand(query, sqlconnection)) {
                        SqlParameter sqlParam = command.Parameters.AddWithValue("@StartTime", itemToAdd.AppointmentStartTime);
                        command.Parameters.AddWithValue("@EndTime", itemToAdd.AppointmentEndTime);
                        command.Parameters.AddWithValue("@CName", itemToAdd.ClientName);
                        command.Parameters.AddWithValue("@GSName", itemToAdd.GraduateStudentName);
                        command.Parameters.AddWithValue("@RoomNum", itemToAdd.RoomNumber);
                        Logger.LogDebug("AddAppointmentDatabaseEntry: " + itemToAdd.ToString());
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException sqlException) {
                Logger.LogExceptionWithMessage("AddAppointmentDatabaseEntry: ", sqlException);
                return false;
            }
        }

        public static bool AddAppointmentListToDatabase(List<Appointment> appointmentList) {

            try {
                using (SqlConnection sqlconnection = new SqlConnection(ConfigurationHandler.CONNECTION_STRING[1].ConnectionString)) {
                    sqlconnection.Open();

                    string query = @"Insert Into [Appointments] (AppointmentStartTime, AppointmentEndTime, ClientName, GraduateStudentName, RoomNumber) Values(@StartTime, @EndTime, @CName, @GSName, @RoomNum)";

                    using (SqlCommand command = new SqlCommand(query, sqlconnection)) {

                        foreach (Appointment itemToAdd in appointmentList) {
                            SqlParameter sqlParam = command.Parameters.AddWithValue("@StartTime", itemToAdd.AppointmentStartTime);
                            command.Parameters.AddWithValue("@EndTime", itemToAdd.AppointmentEndTime);
                            command.Parameters.AddWithValue("@CName", itemToAdd.ClientName);
                            command.Parameters.AddWithValue("@GSName", itemToAdd.GraduateStudentName);
                            command.Parameters.AddWithValue("@RoomNum", itemToAdd.RoomNumber);
                            Logger.LogDebug("AddAppointmentListToDatabase: " + itemToAdd.ToString());
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        return true;
                    }
                }
            }
            catch (SqlException sqlException) {
                Logger.LogExceptionWithMessage("AddAppointmentDatabaseEntry: ", sqlException);
                return false;
            }
        }

        public static bool UpdateAppointmentRecordInDatabase(Appointment appointmentToUpdate) {

            try {
                using (SqlConnection sqlconnection = new SqlConnection(ConfigurationHandler.CONNECTION_STRING[1].ConnectionString)) {
                    sqlconnection.Open();

                    string query = @"UPDATE [Appointments] set AppointmentStartTime=@startTime, AppointmentEndTime=@endTime, ClientName=@cName, GraduateStudentName=@gName, RoomNumber=@roomNum WHERE Id=@id";

                    using (SqlCommand command = new SqlCommand(query, sqlconnection)) {

                        SqlParameter sqlParam = command.Parameters.AddWithValue("@id", appointmentToUpdate.AppointmentID);
                        command.Parameters.AddWithValue("@startTime", appointmentToUpdate.AppointmentStartTime);
                        command.Parameters.AddWithValue("@endTime", appointmentToUpdate.AppointmentEndTime);
                        command.Parameters.AddWithValue("@cName", appointmentToUpdate.ClientName);
                        command.Parameters.AddWithValue("@gName", appointmentToUpdate.GraduateStudentName);
                        command.Parameters.AddWithValue("@roomNum", appointmentToUpdate.RoomNumber);

                        int recordsUpdated = command.ExecuteNonQuery();
                        Logger.LogDebug("UpdateAppointmentRecordInDatabase: Updated " + recordsUpdated + " records");
                        return recordsUpdated > 0;
                    }
                }
            }
            catch (SqlException sqlException) {
                Logger.LogExceptionWithMessage("UpdateAppointmentRecordInDatabase: ", sqlException);
                return false;
            }
        }

        /* 
         * Other than an SQL error, if this method ever returns false (ie more than one record was deleted),
         * a larger problem is present because apppointments are deleted by AppointmentID and AppointmentID is
         * supposed to be unique.
         */
        public static bool RemoveAppointmentsDatabaseEntry(int idOfRemovalItem) {

            try {
                using (SqlConnection sqlconnection = new SqlConnection(ConfigurationHandler.CONNECTION_STRING["AppointmentsDatabase"].ConnectionString)) {
                    sqlconnection.Open();

                    string query = @"DELETE FROM [Appointments] where Id=@ID";

                    using (SqlCommand command = new SqlCommand(query, sqlconnection)) {
                        command.Parameters.AddWithValue("@ID", idOfRemovalItem);
                        int recordsDeleted = command.ExecuteNonQuery();
                        Logger.LogDebug("RemoveAppontmentsDatabaseEntry: Removed " + recordsDeleted + " records");
                        return recordsDeleted == 1;
                    }
                }
            }
            catch (SqlException sqlException) {
                Logger.LogExceptionWithMessage("RemoveAppointmentsDatabaseEntry: ", sqlException);
                return false;
            }
        }

        public static List<Appointment> GetAppointmentsFromDatabaseForRoomNumber(int roomNumber) {

            if(roomNumber > Appointment.ROOM_NUMBER_MAXIMUM || roomNumber < Appointment.ROOM_NUMBER_MINIMUM) {
                return null;
            }

            List<Appointment> appointmentsForRoomNumber = new List<Appointment>();

            try {
                using (SqlConnection sqlconnection = new SqlConnection(ConfigurationHandler.CONNECTION_STRING["AppointmentsDatabase"].ConnectionString)) {
                    sqlconnection.Open();

                    string query = @"Select * from [Appointments] where RoomNumber = @RN";

                    using (SqlCommand command = new SqlCommand(query, sqlconnection)) {
                        command.Parameters.AddWithValue("@RN", roomNumber);

                        using (SqlDataReader dataReader = command.ExecuteReader()) {

                            if (dataReader.HasRows) {
                                while (dataReader.Read()) {
                                    DateTime startTime = DateTime.Parse(dataReader.GetString(dataReader.GetOrdinal("AppointmentStartTime")));
                                    DateTime endTime = DateTime.Parse(dataReader.GetString(dataReader.GetOrdinal("AppointmentEndTime")));
                                    appointmentsForRoomNumber.Add(new Appointment(startTime, endTime, dataReader.GetString(dataReader.GetOrdinal("ClientName")),
                                        dataReader.GetString(dataReader.GetOrdinal("GraduateStudentName")),
                                        dataReader.GetInt32(dataReader.GetOrdinal("RoomNumber"))));
                                }
                            }
                            else {
                                return null;
                            }
                        }
                        return appointmentsForRoomNumber;
                    }
                }
            }
            catch (SqlException sqlException) {
                Logger.LogException(sqlException);
                return null;
            }
        }

        public static List<Appointment> GetAllAppointmentsFromDatabase() {
            List<Appointment> appointments = new List<Appointment>();

            try {
                using (SqlConnection sqlconnection = new SqlConnection(ConfigurationHandler.CONNECTION_STRING["AppointmentsDatabase"].ConnectionString)) {
                    sqlconnection.Open();

                    string query = @"Select * from [Appointments]";

                    using (SqlCommand command = new SqlCommand(query, sqlconnection)) {

                        using (SqlDataReader dataReader = command.ExecuteReader()) {

                            if (dataReader.HasRows) {
                                while (dataReader.Read()) {
                                    DateTime startTime = Convert.ToDateTime(dataReader.GetDateTime(dataReader.GetOrdinal("AppointmentStartTime")));
                                    DateTime endTime = Convert.ToDateTime(dataReader.GetDateTime(dataReader.GetOrdinal("AppointmentEndTime")));
                                    Appointment appointment = new Appointment(startTime, endTime, dataReader.GetString(dataReader.GetOrdinal("ClientName")),
                                        dataReader.GetString(dataReader.GetOrdinal("GraduateStudentName")),
                                        dataReader.GetInt32(dataReader.GetOrdinal("RoomNumber")));
                                    appointment.AppointmentID = dataReader.GetInt32(dataReader.GetOrdinal("Id"));
                                    appointments.Add(appointment);
                                }
                            }
                            else {
                                return null;
                            }
                        }
                        Logger.LogDebug("GetAllAppointmentsFromDatabase: Retrieved " + appointments.Count + " from database."); 
                        return appointments;
                    }
                }
            }
            catch (SqlException sqlex) {
                Logger.LogExceptionWithMessage("GetAllAppointmentsFromDatabase: " ,sqlex);
                return null;
            }
        }

        public static int GetAppointmentIdForRemoval(Appointment appointmentIdToRemove) {

            List<Appointment> appointments = GetAllAppointmentsFromDatabase();

            if (appointments == null) {
                return -1;
            }

            foreach (Appointment iterator in appointments) {
                if (iterator.Equals(appointmentIdToRemove)) {
                    return iterator.AppointmentID;
                }
            }
            return -1;
        }

        public static bool DoesAppointmentExist(Appointment appointmentToCheck) {

            List<Appointment> appointmentsInDatabase = GetAllAppointmentsFromDatabase();

            if (appointmentsInDatabase == null) {
                return false;
            }

            foreach (Appointment iterator in appointmentsInDatabase) {
                if (iterator.Equals(appointmentToCheck)) {
                    return true;
                }
            }
            return false;
        }
    }
}
