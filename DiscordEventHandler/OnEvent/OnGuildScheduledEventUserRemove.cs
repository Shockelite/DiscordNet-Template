using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventUserRemove"/>
    public class OnGuildScheduledEventUserRemove : OnEventBase {

        public OnGuildScheduledEventUserRemove(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventUserRemove += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventUserRemove -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventUserRemove"/>
        protected virtual Task Event(Cacheable<SocketUser, Rest.RestUser, IUser, ulong> arg1, SocketGuildEvent arg2) {
            return Task.CompletedTask;
        }

    }
}