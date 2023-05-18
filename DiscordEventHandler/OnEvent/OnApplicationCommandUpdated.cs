using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ApplicationCommandUpdated"/>
    public class OnApplicationCommandUpdated : OnEventBase {

        public OnApplicationCommandUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ApplicationCommandUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ApplicationCommandUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.ApplicationCommandUpdated"/>
        public Task Event(SocketApplicationCommand arg) {
            return Task.CompletedTask;
        }

    }
}