using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SpeakerRemoved"/>
    public class OnSpeakerRemoved : OnEventBase {

        public OnSpeakerRemoved(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SpeakerRemoved += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SpeakerRemoved -= Event;

        /// <inheritdoc cref="BaseSocketClient.SpeakerRemoved"/>
        public Task Event(SocketStageChannel arg1, SocketGuildUser arg2) {
            return Task.CompletedTask;
        }

    }
}