using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.RecipientRemoved"/>
    public class OnRecipientRemoved : OnEventBase {

        public OnRecipientRemoved(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RecipientRemoved += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RecipientRemoved -= Event;

        /// <inheritdoc cref="BaseSocketClient.RecipientRemoved"/>
        public Task Event(SocketGroupUser arg) {
            return Task.CompletedTask;
        }

    }
}