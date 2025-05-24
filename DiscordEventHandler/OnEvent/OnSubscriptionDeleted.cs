using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SubscriptionDeleted"/>
    public class OnSubscriptionDeleted : OnEventBase {

        public OnSubscriptionDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SubscriptionDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SubscriptionDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.SubscriptionDeleted"/>
        protected virtual Task Event(Cacheable<SocketSubscription, ulong> arg) {
            return Task.CompletedTask;
        }

    }
}