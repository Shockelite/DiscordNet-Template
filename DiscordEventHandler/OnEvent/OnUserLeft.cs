using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserLeft"/>
    public class OnUserLeft : OnEventBase {

        public OnUserLeft(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserLeft += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserLeft -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserLeft"/>
        public Task Event(SocketGuild guild, SocketUser user) {
            return Task.CompletedTask;
        }

    }
}