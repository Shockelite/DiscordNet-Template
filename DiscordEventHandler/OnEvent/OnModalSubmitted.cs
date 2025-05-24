using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ModalSubmitted"/>
    public class OnModalSubmitted : OnEventBase {

        public OnModalSubmitted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ModalSubmitted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ModalSubmitted -= Event;

        /// <inheritdoc cref="BaseSocketClient.ModalSubmitted"/>
        protected virtual Task Event(SocketModal arg) {
            return Task.CompletedTask;
        }

    }
}