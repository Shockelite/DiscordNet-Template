using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildMemberUpdated"/>
    public class OnGuildMemberUpdated : OnEventBase {

        public OnGuildMemberUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildMemberUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildMemberUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildMemberUpdated"/>
        public Task Event(Cacheable<SocketGuildUser, ulong> a, SocketGuildUser b) {
            return Task.CompletedTask;
        }

    }
}