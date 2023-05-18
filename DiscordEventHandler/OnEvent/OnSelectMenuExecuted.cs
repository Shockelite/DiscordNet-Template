using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.SelectMenuExecuted"/>
    public class OnSelectMenuExecuted : OnEventBase {

        public OnSelectMenuExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SelectMenuExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SelectMenuExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.SelectMenuExecuted"/>
        public Task Event(SocketMessageComponent arg) {
            return Task.CompletedTask;
        }

    }
}