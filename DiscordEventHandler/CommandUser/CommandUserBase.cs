using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandUser {

    /// <summary>
    /// User commands are used in the Apps menu when interacting with a user.
    /// </summary>
    public class CommandUserBase : CommandBase {

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandUserBase(bool isGlobal) : base(isGlobal) { }

        public override string GetName() =>
            GetBuilder()?.Name ?? base.GetName();

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task Start(EventHandler eventHandler, SocketUserCommand arg) =>
            Task.CompletedTask;

        /// <summary>
        /// Get the builder for the current <see cref="MessageCommand"/> object.
        /// </summary>
        /// <returns></returns>
        public virtual UserCommandBuilder GetBuilder() =>
            new UserCommandBuilder();

    }

}