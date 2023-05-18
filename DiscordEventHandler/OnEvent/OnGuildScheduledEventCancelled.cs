using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventCancelled"/>
    public class OnGuildScheduledEventCancelled : OnEventBase {

        public OnGuildScheduledEventCancelled(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventCancelled += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventCancelled -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventCancelled"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}