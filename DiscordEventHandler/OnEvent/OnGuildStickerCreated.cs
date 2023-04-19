using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.GuildStickerCreated"/>
    public class OnGuildStickerCreated : OnEventBase {

        public OnGuildStickerCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildStickerCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildStickerCreated -= Event;

        /// <inheritdoc cref="BaseSocketClient.GuildStickerCreated"/>
        public Task Event(SocketCustomSticker arg) {
            return Task.CompletedTask;
        }

    }
}