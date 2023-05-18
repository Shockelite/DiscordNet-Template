using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.AutocompleteExecuted"/>
    public class OnAutocompleteExecuted : OnEventBase {

        public OnAutocompleteExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AutocompleteExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AutocompleteExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.AutocompleteExecuted"/>
        public Task Event(SocketAutocompleteInteraction arg) {
            return Task.CompletedTask;
        }

    }
}