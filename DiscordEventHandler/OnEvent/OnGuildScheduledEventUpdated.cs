using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventUpdated"/>
    public class OnGuildScheduledEventUpdated : OnEventBase {

        public OnGuildScheduledEventUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventUpdated"/>
        protected virtual Task Event(Cacheable<SocketGuildEvent, ulong> arg1, SocketGuildEvent arg2) {
            return Task.CompletedTask;
        }

    }
}