using CRM_Application.Database;
using CRM_Application.Security;
using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CRM_Application {

    /*
     * This is here for later reference
     * LocalDB 2019 installer: https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15
     * If LocalDB 2019 installs properly, run the following commands to recreate the MSSQLLocalDB instance
     * 1) sqllocaldb stop MSSQLLocalDB
     * 2) sqllocaldb delete MSSQLLocalDB
     * 3) sqllocaldb create MSSQLLocalDB
     * 4) sqllocaldb start MSSQLLocalDB
     * 
     * We may be able to silently install LocalDB 2019 onto the clients machine to prevent them from having to install it themselves.
     * 
     */
    static class Program {

        public static readonly string EXECUTABLE_NAME = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            // These three lines are needed to avoid hard-coding the path to the database. This sets the database location to the same directory as the executable.
            // If moving the database to another location such as an external SQL server, these lines will need to be removed.
            string executable = Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(executable);
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            Logger.LoggerInit("CRM_Application.log");
            ConfigurationHandler.LoadConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainSchedular());
        }
    }
}
