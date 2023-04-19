using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.InviteDeleted"/>
    public class OnInviteDeleted : OnEventBase {

        public OnInviteDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.InviteDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.InviteDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.InviteDeleted"/>
        public Task Event(SocketGuildChannel channel, string code) {
            return Task.CompletedTask;
        }

    }
}