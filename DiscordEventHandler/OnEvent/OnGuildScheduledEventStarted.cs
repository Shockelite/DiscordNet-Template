using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventStarted"/>
    public class OnGuildScheduledEventStarted : OnEventBase {

        public OnGuildScheduledEventStarted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventStarted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventStarted -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventStarted"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}