using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ThreadMemberLeft"/>
    public class OnThreadMemberLeft : OnEventBase {

        public OnThreadMemberLeft(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadMemberLeft += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadMemberLeft -= Event;

        /// <inheritdoc cref="BaseSocketClient.ThreadMemberLeft"/>
        public Task Event(SocketThreadUser arg) {
            return Task.CompletedTask;
        }

    }
}