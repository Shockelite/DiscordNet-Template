using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserBanned"/>
    public class OnUserBanned : OnEventBase {

        public OnUserBanned(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserBanned += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserBanned -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserBanned"/>
        public Task Event(SocketUser user, SocketGuild guild) {
            return Task.CompletedTask;
        }

    }
}