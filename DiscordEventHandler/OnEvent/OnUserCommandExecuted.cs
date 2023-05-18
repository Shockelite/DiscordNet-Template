using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserCommandExecuted"/>
    public class OnUserCommandExecuted : OnEventBase {

        public OnUserCommandExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserCommandExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserCommandExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserCommandExecuted"/>
        public Task Event(SocketUserCommand arg) {
            if (EventHandler.UserCommands.TryGetValue(arg.CommandName, out var command) && command != null)
                _ = Task.Run(() => command.Start(EventHandler, arg));
            else
                LogWarning("No user command found for \"" + arg.CommandName + "\".");
            return Task.CompletedTask;
        }

    }
}