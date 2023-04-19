using Discord.WebSocket;

namespace Discord {

    /// <summary>
    /// Base for all types of commands.
    /// </summary>
    public abstract class CommandBase : ConsoleLoggingBase {

        /// <summary>
        /// If the command should register globally or in select <see cref="SocketGuild"/>(s).
        /// </summary>
        public bool IsGlobal { get; protected set; }

        /// <summary>
        /// Used to define the unique name of command per category.
        /// </summary>
        /// <returns></returns>
        public virtual string GetName() =>
            GetType().Name;

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandBase(bool isGlobal) {
            IsGlobal = isGlobal;
        }

    }

}