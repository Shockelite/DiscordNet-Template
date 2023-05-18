using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ThreadUpdated"/>
    public class OnThreadUpdated : OnEventBase {

        public OnThreadUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.ThreadUpdated"/>
        public Task Event(Discord.Cacheable<SocketThreadChannel, ulong> arg1, SocketThreadChannel arg2) {
            return Task.CompletedTask;
        }

    }
}