﻿using Discord.WebSocket;

namespace Discord.CommandClassic {

    /// <summary>
    /// Respond when content contains "I Like" with 20% chance.
    /// </summary>
    public class Rand : CommandClassicBase {

        /// <inheritdoc cref="Rand"/>
        public Rand() : base(true, contains: "i like", random: 0.2f) { }

        public override Task Start(EventHandler eventHandler, SocketMessage arg) {
            arg.Channel.SendMessageAsync("Whatever floats your boat.");
            return base.Start(eventHandler, arg);
        }

    }

}