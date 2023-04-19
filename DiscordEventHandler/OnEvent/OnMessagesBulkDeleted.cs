using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.MessagesBulkDeleted"/>
    public class OnMessagesBulkDeleted : OnEventBase {

        public OnMessagesBulkDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessagesBulkDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessagesBulkDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.MessagesBulkDeleted"/>
        public Task Event(IReadOnlyCollection<Cacheable<IMessage, ulong>> arg1, Cacheable<IMessageChannel, ulong> arg2) {
            return Task.CompletedTask;
        }

    }
}