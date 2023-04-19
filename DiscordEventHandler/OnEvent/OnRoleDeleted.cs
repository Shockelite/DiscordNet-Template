using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.RoleDeleted"/>
    public class OnRoleDeleted : OnEventBase {

        public OnRoleDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RoleDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RoleDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.RoleDeleted"/>
        public Task Event(SocketRole arg) {
            return Task.CompletedTask;
        }

    }
}