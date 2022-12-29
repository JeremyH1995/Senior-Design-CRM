using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_Application.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CRM_Application.Database.Tests {
    [TestClass()]
    public class AppointmentTableManagerTests {
        [TestMethod()]
        public void AddAppointmentDatabaseEntryTest() {

            string executable = Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(executable);
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            ConfigurationHandler.LoadConfig();
            Appointment testAppointment = new Appointment(new DateTime(2022, 9, 13, 11, 11, 00), new DateTime(2022, 9, 13, 1, 45, 00), "Test Test", "Test Test", 4);
            
            Assert.IsTrue(AppointmentTableManager.AddAppointmentDatabaseEntry(testAppointment));
        }
    }
}