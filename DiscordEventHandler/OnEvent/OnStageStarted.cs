using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.StageStarted"/>
    public class OnStageStarted : OnEventBase {

        public OnStageStarted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.StageStarted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.StageStarted -= Event;

        /// <inheritdoc cref="BaseSocketClient.StageStarted"/>
        public Task Event(SocketStageChannel arg) {
            return Task.CompletedTask;
        }

    }
}