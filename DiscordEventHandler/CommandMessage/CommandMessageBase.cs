using Discord.WebSocket;

namespace Discord.CommandMessage {

    /// <summary>
    /// Message commands are used in the Apps menu when interacting with a message.
    /// </summary>
    public class CommandMessageBase : CommandBase {

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandMessageBase(bool isGlobal) : base(isGlobal) { }

        public override string GetName() =>
            GetBuilder()?.Name ?? base.GetName();

        /// <summary>
        /// Command start.
        /// </summary>
        /// <param name="arg">Message object.</param>
        /// <returns></returns>
        public virtual Task Start(EventHandler eventHandler, SocketMessageCommand arg) =>
            Task.CompletedTask;

        /// <summary>
        /// Get the builder for the current <see cref="CommandMessageBase"/> object.
        /// </summary>
        /// <returns></returns>
        public virtual MessageCommandBuilder GetBuilder() =>
            new MessageCommandBuilder();

    }

}