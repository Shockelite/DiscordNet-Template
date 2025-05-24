using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.UserVoiceStateUpdated"/>
    public class OnUserVoiceStateUpdated : OnEventBase {

        public OnUserVoiceStateUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserVoiceStateUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserVoiceStateUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.UserVoiceStateUpdated"/>
        protected virtual Task Event(SocketUser arg1, SocketVoiceState before, SocketVoiceState current) {
            return Task.CompletedTask;
        }

    }
}