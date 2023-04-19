using Discord.WebSocket;

namespace Discord {

    /// <summary>
    /// Provides extension methods for generating and reading commands.
    /// </summary>
    public static class CommandExtensions {

        /// <summary>
        /// Retrieves the value of a named option from the specified collection of command data options, or returns the default value if the option is not found.
        /// </summary>
        /// <typeparam name="T">The type of the option value.</typeparam>
        /// <param name="options">The collection of command data options to retrieve the value from.</param>
        /// <param name="name">The name of the option to retrieve the value for.</param>
        /// <param name="defaultValue">The default value to return if the option is not found.</param>
        /// <returns>The value of the named option, or the default value if the option is not found.</returns>
        /// 
        /// <remarks>
        /// The following example shows how to retrieve option values from a collection of command data options:
        ///
        /// <code>
        /// IReadOnlyCollection&lt;SocketSlashCommandDataOption&gt; options = data.Options;
        /// string s = options.GetOption&lt;string&gt;("optstring", string.Empty);
        /// double d = options.GetOption&lt;double&gt;("optdouble", 0.0);
        /// bool b = options.GetOption&lt;bool&gt;("optbool", false);
        /// long l = options.GetOption&lt;long&gt;("optlong", 1);
        /// </code>
        /// </remarks>
        public static T GetOption<T>(this IReadOnlyCollection<SocketSlashCommandDataOption> options, string name, T defaultValue) {
            object? value = options.FirstOrDefault(x => x.Name == name)?.Value;
            return value != null ? (T)value : defaultValue;
        }

    }

}