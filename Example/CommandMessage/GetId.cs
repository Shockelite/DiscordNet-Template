using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandMessage {

    /// <summary>
    /// Get Id of message.
    /// </summary>
    public class GetId : CommandMessageBase {

        /// <inheritdoc cref="GetId"/>
        public GetId() : base(true, CommandContextType.Guild) { }

        public override string GetName() =>
            "Get Message Id";

        public override Task OnStart(EventHandler eventHandler, SocketMessageCommand arg) {
            arg.RespondAsync("Message Id: " + arg.Data.Message.Id, ephemeral: true);
            return base.OnStart(eventHandler, arg);
        }

        public override MessageCommandBuilder GetBuilder() {
            return new MessageCommandBuilder()
                .WithName(GetName())
                .WithNsfw(false)
                .WithContextTypes(GetInteractionContextType())
                .WithDefaultPermission(false)
                .WithDefaultMemberPermissions(GuildPermission.Administrator);
        }

    }

}