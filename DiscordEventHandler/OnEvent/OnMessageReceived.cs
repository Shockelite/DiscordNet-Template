using System;
using System.Threading.Tasks;
using Discord.CommandClassic;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.MessageReceived"/>
    public class OnMessageReceived : OnEventBase {

        public Random rng;

        public OnMessageReceived(EventHandler eventHandler) : base(eventHandler) {
            rng = new Random();
        }

        public override void Subscribe() =>
            EventHandler.Client.MessageReceived += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageReceived -= Event;

        /// <inheritdoc cref="BaseSocketClient.MessageReceived"/>
        public Task Event(SocketMessage arg) {
            if (!arg.Author.IsBot && !string.IsNullOrWhiteSpace(arg.Content)) {
                foreach (CommandClassicBase command in EventHandler.ClassicCommands) {
                    if (!command.IsGlobal && !(arg.Author is SocketGuildUser))
                        continue;
#pragma warning disable CS8602, CS8604 // Dereference of a possibly null reference.
                    if (command.Flags.HasFlag(CommandClassicFlags.Equals)) {
                        if (!arg.Content.Equals(command.ConditionEquals, StringComparison.OrdinalIgnoreCase))
                            continue;
                    }
                    else {
                        if (command.Flags.HasFlag(CommandClassicFlags.StartsWith) && !arg.Content.StartsWith(command.ConditionStartsWith, StringComparison.OrdinalIgnoreCase))
                            continue;
                        if (command.Flags.HasFlag(CommandClassicFlags.Contains) && !arg.Content.Contains(command.ConditionContains, StringComparison.OrdinalIgnoreCase))
                            continue;
                        if (command.Flags.HasFlag(CommandClassicFlags.EndsWith) && !arg.Content.EndsWith(command.ConditionEndsWith, StringComparison.OrdinalIgnoreCase))
                            continue;
                        if (command.Flags.HasFlag(CommandClassicFlags.Regex) && !command.ConditionRegex.IsMatch(arg.Content))
                            continue;
                    }
#pragma warning restore CS8602, CS8604 // Dereference of a possibly null reference.
                    if (command.Flags.HasFlag(CommandClassicFlags.Random) && rng.NextDouble() > command.ConditionRandom)
                        continue;
                    Task.Run(() => command.OnStart(EventHandler, arg));
                    break;
                }
            }
            return Task.CompletedTask;
        }

    }
}