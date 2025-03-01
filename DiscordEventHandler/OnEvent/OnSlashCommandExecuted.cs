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
        public Task Event(SocketSlashCommand arg) {
            if (EventHandler.SlashCommands.TryGetValue(arg.CommandName, out var command) && command != null)
                _ = Task.Run(() => command.OnStart(EventHandler, arg));
            else
                LogWarning("No slash command found for \"" + arg.CommandName + "\".");
            return Task.CompletedTask;
        }

    }
}