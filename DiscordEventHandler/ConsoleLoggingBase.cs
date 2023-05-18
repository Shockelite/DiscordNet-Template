using System;

namespace Discord {

    /// <summary>
    /// Determines types of event to log to console.
    /// </summary>
    public enum LogLevel : byte {
        /// <summary>
        /// Informational messages to log to console.
        /// </summary>
        Info = 1,
        /// <summary>
        /// Warning messages to log to console.
        /// </summary>
        Warning = 2,
        /// <summary>
        /// Error messages to log to console.
        /// </summary>
        Error = 4
    }

    /// <summary>
    /// Base class for events.
    /// </summary>
    public class ConsoleLoggingBase {

        /// <summary>
        /// Default debug level used for <see cref="Log(string)"/>, <see cref="LogWarning(string)"/>, and <see cref="LogError(string)"/>.
        /// </summary>
        public LogLevel Debug { get; set; } = LogLevel.Info | LogLevel.Warning | LogLevel.Error;

        /// <summary>
        /// Log informational text to console if <see cref="Debug"/> contains the <see cref="LogLevel.Info"/> flag.
        /// </summary>
        /// <param name="value">Input</param>
        public void Log(string value) {
            if (Debug.HasFlag(LogLevel.Info))
                Log(value, GetType());
        }

        /// <summary>
        /// Log warning text to console if <see cref="Debug"/> contains the <see cref="LogLevel.Warning"/> flag.
        /// </summary>
        /// <param name="value">Input</param>
        public void LogWarning(string value) {
            if (Debug.HasFlag(LogLevel.Warning))
                LogWarning(value, GetType());
        }

        /// <summary>
        /// Log error text to console if <see cref="Debug"/> contains the <see cref="LogLevel.Error"/> flag.
        /// </summary>
        /// <param name="value">Input</param>
        public void LogError(string value) {
            if (Debug.HasFlag(LogLevel.Error))
                LogError(value, GetType());
        }

        /// <summary>
        /// Log informational text to console.
        /// </summary>
        /// <param name="value">Input</param>
        public static void Log(string value, Type type) {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(type + " - " + value);
            Console.ResetColor();
        }

        /// <summary>
        /// Log warning text to console.
        /// </summary>
        /// <param name="value">Input</param>
        public static void LogWarning(string value, Type type) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(type + " - " + value);
            Console.ResetColor();

        }

        /// <summary>
        /// Log error text to console.
        /// </summary>
        /// <param name="value">Input</param>
        public static void LogError(string value, Type type) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(type + " - " + value);
            Console.ResetColor();
        }

    }
}