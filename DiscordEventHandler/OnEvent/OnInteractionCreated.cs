using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.InteractionCreated"/>
    public class OnInteractionCreated : OnEventBase {

        public OnInteractionCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.InteractionCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.InteractionCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.InteractionCreated"/>
        public Task Event(SocketInteraction arg) {
            return Task.CompletedTask;
        }

    }
}