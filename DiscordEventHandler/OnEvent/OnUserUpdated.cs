using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserUpdated"/>
    public class OnUserUpdated : OnEventBase {

        public OnUserUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserUpdated"/>
        public Task Event(SocketUser before, SocketUser after) {
            return Task.CompletedTask;
        }

    }
}