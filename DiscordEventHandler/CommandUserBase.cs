using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandUser {

    /// <summary>
    /// User commands are used in the Apps menu when interacting with a user.
    /// </summary>
    public class CommandUserBase : CommandApplicationBase {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isGlobal">If this command is registered into a </param>
        /// <param name="contextType">Location in which this command can be triggered from.</param>
        public CommandUserBase(bool isGlobal = true, CommandContextType contextType = CommandContextType.None) : base(isGlobal, contextType) { }

        public override string GetName() =>
            GetBuilder()?.Name ?? base.GetName();

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task OnStart(EventHandler eventHandler, SocketUserCommand arg) =>
            Task.CompletedTask;

        /// <summary>
        /// Get the builder for the current <see cref="MessageCommand"/> object.
        /// </summary>
        /// <returns></returns>
        public virtual UserCommandBuilder GetBuilder() =>
            new UserCommandBuilder();

    }

}