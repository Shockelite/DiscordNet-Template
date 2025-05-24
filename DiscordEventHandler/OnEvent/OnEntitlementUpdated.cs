using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.EntitlementUpdated"/>
    public class OnEntitlementUpdated : OnEventBase {

        public OnEntitlementUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.EntitlementUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.EntitlementUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.EntitlementUpdated"/>
        protected virtual Task Event(Cacheable<SocketEntitlement, ulong> arg1, SocketEntitlement arg2) {
            return Task.CompletedTask;
        }

    }
}