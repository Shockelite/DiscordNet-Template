using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserJoined"/>
    public class OnUserJoined : OnEventBase {

        public OnUserJoined(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserJoined += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserJoined -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserJoined"/>
        protected virtual Task Event(SocketGuildUser user) {
            return Task.CompletedTask;
        }

    }
}