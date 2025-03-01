﻿using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.AutoModActionExecuted"/>
    public class OnAutoModActionExecuted : OnEventBase {

        public OnAutoModActionExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AutoModActionExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AutoModActionExecuted -= Event;

        /// <inheritdoc cref="BaseSocketClient.AutoModActionExecuted"/>
        private Task Event(SocketGuild arg1, AutoModRuleAction arg2, AutoModActionExecutedData arg3) {
            throw new System.NotImplementedException();
        }

    }
}