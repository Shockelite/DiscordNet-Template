using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ThreadMemberJoined"/>
    public class OnThreadMemberJoined : OnEventBase {

        public OnThreadMemberJoined(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadMemberJoined += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadMemberJoined -= Event;

        /// <inheritdoc cref="BaseSocketClient.ThreadMemberJoined"/>
        public Task Event(SocketThreadUser arg) {
            return Task.CompletedTask;
        }

    }
}