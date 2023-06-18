using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandSlash {

    /// <summary>
    /// Reply to message with Pong!.
    /// </summary>
    public class Ping : CommandSlashBase {

        /// <inheritdoc cref="Ping"/>
        public Ping() : base(true) { }

        public override string GetName() =>
            GetType().Name.ToLower();

        public override Task Start(EventHandler eventHandler, SocketSlashCommand arg) {
            arg.RespondAsync("Pong!", ephemeral: true);
            return base.Start(eventHandler, arg);
        }

        public override SlashCommandBuilder GetBuilder() {
            return new SlashCommandBuilder()
                .WithName(GetName())
                .WithDescription("Replies with Pong!")
                .WithNsfw(false)
                .WithDMPermission(false)
                .WithDefaultPermission(false)
                .WithDefaultMemberPermissions(GuildPermission.Administrator);
        }

    }

}