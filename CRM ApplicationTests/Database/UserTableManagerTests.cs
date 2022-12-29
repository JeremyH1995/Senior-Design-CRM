using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_Application.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Application.Database.Tests {
    [TestClass()]
    public class UserTableManagerTests {
        [TestMethod()]
        public void LogUserInTest() {
            Assert.IsTrue(UserTableManager.LogUserIn("Admin", "Admin"));
        }
    }
}