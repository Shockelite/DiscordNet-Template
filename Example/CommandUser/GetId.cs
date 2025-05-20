using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandUser {

    /// <summary>
    /// Get Id of user.
    /// </summary>
    public class GetId : CommandUserBase {

        /// <inheritdoc cref="GetId"/>
        public GetId() : base(true, CommandContextType.Guild) { }

        public override string GetName() =>
            "Get User Id";

        public override Task OnStart(EventHandler eventHandler, SocketUserCommand arg) {
            arg.RespondAsync("User Id: " + arg.Data.Member.Id, ephemeral: true);
            return base.OnStart(eventHandler, arg);
        }

        public override UserCommandBuilder GetBuilder() {
            return new UserCommandBuilder()
                .WithName(GetName())
                .WithNsfw(false)
                .WithContextTypes(GetInteractionContextType())
                .WithDefaultPermission(false)
                .WithDefaultMemberPermissions(GuildPermission.Administrator);
        }

    }

}