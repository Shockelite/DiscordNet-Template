using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.IntegrationCreated"/>
    public class OnIntegrationCreated : OnEventBase {

        public OnIntegrationCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.IntegrationCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.IntegrationCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.IntegrationCreated"/>
        public Task Event(IIntegration arg) {
            return Task.CompletedTask;
        }

    }
}