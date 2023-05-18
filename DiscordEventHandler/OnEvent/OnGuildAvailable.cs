using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildAvailable"/>
    public class OnGuildAvailable : OnEventBase {

        public OnGuildAvailable(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildAvailable += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildAvailable -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildAvailable"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}