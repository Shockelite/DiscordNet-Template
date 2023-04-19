using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventUserAdd"/>
    public class OnGuildScheduledEventUserAdd : OnEventBase {

        public OnGuildScheduledEventUserAdd(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventUserAdd += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventUserAdd -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventUserAdd"/>
        public Task Event(Discord.Cacheable<SocketUser, Discord.Rest.RestUser, Discord.IUser, ulong> arg1, SocketGuildEvent arg2) {
            return Task.CompletedTask;
        }

    }
}