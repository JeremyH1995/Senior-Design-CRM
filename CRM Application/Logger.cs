using System;
using System.IO;

namespace CRM_Application {
    public static class Logger {

        public enum LogLevel : int {
            INFORMATION = 0,
            WARNING = 1,
            ERROR = 2,
            FATAL = 3,
            DEBUG = 4,
        };

        static string ouputLogPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static string logFile = "";

        public static void LoggerInit(string logFileName) { logFile = logFileName; ClearLog(); }

        public static void LogInformation(string message) => WriteToLogFile(LogLevel.INFORMATION, message);

        public static void LogWarning(string message) => WriteToLogFile(LogLevel.WARNING, message);

        public static void LogError(string message) => WriteToLogFile(LogLevel.ERROR, message);

        public static void LogExceptionWithMessage(string message, Exception exception, LogLevel logLevel = LogLevel.ERROR) => WriteToLogFile(logLevel, message + exception.Message);

        public static void LogException(Exception exception, LogLevel logLevel = LogLevel.ERROR) => WriteToLogFile(logLevel, exception.Message);

        public static void LogObject(Object objectToString, LogLevel logLevel = LogLevel.INFORMATION) => WriteToLogFile(logLevel, objectToString.ToString());

        public static void LogFatalError(Exception exception, string message = "") => WriteToLogFile(LogLevel.FATAL, message + exception.Message);

        public static void LogDebug(string message) => WriteToLogFile(LogLevel.DEBUG, message);

        private static void WriteToLogFile(LogLevel logLevel, string message) {
            
            using (StreamWriter outputStreamWriter = File.AppendText(Path.Combine(ouputLogPath, logFile))) {

                if(logLevel == LogLevel.DEBUG) {
                    #if DEBUG
                        outputStreamWriter.Write("[" + DateTime.Now + "]");
                        outputStreamWriter.WriteLine(" [" + logLevel + "] " + message);
                    #endif
                }
                else {                 
                    outputStreamWriter.Write("[" + DateTime.Now + "]");
                    outputStreamWriter.WriteLine(" [" + logLevel + "] " + message);
                }
            } 
        }

        private static void ClearLog() {
            File.WriteAllText(Path.Combine(ouputLogPath, logFile), string.Empty);
        }
    }
}