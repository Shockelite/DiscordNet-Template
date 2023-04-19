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
        public Task Event(SocketCustomSticker arg) {
            return Task.CompletedTask;
        }

    }
}