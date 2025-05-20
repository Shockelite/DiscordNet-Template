using System;
using Discord.WebSocket;

namespace Discord.CommandClassic {

    [Flags]
    public enum CommandClassicFlags {
        None = 0,
        /// <summary>
        /// Condition <see cref="SocketMessage.Content"/> must equal <see cref="CommandClassicBase.ConditionEquals"/>.
        /// </summary>
        Equals = 1,
        /// <summary>
        /// Condition <see cref="SocketMessage.Content"/> must start with <see cref="CommandClassicBase.ConditionEndsWith"/>.
        /// </summary>
        StartsWith = 2,
        /// <summary>
        /// Condition <see cref="SocketMessage.Content"/> must contain <see cref="CommandClassicBase.ConditionContains"/>.
        /// </summary>
        Contains = 4,
        /// <summary>
        /// Condition <see cref="SocketMessage.Content"/> must end with <see cref="CommandClassicBase.ConditionEndsWith"/>.
        /// </summary>
        EndsWith = 8,
        /// <summary>
        /// Condition <see cref="SocketMessage.Content"/> <see cref="System.Text.RegularExpressions.Regex.IsMatch(string)"/> with <see cref="CommandClassicBase.ConditionRegex"/>.
        /// </summary>
        /// <remarks>
        /// Although available, this is more resource heavy than the other options.
        /// </remarks>
        Regex = 16,
        /// <summary>
        /// Condition <see cref="Random.NextDouble()"/> must be lower than <see cref="CommandClassicBase.ConditionRandom"/>.
        /// </summary>
        Random = 32,
        /// <summary>
        /// If the command passes and executes, this prevents other classic commands from running.
        /// </summary>
        Break = 64
    }

}