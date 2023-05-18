using System;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.Disconnected"/>
    public class OnDisconnected : OnEventBase {

        public OnDisconnected(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Disconnected += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Disconnected -= Event;

        /// <inheritdoc cref="BaseSocketClient.Disconnected"/>
        public Task Event(Exception arg) {
            return Task.CompletedTask;
        }

    }
}