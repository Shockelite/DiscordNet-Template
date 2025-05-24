using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.JoinedGuild"/>
    public class OnGuildJoin : OnEventBase {

        public OnGuildJoin(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.JoinedGuild += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.JoinedGuild -= Event;

        /// <inheritdoc cref="BaseSocketClient.JoinedGuild"/>
        protected virtual Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}