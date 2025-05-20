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
            if (EventHandler.MessageCommands.TryGetValue(arg.CommandName, out CommandMessage.CommandMessageBase? command) && command != null)
                if (command.ContextType == 0)
                    LogWarning("Message command " + command.GetType().FullName + " was skipped because it was not given any permissions.");
                else if (!command.ContextType.HasFlag(CommandContextType.Guild) && arg.User is IGuildUser)
                    Log("Message command " + command.GetType().FullName + " was skipped because its not available in servers.");
                else if (!command.ContextType.HasFlag(CommandContextType.DM) && arg.Channel is IDMChannel)
                    Log("Message command " + command.GetType().FullName + " was skipped because its not available in DM channels.");
                else if (!command.ContextType.HasFlag(CommandContextType.Private) && arg.Channel is ISocketPrivateChannel)
                    Log("Message command " + command.GetType().FullName + " was skipped because its not available in private channels.");
                else
                    _ = Task.Run(() => command.OnStart(EventHandler, arg));
            else
                LogWarning("No message command found for \"" + arg.CommandName + "\".");
            return Task.CompletedTask;
        }

    }
}