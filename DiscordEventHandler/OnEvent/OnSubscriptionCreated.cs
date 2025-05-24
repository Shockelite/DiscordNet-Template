using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SubscriptionCreated"/>
    public class OnSubscriptionCreated : OnEventBase {

        public OnSubscriptionCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SubscriptionCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SubscriptionCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.SubscriptionCreated"/>
        protected virtual Task Event(SocketSubscription arg) {
            return Task.CompletedTask;
        }

    }
}