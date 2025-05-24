using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.PresenceUpdated"/>
    public class OnPresenceUpdated : OnEventBase {

        public OnPresenceUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.PresenceUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.PresenceUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.PresenceUpdated"/>
        protected virtual Task Event(SocketUser user, SocketPresence before, SocketPresence after) {
            return Task.CompletedTask;
        }

    }
}