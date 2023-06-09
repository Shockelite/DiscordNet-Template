﻿using System.Threading.Tasks;

namespace Discord.OnEvent {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserIsTyping"/>
    public class OnUserIsTyping : OnEventBase {

        public OnUserIsTyping(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserIsTyping += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserIsTyping -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserIsTyping"/>
        public Task Event(Discord.Cacheable<Discord.IUser, ulong> arg1, Discord.Cacheable<Discord.IMessageChannel, ulong> arg2) {
            return Task.CompletedTask;
        }

    }
}