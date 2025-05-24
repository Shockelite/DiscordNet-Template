using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.CurrentUserUpdated"/>
    public class OnCurrentUserUpdated : OnEventBase {

        public OnCurrentUserUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.CurrentUserUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.CurrentUserUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.CurrentUserUpdated"/>
        protected virtual Task Event(SocketSelfUser arg1, SocketSelfUser arg2) {
            return Task.CompletedTask;
        }

    }
}