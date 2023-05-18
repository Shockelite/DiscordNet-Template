using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ApplicationCommandDeleted"/>
    public class OnApplicationCommandDeleted : OnEventBase {

        public OnApplicationCommandDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ApplicationCommandDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ApplicationCommandDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.ApplicationCommandDeleted"/>
        public Task Event(SocketApplicationCommand arg) {
            return Task.CompletedTask;
        }

    }
}