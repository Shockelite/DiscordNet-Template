using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.PollVoteAdded"/>
    public class OnPollVoteAdded : OnEventBase {

        public OnPollVoteAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.PollVoteAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.PollVoteAdded -= Event;

        /// <inheritdoc cref="BaseSocketClient.PollVoteAdded"/>
        private Task Event(Cacheable<IUser, ulong> arg1, Cacheable<ISocketMessageChannel, Rest.IRestMessageChannel, IMessageChannel, ulong> arg2, Cacheable<IUserMessage, ulong> arg3, Cacheable<SocketGuild, Rest.RestGuild, IGuild, ulong>? arg4, ulong arg5) {
            return Task.CompletedTask;
        }

    }
}