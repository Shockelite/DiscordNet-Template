using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildMembersDownloaded"/>
    public class OnGuildMembersDownloaded : OnEventBase {

        public OnGuildMembersDownloaded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildMembersDownloaded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildMembersDownloaded -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildMembersDownloaded"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}