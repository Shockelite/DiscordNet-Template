using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.RequestToSpeak"/>
    public class OnRequestToSpeak : OnEventBase {

        public OnRequestToSpeak(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RequestToSpeak += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RequestToSpeak -= Event;

        /// <inheritdoc cref="BaseSocketClient.RequestToSpeak"/>
        public Task Event(SocketStageChannel arg1, SocketGuildUser arg2) {
            return Task.CompletedTask;
        }

    }
}