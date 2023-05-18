using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ReactionsRemovedForEmote"/>
    public class OnReactionsRemovedForEmote : OnEventBase {

        public OnReactionsRemovedForEmote(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionsRemovedForEmote += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionsRemovedForEmote -= Event;

        /// <inheritdoc cref="BaseSocketClient.ReactionsRemovedForEmote"/>
        public Task Event(Discord.Cacheable<Discord.IUserMessage, ulong> arg1, Discord.Cacheable<Discord.IMessageChannel, ulong> arg2, Discord.IEmote arg3) {
            return Task.CompletedTask;
        }

    }
}