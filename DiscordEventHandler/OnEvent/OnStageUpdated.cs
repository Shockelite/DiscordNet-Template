using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.StageUpdated"/>
    public class OnStageUpdated : OnEventBase {

        public OnStageUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.StageUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.StageUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.StageUpdated"/>
        public Task Event(SocketStageChannel arg1, SocketStageChannel arg2) {
            return Task.CompletedTask;
        }

    }
}