using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SpeakerAdded"/>
    public class OnSpeakerAdded : OnEventBase {

        public OnSpeakerAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SpeakerAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SpeakerAdded -= Event;

        /// <inheritdoc cref="BaseSocketClient.SpeakerAdded"/>
        public Task Event(SocketStageChannel arg1, SocketGuildUser arg2) {
            return Task.CompletedTask;
        }

    }
}