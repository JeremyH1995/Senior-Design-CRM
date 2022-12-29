using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Application.Tests {
    [TestClass()]
    public class AppointmentTests {

        [TestMethod()]
        public void AreAllAppointmentFieldsNotNullTest() {
            Appointment appointmentWithNoNullValues = new Appointment(new DateTime(2022, 9, 13, 11, 11, 00), new DateTime(2022, 9, 13, 1, 45, 00), "Test Test", "Test Test", 4);
            Appointment appointmentWIthNullValues = new Appointment(new DateTime(2022, 9, 13, 11, 11, 00), new DateTime(2022, 9, 13, 1, 45, 00), null, "Test Test", 4);
            Assert.IsTrue(appointmentWithNoNullValues.AreAllAppointmentFieldsNotNull());
            Assert.IsFalse(appointmentWIthNullValues.AreAllAppointmentFieldsNotNull());
        }

        [TestMethod()]
        public void EqualsTest() {
            Appointment appointment1 = new Appointment(new DateTime(2022, 9, 13, 11, 11, 00), new DateTime(2022, 9, 13, 1, 45, 00), "Test Test", "Test Test", 4);
            Appointment appointment2 = new Appointment(new DateTime(2022, 9, 13, 11, 11, 00), new DateTime(2022, 9, 13, 1, 45, 00), "Test Test", "Test Test", 4);
            Assert.AreEqual(appointment1, appointment2);
        }
    }
}