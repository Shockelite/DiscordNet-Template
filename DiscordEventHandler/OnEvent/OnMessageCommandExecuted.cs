using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.MessageCommandExecuted"/>
    public class OnMessageCommandExecuted : OnEventBase {

        public OnMessageCommandExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageCommandExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageCommandExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.MessageCommandExecuted"/>
        public Task Event(SocketMessageCommand arg) {
            if (EventHandler.MessageCommands.TryGetValue(arg.CommandName, out var command) && command != null)
                _ = Task.Run(() => command.Start(EventHandler, arg));
            else
                LogWarning("No message command found for \"" + arg.CommandName + "\".");
            return Task.CompletedTask;
        }

    }
}