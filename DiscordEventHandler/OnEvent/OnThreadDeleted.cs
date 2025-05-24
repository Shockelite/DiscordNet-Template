using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ThreadDeleted"/>
    public class OnThreadDeleted : OnEventBase {

        public OnThreadDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.ThreadDeleted"/>
        protected virtual Task Event(Discord.Cacheable<SocketThreadChannel, ulong> arg) {
            return Task.CompletedTask;
        }

    }
}