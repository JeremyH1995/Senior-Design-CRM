using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace CRM_Application {

    public static class ConfigurationHandler {

        public static Dictionary<string, string> CONFIGURATION_SETTINGS;
        public static ConnectionStringSettingsCollection CONNECTION_STRING;

        public static void LoadConfig() {

            try {
                CONFIGURATION_SETTINGS = new Dictionary<string, string>();
                var configSettings = ConfigurationManager.AppSettings;

                if (configSettings.Count == 0) {
                    Logger.LogError("Could not load configuration file");
                }
                else {
                    Logger.LogInformation("Configuration loader started.");

                    foreach (var key in configSettings.AllKeys) {
                        CONFIGURATION_SETTINGS.Add(key, configSettings[key]);
                        Logger.LogInformation("Loaded configuration setting: " + key + " with value " + configSettings[key]);
                    }

                    int.TryParse(CONFIGURATION_SETTINGS["ROOM_NUMBER_MAXIMUM"], out Appointment.ROOM_NUMBER_MAXIMUM);

                }
            }
            catch (Exception exception) {
                Logger.LogException(exception);
            }

            LoadDatabaseConnectionStrings();
            Logger.LogInformation("Configuration loader finished");
        }

        public static void SaveConfig() {

            try {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(Program.EXECUTABLE_NAME);

                foreach (var setting in CONFIGURATION_SETTINGS) {
                    configuration.AppSettings.Settings[setting.Key].Value = setting.Value;
                }
                configuration.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception exception) {
                Logger.LogException(exception, Logger.LogLevel.ERROR);
            }
        }

        private static void LoadDatabaseConnectionStrings() {

            try {
                CONNECTION_STRING = new ConnectionStringSettingsCollection();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected) {
                    section.SectionInformation.UnprotectSection();
                    CONNECTION_STRING = section.ConnectionStrings;
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    Logger.LogInformation("Loaded " + CONNECTION_STRING.Count + " connection strings.");
                }
                else {
                    Logger.LogWarning("Connection strings were left unprotected, encrypting connection strings");
                    CONNECTION_STRING = section.ConnectionStrings;
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");                    
                }
                
                config.Save();
            }
            catch (Exception exception) {
                Logger.LogException(exception);
            }
        }
    }
}
