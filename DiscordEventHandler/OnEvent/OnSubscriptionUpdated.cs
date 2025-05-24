using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SubscriptionUpdated"/>
    public class OnSubscriptionUpdated : OnEventBase {

        public OnSubscriptionUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SubscriptionUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SubscriptionUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.SubscriptionUpdated"/>
        protected virtual Task Event(Cacheable<SocketSubscription, ulong> arg1, SocketSubscription arg2) { 
            return Task.CompletedTask;
        }

    }
}