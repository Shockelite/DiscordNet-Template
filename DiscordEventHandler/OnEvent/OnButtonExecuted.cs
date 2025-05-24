using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ButtonExecuted"/>
    public class OnButtonExecuted : OnEventBase {

        public OnButtonExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ButtonExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ButtonExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.ButtonExecuted"/>
        protected virtual Task Event(SocketMessageComponent a) {
            return Task.CompletedTask;
        }

    }
}