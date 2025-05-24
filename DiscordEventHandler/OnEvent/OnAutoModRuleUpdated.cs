using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.AutoModRuleUpdated"/>
    public class OnAutoModRuleUpdated : OnEventBase {

        public OnAutoModRuleUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AutoModRuleUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AutoModRuleUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.AutoModRuleUpdated"/>
        protected virtual Task Event(Cacheable<SocketAutoModRule, ulong> arg1, SocketAutoModRule arg2) {
            return Task.CompletedTask;
        }

    }
}