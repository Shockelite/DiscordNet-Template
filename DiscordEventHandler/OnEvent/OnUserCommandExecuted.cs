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
            if (EventHandler.UserCommands.TryGetValue(arg.CommandName, out CommandUser.CommandUserBase? command) && command != null)
                if (command.ContextType == 0)
                    LogWarning("User command " + command.GetType().FullName + " was skipped because it was not given any permissions.");
                else if (!command.ContextType.HasFlag(CommandContextType.Guild) && arg.User is IGuildUser)
                    Log("User command " + command.GetType().FullName + " was skipped because its not available in servers.");
                else if (!command.ContextType.HasFlag(CommandContextType.DM) && arg.Channel is IDMChannel)
                    Log("User command " + command.GetType().FullName + " was skipped because its not available in DM channels.");
                else if (!command.ContextType.HasFlag(CommandContextType.Private) && arg.Channel is ISocketPrivateChannel)
                    Log("User command " + command.GetType().FullName + " was skipped because its not available in private channels.");
                else
                    _ = Task.Run(() => command.OnStart(EventHandler, arg));
            else
                LogWarning("No user command found for \"" + arg.CommandName + "\".");
            return Task.CompletedTask;
        }

    }
}