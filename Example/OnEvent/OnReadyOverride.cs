using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.Ready"/>
    public class OnReadyOverride : OnReady {

        public OnReadyOverride(EventHandler eventHandler) : base(eventHandler) { }

        /// <inheritdoc cref="BaseSocketClient.Ready"/>
        override protected Task Event() {
            base.Event();
            Log("This is added by override.");
            return Task.CompletedTask;
        }

    }

}