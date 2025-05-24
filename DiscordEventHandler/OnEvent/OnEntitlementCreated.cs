using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.EntitlementCreated"/>
    public class OnEntitlementCreated : OnEventBase {

        public OnEntitlementCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.EntitlementCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.EntitlementCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.EntitlementCreated"/>
        protected virtual Task Event(SocketEntitlement arg) {
            return Task.CompletedTask;
        }

    }
}