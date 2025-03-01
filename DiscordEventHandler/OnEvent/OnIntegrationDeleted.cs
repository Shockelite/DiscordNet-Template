using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.IntegrationDeleted"/>
    public class OnIntegrationDeleted : OnEventBase {

        public OnIntegrationDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.IntegrationDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.IntegrationDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.IntegrationDeleted"/>
        public Task Event(IGuild arg1, ulong arg2, Optional<ulong> arg3) {
            return Task.CompletedTask;
        }

    }
}