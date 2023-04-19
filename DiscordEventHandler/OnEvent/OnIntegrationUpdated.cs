using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.IntegrationUpdated"/>
    public class OnIntegrationUpdated : OnEventBase {

        public OnIntegrationUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.IntegrationUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.IntegrationUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.IntegrationUpdated"/>
        public Task Event(Discord.IIntegration arg) {
            return Task.CompletedTask;
        }

    }
}