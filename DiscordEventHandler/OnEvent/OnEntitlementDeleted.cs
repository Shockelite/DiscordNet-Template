using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.EntitlementDeleted"/>
    public class OnEntitlementDeleted : OnEventBase {

        public OnEntitlementDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.EntitlementDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.EntitlementDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.EntitlementDeleted"/>
        private Task Event(Cacheable<SocketEntitlement, ulong> arg) {
            return Task.CompletedTask;
        }

    }
}