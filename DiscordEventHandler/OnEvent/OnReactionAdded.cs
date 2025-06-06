﻿using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.ReactionAdded"/>
    public class OnReactionAdded : OnEventBase {

        public OnReactionAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionAdded -= Event;

        /// <inheritdoc cref="BaseSocketClient.ReactionAdded"/>
        protected virtual Task Event(Cacheable<IUserMessage, ulong> arg1, Cacheable<IMessageChannel, ulong> arg2, SocketReaction arg3) {
            return Task.CompletedTask;
        }

    }
}