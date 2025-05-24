using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.MessageDeleted"/>
    public class OnMessageDeleted : OnEventBase {

        public OnMessageDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.MessageDeleted"/>
        protected virtual Task Event(Cacheable<IMessage, ulong> message, Cacheable<IMessageChannel, ulong> channel) {
            return Task.CompletedTask;
        }

    }
}