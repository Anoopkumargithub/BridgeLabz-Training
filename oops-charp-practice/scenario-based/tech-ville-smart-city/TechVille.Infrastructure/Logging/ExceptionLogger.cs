using System;
using System.IO;

namespace TechVille.Infrastructure.Logging
{
    /// <summary>
    /// Logs exceptions to file with timestamp.
    /// </summary>
    public static class ExceptionLogger
    {
        private static readonly string _logPath = "logs.txt";

        public static void Log(Exception ex)
        {
            string message =
                $"[{DateTime.Now}] {ex.GetType().Name} - {ex.Message}\n";

            File.AppendAllText(_logPath, message);
        }
    }
}
