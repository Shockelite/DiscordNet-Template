using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.Log"/>
    public class OnLog : OnEventBase {

        public OnLog(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Log += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Log -= Event;

        /// <inheritdoc cref="BaseSocketClient.Log"/>
        public Task Event(LogMessage arg) {
            return Task.CompletedTask;
        }

    }
}