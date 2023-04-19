using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.Connected"/>
    public class OnConnected : OnEventBase {

        public OnConnected(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Connected += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Connected -= Event;

        /// <inheritdoc cref="BaseSocketClient.Connected"/>
        public Task Event() {
            return Task.CompletedTask;
        }

    }
}