using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ThreadCreated"/>
    public class OnThreadCreated : OnEventBase {

        public OnThreadCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.ThreadCreated"/>
        public Task Event(SocketThreadChannel arg) {
            return Task.CompletedTask;
        }

    }
}