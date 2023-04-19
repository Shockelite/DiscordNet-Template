using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildUnavailable"/>
    public class OnGuildUnavailable : OnEventBase {

        public OnGuildUnavailable(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildUnavailable += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildUnavailable -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildUnavailable"/>
        public Task Event(SocketGuild arg) {
            return Task.CompletedTask;
        }

    }
}