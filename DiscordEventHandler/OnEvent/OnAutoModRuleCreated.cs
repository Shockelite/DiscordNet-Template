using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.AutoModRuleCreated"/>
    public class OnAutoModRuleCreated : OnEventBase {

        public OnAutoModRuleCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AutoModRuleCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AutoModRuleCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.AutoModRuleCreated"/>
        private Task Event(SocketAutoModRule arg) {
            return Task.CompletedTask;
        }

    }
}