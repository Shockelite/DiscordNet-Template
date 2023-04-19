using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.RoleUpdated"/>
    public class OnRoleUpdated : OnEventBase {

        public OnRoleUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RoleUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RoleUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.RoleUpdated"/>
        public Task Event(SocketRole arg1, SocketRole arg2) {
            return Task.CompletedTask;
        }

    }
}