using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ReactionsCleared"/>
    public class OnReactionsCleared : OnEventBase {

        public OnReactionsCleared(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionsCleared += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionsCleared -= Event;

        /// <inheritdoc cref="BaseSocketClient.ReactionsCleared"/>
        protected virtual Task Event(Discord.Cacheable<Discord.IUserMessage, ulong> arg1, Discord.Cacheable<Discord.IMessageChannel, ulong> arg2) {
            return Task.CompletedTask;
        }

    }
}