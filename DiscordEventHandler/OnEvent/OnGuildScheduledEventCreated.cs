using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventCreated"/>
    public class OnGuildScheduledEventCreated : OnEventBase {

        public OnGuildScheduledEventCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildScheduledEventCreated"/>
        protected virtual Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}