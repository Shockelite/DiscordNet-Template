using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ChannelUpdated"/>
    public class OnChannelUpdated : OnEventBase {

        public OnChannelUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ChannelUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ChannelUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.ChannelUpdated"/>
        protected virtual Task Event(SocketChannel a, SocketChannel b) {
            return Task.CompletedTask;
        }

    }
}