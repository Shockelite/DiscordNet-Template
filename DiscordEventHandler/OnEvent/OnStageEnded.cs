using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.StageEnded"/>
    public class OnStageEnded : OnEventBase {

        public OnStageEnded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.StageEnded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.StageEnded -= Event;

        /// <inheritdoc cref="BaseSocketClient.StageEnded"/>
        public Task Event(SocketStageChannel arg) {
            return Task.CompletedTask;
        }

    }
}