using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandMessage {

    /// <summary>
    /// Message commands are used in the Apps menu when interacting with a message.
    /// </summary>
    public class CommandMessageBase : CommandApplicationBase {

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandMessageBase(bool isGlobal = true, CommandContextType contextType = CommandContextType.None) : base(isGlobal, contextType) { }

        public override string GetName() =>
            GetBuilder()?.Name ?? base.GetName();

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task OnStart(EventHandler eventHandler, SocketMessageCommand arg) =>
            Task.CompletedTask;

        /// <summary>
        /// Get the builder for the current <see cref="CommandMessageBase"/> object.
        /// </summary>
        /// <returns></returns>
        public virtual MessageCommandBuilder GetBuilder() =>
            new MessageCommandBuilder();

    }

}