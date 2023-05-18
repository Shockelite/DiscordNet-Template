using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.RecipientAdded"/>
    public class OnRecipientAdded : OnEventBase {

        public OnRecipientAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RecipientAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RecipientAdded -= Event;

        /// <inheritdoc cref="BaseSocketClient.RecipientAdded"/>
        public Task Event(SocketGroupUser arg) {
            return Task.CompletedTask;
        }

    }
}