using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ApplicationCommandCreated"/>
    public class OnApplicationCommandCreated : OnEventBase {

        public OnApplicationCommandCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ApplicationCommandCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ApplicationCommandCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.ApplicationCommandCreated"/>
        public Task Event(SocketApplicationCommand arg) {
            return Task.CompletedTask;
        }

    }
}