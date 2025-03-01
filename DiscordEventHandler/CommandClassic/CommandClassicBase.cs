using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandClassic {

    /// <summary>
    /// <see cref="CommandClassicBase"/>s inspect incoming <see cref="SocketMessage.Content"/> for possible commands before triggering. 
    /// </summary>
    /// <remarks>
    /// You will need <see cref="GatewayIntents.MessageContent"/> enabled for these to trigger.
    /// </remarks>
    public class CommandClassicBase : CommandBase {

        /// <inheritdoc cref="CommandClassicFlags.Equals"/>
        private string? _conditionEquals;

        /// <inheritdoc cref="CommandClassicFlags.Equals"/>
        public string? ConditionEquals {
            get => _conditionEquals;
            protected set => Flags = string.IsNullOrEmpty(_conditionEquals = value)
                ? Flags & ~CommandClassicFlags.Equals
                : Flags | CommandClassicFlags.Equals;
        }

        /// <inheritdoc cref="CommandClassicFlags.StartsWith"/>
        private string? _conditionStartsWith;

        /// <inheritdoc cref="CommandClassicFlags.StartsWith"/>
        public string? ConditionStartsWith {
            get => _conditionStartsWith;
            protected set => Flags = string.IsNullOrEmpty(_conditionStartsWith = value)
                ? Flags & ~CommandClassicFlags.StartsWith
                : Flags | CommandClassicFlags.StartsWith;
        }

        /// <inheritdoc cref="CommandClassicFlags.Contains"/>
        private string? _conditionContains;

        /// <inheritdoc cref="CommandClassicFlags.Contains"/>
        public string? ConditionContains {
            get => _conditionContains;
            protected set => Flags = string.IsNullOrEmpty(_conditionContains = value)
                ? Flags & ~CommandClassicFlags.Contains
                : Flags | CommandClassicFlags.Contains;
        }

        /// <inheritdoc cref="CommandClassicFlags.EndsWith"/>
        private string? _conditionEndsWith;

        /// <inheritdoc cref="CommandClassicFlags.EndsWith"/>
        public string? ConditionEndsWith {
            get => _conditionEndsWith;
            protected set => Flags = string.IsNullOrEmpty(_conditionEndsWith = value)
                ? Flags & ~CommandClassicFlags.EndsWith
                : Flags | CommandClassicFlags.EndsWith;
        }

        /// <inheritdoc cref="CommandClassicFlags.Regex"/>
        private Regex? _conditionRegex;

        /// <inheritdoc cref="CommandClassicFlags.Regex"/>
        public Regex? ConditionRegex {
            get => _conditionRegex;
            protected set => Flags = (_conditionRegex = value) == null
                ? Flags & ~CommandClassicFlags.EndsWith
                : Flags | CommandClassicFlags.EndsWith;
        }

        /// <inheritdoc cref="CommandClassicFlags.Random"/>
        private float _conditionRandom;

        /// <inheritdoc cref="CommandClassicFlags.Random"/>
        public float ConditionRandom {
            get => _conditionRandom;
            protected set {
                _conditionRandom = value;
                Flags = value < 1.0f
                    ? Flags | CommandClassicFlags.Random
                    : Flags & ~CommandClassicFlags.Random;
            }
        }

        /// <summary>
        /// Before a command <see cref="Start(SocketMessage)"/> is run it must pass all these added conditions.
        /// </summary>
        public CommandClassicFlags Flags { get; protected set; }

        /// <summary>
        /// Default constructor for classic commands.
        /// </summary>
        /// <param name="isGlobal">If this command can be used outside of guilds.</param>
        /// <param name="equals">Message content needs to equal this to trigger. Null value disables this condition.</param>
        /// <param name="startsWith">Message content needs to start with this to trigger. Null value disables this condition.</param>
        /// <param name="contains">Message content needs to contain this to trigger. Null value disables this condition.</param>
        /// <param name="endsWith">Message content needs to contain this to trigger. Null value disables this condition.</param>
        /// <param name="regex">Message content needs match this to trigger. Null value disables this condition.</param>
        /// <param name="random">Percent 0.0f - 1.0f chance this can trigger. Values of 1.0f and above disable this condition.</param>
        public CommandClassicBase(bool isGlobal, string? equals = null, string? startsWith = null, string? contains = null, string? endsWith = null, Regex? regex = null, float random = 1f) : base(isGlobal) {
            if (!string.IsNullOrEmpty(_conditionEquals = equals))
                Flags |= CommandClassicFlags.Equals;
            if (!string.IsNullOrEmpty(_conditionStartsWith = startsWith))
                Flags |= CommandClassicFlags.StartsWith;
            if (!string.IsNullOrEmpty(_conditionContains = contains))
                Flags |= CommandClassicFlags.Contains;
            if (!string.IsNullOrEmpty(_conditionEndsWith = endsWith))
                Flags |= CommandClassicFlags.EndsWith;
            if ((_conditionRegex = regex) != null)
                Flags |= CommandClassicFlags.Regex;
            if ((_conditionRandom = random) < 1.0f)
                Flags |= CommandClassicFlags.Random;
        }

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="eventHandler">EventHandler this was triggered from.</param>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task OnStart(EventHandler eventHandler, SocketMessage arg) =>
            Task.CompletedTask;

    }

}