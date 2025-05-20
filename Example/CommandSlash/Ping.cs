using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandSlash {

    /// <summary>
    /// Reply to message with Pong!.
    /// </summary>
    public class Ping : CommandSlashBase {

        /// <inheritdoc cref="Ping"/>
        public Ping() : base(true, CommandContextType.Guild) { }

        public override string GetName() =>
            GetType().Name.ToLower();

        public override Task OnStart(EventHandler eventHandler, SocketSlashCommand arg) {
            arg.RespondAsync("Pong!", ephemeral: true);
            return base.OnStart(eventHandler, arg);
        }

        public override SlashCommandBuilder GetBuilder() {
            return new SlashCommandBuilder()
                .WithName(GetName())
                .WithDescription("Replies with Pong!")
                .WithNsfw(false)
                .WithContextTypes(GetInteractionContextType())
                .WithDefaultPermission(false)
                .WithDefaultMemberPermissions(GuildPermission.Administrator);
        }

    }

}