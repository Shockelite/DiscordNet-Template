using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ChannelCreated"/>
    public class OnChannelCreated : OnEventBase {

        public OnChannelCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ChannelCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ChannelCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.ChannelCreated"/>
        protected virtual Task Event(SocketChannel a) {
            return Task.CompletedTask;
        }

    }
}