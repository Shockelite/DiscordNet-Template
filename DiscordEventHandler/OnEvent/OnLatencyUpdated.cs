using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.LatencyUpdated"/>
    public class OnLatencyUpdated : OnEventBase {

        public OnLatencyUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.LatencyUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.LatencyUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.LatencyUpdated"/>
        public Task Event(int arg1, int arg2) {
            return Task.CompletedTask;
        }

    }
}