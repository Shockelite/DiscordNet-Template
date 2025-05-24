using System.Threading.Tasks;
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
        protected virtual Task Event(IIntegration arg) {
            return Task.CompletedTask;
        }

    }
}