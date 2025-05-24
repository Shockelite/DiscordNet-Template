using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.AutoModRuleDeleted"/>
    public class OnAutoModRuleDeleted : OnEventBase {

        public OnAutoModRuleDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AutoModRuleDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AutoModRuleDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.AutoModRuleDeleted"/>
        protected virtual Task Event(SocketAutoModRule arg) {
            return Task.CompletedTask;
        }

    }
}