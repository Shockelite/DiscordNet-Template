using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventCompleted"/>
    public class OnGuildScheduledEventCompleted : OnEventBase {

        public OnGuildScheduledEventCompleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventCompleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventCompleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventCompleted"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}