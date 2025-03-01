using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserIsTyping"/>
    public class OnUserIsTyping : OnEventBase {

        public OnUserIsTyping(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserIsTyping += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserIsTyping -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserIsTyping"/>
        public Task Event(Cacheable<IUser, ulong> arg1, Cacheable<IMessageChannel, ulong> arg2) {
            return Task.CompletedTask;
        }

    }
}