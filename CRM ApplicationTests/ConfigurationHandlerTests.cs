using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CRM_Application.Tests {
    [TestClass()]
    public class ConfigurationHandlerTests {
        [TestMethod()]
        public void LoadConfigTest() {
            ConfigurationHandler.LoadConfig();

            Assert.IsTrue(ConfigurationHandler.CONNECTION_STRING.Count > 0);
            Assert.IsTrue(ConfigurationHandler.CONFIGURATION_SETTINGS.Count > 0);
        }
    }
}