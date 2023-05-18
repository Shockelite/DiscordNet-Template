using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandSlash {

    /// <summary>
    /// A Discord slash command is a type of command that can be triggered in a Discord server by typing a forward slash (/) followed by a specific keyword or phrase.
    /// </summary>
    public class CommandSlashBase : CommandBase {

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandSlashBase(bool isGlobal) : base(isGlobal) { }

        public override string GetName() =>
            GetBuilder()?.Name ?? base.GetName();

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task Start(EventHandler eventHandler, SocketSlashCommand arg) =>
            Task.CompletedTask;

        /// <summary>
        /// Get the builder for the current <see cref="MessageCommand"/> object.
        /// </summary>
        /// <returns></returns>
        public virtual SlashCommandBuilder GetBuilder() =>
            new SlashCommandBuilder();

    }

}