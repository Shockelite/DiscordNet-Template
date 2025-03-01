using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.CommandClassic {

    /// <summary>
    /// Respond when content contains "I Like" with 20% chance.
    /// </summary>
    public class Rand : CommandClassicBase {

        /// <inheritdoc cref="Rand"/>
        public Rand() : base(true, contains: "i like", random: 0.2f) { }

        public override Task OnStart(EventHandler eventHandler, SocketMessage arg) {
            arg.Channel.SendMessageAsync("Whatever floats your boat.");
            return base.OnStart(eventHandler, arg);
        }

    }

}