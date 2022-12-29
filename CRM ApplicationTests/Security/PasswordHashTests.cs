using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_Application.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Application.Security.Tests {
    [TestClass()]
    public class PasswordHashTests {
        [TestMethod()]
        public void VerifyTest() {

            PasswordHash hash = new PasswordHash("password");
            byte[] hashBytes = hash.ToArray();

            PasswordHash FromBytes = new PasswordHash(hashBytes);

            Assert.IsTrue(FromBytes.Verify("password"));
        }
    }
}