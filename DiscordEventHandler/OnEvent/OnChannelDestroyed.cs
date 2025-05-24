using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ChannelDestroyed"/>
    public class OnChannelDestroyed : OnEventBase {

        public OnChannelDestroyed(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ChannelDestroyed += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ChannelDestroyed -= Event;

        /// <inheritdoc cref="BaseSocketClient.ChannelDestroyed"/>
        protected virtual Task Event(SocketChannel a) {
            return Task.CompletedTask;
        }

    }
}