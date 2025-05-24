using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.MessageUpdated"/>
    public class OnMessageUpdated : OnEventBase {

        public OnMessageUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.MessageUpdated"/>
        protected virtual Task Event(Cacheable<IMessage, ulong> a, SocketMessage b, ISocketMessageChannel c) {
            return Task.CompletedTask;
        }

    }
}