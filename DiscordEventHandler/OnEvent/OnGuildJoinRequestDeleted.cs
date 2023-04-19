using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildJoinRequestDeleted"/>
    public class OnGuildJoinRequestDeleted : OnEventBase {

        public OnGuildJoinRequestDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildJoinRequestDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildJoinRequestDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildJoinRequestDeleted"/>
        public Task Event(Cacheable<SocketGuildUser, ulong> a, SocketGuild b) {
            return Task.CompletedTask;
        }

    }
}