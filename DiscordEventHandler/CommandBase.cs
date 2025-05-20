using System.Collections.Generic;
using Discord.WebSocket;

namespace Discord {

    /// <summary>
    /// Base for all types of commands.
    /// </summary>
    public abstract class CommandBase : ConsoleLoggingBase {

        /// <summary>
        /// If the command should register globally or in select <see cref="SocketGuild"/>(s).
        /// </summary>
        public CommandContextType ContextType { get; protected set; }

        /// <summary>
        /// Used to define the unique name of command per category.
        /// </summary>
        /// <returns></returns>
        public virtual string GetName() =>
            GetType().Name;

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandBase(CommandContextType contextType = CommandContextType.None) {
            ContextType = contextType;
        }

        /// <summary>
        /// Convert local context type to Discord's <see cref="InteractionContextType"/>.
        /// </summary>
        /// <returns></returns>
        public InteractionContextType[] GetInteractionContextType() {
            if (ContextType == CommandContextType.None)
                return new InteractionContextType[0] { };

            List<InteractionContextType> result = new List<InteractionContextType>();

            if (ContextType.HasFlag(CommandContextType.Guild))
                result.Add(InteractionContextType.Guild);

            if (ContextType.HasFlag(CommandContextType.Private))
                result.Add(InteractionContextType.PrivateChannel);

            if (ContextType.HasFlag(CommandContextType.DM))
                result.Add(InteractionContextType.BotDm);

            return result.ToArray();
        }

    }

}