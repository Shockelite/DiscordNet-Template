using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildUpdated"/>
    public class OnGuildUpdated : OnEventBase {

        public OnGuildUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildUpdated"/>
        public Task Event(SocketGuild a, SocketGuild b) {
            return Task.CompletedTask;
        }

    }
}