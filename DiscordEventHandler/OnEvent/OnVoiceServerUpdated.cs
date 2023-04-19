using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.VoiceServerUpdated"/>
    public class OnVoiceServerUpdated : OnEventBase {

        public OnVoiceServerUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.VoiceServerUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.VoiceServerUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.VoiceServerUpdated"/>
        public Task Event(SocketVoiceServer arg) {
            return Task.CompletedTask;
        }

    }
}