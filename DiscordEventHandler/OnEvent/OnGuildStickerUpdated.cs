using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildStickerUpdated"/>
    public class OnGuildStickerUpdated : OnEventBase {

        public OnGuildStickerUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildStickerUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildStickerUpdated -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildStickerUpdated"/>
        public Task Event(SocketCustomSticker arg1, SocketCustomSticker arg2) {
            return Task.CompletedTask;
        }

    }
}