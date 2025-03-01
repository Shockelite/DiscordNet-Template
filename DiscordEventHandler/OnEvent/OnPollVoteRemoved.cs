using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.PollVoteRemoved"/>
    public class OnPollVoteRemoved : OnEventBase {

        public OnPollVoteRemoved(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.PollVoteRemoved += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.PollVoteRemoved -= Event;

        /// <inheritdoc cref="BaseSocketClient.PollVoteRemoved"/>
        private Task Event(Cacheable<IUser, ulong> arg1, Cacheable<ISocketMessageChannel, Rest.IRestMessageChannel, IMessageChannel, ulong> arg2, Cacheable<IUserMessage, ulong> arg3, Cacheable<SocketGuild, Rest.RestGuild, IGuild, ulong>? arg4, ulong arg5) {
            return Task.CompletedTask;
        }

    }
}