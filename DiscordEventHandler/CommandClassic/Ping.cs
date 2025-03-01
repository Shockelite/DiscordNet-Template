using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandClassic {

    /// <summary>
    /// Reply to message with Pong!.
    /// </summary>
    public class Ping : CommandClassicBase {

        /// <inheritdoc cref="Ping"/>
        public Ping() : base(true, startsWith: "!ping") { }

        public override Task OnStart(EventHandler eventHandler, SocketMessage arg) {
            arg.Channel.SendMessageAsync("Pong!");
            return base.OnStart(eventHandler, arg);
        }

    }

}