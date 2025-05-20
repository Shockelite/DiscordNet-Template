using System.Linq;
using System;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandSlash {

    /// <summary>
    /// A Discord slash command is a type of command that can be triggered in a Discord server by typing a forward slash (/) followed by a specific keyword or phrase.
    /// </summary>
    public class CommandSlashBase : CommandApplicationBase {

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandSlashBase(bool isGlobal = true, CommandContextType contextType = CommandContextType.None) : base(isGlobal, contextType) { }

        public override string GetName() =>
            GetBuilder()?.Name ?? base.GetName();

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task OnStart(EventHandler eventHandler, SocketSlashCommand arg) =>
            Task.CompletedTask;

        /// <summary>
        /// Get the builder for the current <see cref="MessageCommand"/> object.
        /// </summary>
        /// <returns></returns>
        public virtual SlashCommandBuilder GetBuilder() =>
            new SlashCommandBuilder();

        /// <summary>
        /// Attempts to retrieve and cast the value of a slash command option by its name.
        /// </summary>
        /// <typeparam name="T">The expected type of the option's value.</typeparam>
        /// <param name="command">The <see cref="SocketSlashCommand"/> containing the options.</param>
        /// <param name="name">The name of the option to retrieve.</param>
        /// <param name="value">When this method returns, contains the value of the option cast to <typeparamref name="T"/> if successful; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <returns><c>true</c> if the option was found and successfully cast to <typeparamref name="T"/>; otherwise, <c>false</c>.</returns>
        public static bool TryGetOptionValue<T>(SocketSlashCommand command, string name, out T value) {
            value = default;
            if (command?.Data?.Options == null)
                return false;
            SocketSlashCommandDataOption? option = command.Data.Options.FirstOrDefault(o => o.Name == name);
            if (option == null || option.Value == null)
                return false;
            try {
                if (option.Value is T castValue) {
                    value = castValue;
                    return true;
                }
                value = (T)Convert.ChangeType(option.Value, typeof(T));
                return true;
            }
            catch {
                return false;
            }
        }

    }

}