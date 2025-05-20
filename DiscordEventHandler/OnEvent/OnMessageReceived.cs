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
                    if (command.ContextType == 0)
                        continue;
                    if (!command.ContextType.HasFlag(CommandContextType.Guild) && arg.Author is IGuildUser)
                        continue;
                    if (!command.ContextType.HasFlag(CommandContextType.DM) && arg.Channel is IDMChannel)
                        continue;
                    if (!command.ContextType.HasFlag(CommandContextType.Private) && arg.Channel is ISocketPrivateChannel)
                        continue;
                    if (command.ConditionEquals != null && !arg.Content.Equals(command.ConditionEquals, StringComparison.OrdinalIgnoreCase))
                        continue;
                    if (command.ConditionStartsWith != null && !arg.Content.StartsWith(command.ConditionStartsWith, StringComparison.OrdinalIgnoreCase))
                        continue;
                    if (command.ConditionContains != null && !arg.Content.Contains(command.ConditionContains, StringComparison.OrdinalIgnoreCase))
                        continue;
                    if (command.ConditionEndsWith != null && !arg.Content.EndsWith(command.ConditionEndsWith, StringComparison.OrdinalIgnoreCase))
                        continue;
                    if (command.ConditionRegex != null && !command.ConditionRegex.IsMatch(arg.Content))
                        continue;
                    if (command.ConditionRandom < 1.0f && rng.NextDouble() > command.ConditionRandom)
                        continue;
                    Task.Run(() => command.OnStart(EventHandler, arg));
                    break;
                }
            }
            return Task.CompletedTask;
        }

    }
}