using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserUnbanned"/>
    public class OnUserUnbanned : OnEventBase {

        public OnUserUnbanned(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserUnbanned += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserUnbanned -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserUnbanned"/>
        protected virtual Task Event(SocketUser arg1, SocketGuild arg2) {
            return Task.CompletedTask;
        }

    }
}