using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.InviteCreated"/>
    public class OnInviteCreated : OnEventBase {

        public OnInviteCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.InviteCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.InviteCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.InviteCreated"/>
        public Task Event(SocketInvite a) {
            return Task.CompletedTask;
        }

    }
}