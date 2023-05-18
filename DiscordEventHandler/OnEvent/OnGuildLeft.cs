using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.LeftGuild"/>
    public class OnGuildLeft : OnEventBase {

        public OnGuildLeft(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.LeftGuild += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.LeftGuild -= Event;

        /// <inheritdoc cref="BaseSocketClient.LeftGuild"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}