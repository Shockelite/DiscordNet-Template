using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.AuditLogCreated"/>
    public class OnAuditLogCreated : OnEventBase {

        public OnAuditLogCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AuditLogCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AuditLogCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.AuditLogCreated"/>
        protected virtual Task Event(SocketAuditLogEntry arg1, SocketGuild arg2) {
            return Task.CompletedTask;
        }

    }
}