using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.LoggedOut"/>
    public class OnLoggedOut : OnEventBase {

        public OnLoggedOut(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.LoggedOut += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.LoggedOut -= Event;

        /// <inheritdoc cref="BaseSocketClient.LoggedOut"/>
        protected virtual Task Event() {
            return Task.CompletedTask;
        }

    }
}

