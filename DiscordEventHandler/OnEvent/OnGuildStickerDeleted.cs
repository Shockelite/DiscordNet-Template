using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildStickerDeleted"/>
    public class OnGuildStickerDeleted : OnEventBase {

        public OnGuildStickerDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildStickerDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildStickerDeleted -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildStickerDeleted"/>
        protected virtual Task Event(SocketCustomSticker arg) {
            return Task.CompletedTask;
        }

    }
}