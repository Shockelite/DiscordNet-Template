using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SlashCommandExecuted"/>
    public class OnSlashCommandExecuted : OnEventBase {

        public OnSlashCommandExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SlashCommandExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SlashCommandExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.SlashCommandExecuted"/>
        protected virtual Task Event(SocketSlashCommand arg) {
            if (EventHandler.SlashCommands.TryGetValue(arg.CommandName, out CommandSlash.CommandSlashBase? command) && command != null) {
                if (command.ContextType == 0)
                    LogWarning("Slash command " + command.GetType().FullName + " was skipped because it was not given any permissions.");
                else if (!command.ContextType.HasFlag(CommandContextType.Guild) && arg.User is IGuildUser)
                    Log("Slash command " + command.GetType().FullName + " was skipped because its not available in servers.");
                else if (!command.ContextType.HasFlag(CommandContextType.DM) && arg.Channel is IDMChannel)
                    Log("Slash command " + command.GetType().FullName + " was skipped because its not available in DM channels.");
                else if (!command.ContextType.HasFlag(CommandContextType.Private) && arg.Channel is ISocketPrivateChannel)
                    Log("Slash command " + command.GetType().FullName + " was skipped because its not available in private channels.");
                else
                    _ = Task.Run(() => command.OnStart(EventHandler, arg));
            }
            else
                LogWarning("No slash command found for \"" + arg.CommandName + "\".");
            return Task.CompletedTask;
        }

    }
}