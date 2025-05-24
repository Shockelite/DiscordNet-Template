using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.RoleCreated"/>
    public class OnRoleCreated : OnEventBase {

        public OnRoleCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RoleCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RoleCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.RoleCreated"/>
        protected virtual Task Event(SocketRole arg) {
            return Task.CompletedTask;
        }

    }
}