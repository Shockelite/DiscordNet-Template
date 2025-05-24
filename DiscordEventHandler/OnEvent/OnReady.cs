using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord.OnEvent {

    /// <inheritdoc cref="BaseSocketClient.Ready"/>
    public class OnReady : OnEventBase {

        private bool doInit;

        public OnReady(EventHandler eventHandler) : base(eventHandler) {
            // Set this to true to setup application commands on startup.
            doInit = true;
        }

        public override void Subscribe() =>
            EventHandler.Client.Ready += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Ready -= Event;

        /// <inheritdoc cref="BaseSocketClient.Ready"/>
        protected virtual Task Event() {
            if (doInit) {
                doInit = false;
                _ = Task.Run(async () => {
                    List<ApplicationCommandProperties> globalCommands = new List<ApplicationCommandProperties>();
                    globalCommands.AddRange(EventHandler.MessageCommands.Values.Where(x => x.IsGlobal).Select(x => x.GetBuilder().Build()));
                    globalCommands.AddRange(EventHandler.SlashCommands.Values.Where(x => x.IsGlobal).Select(x => x.GetBuilder().Build()));
                    globalCommands.AddRange(EventHandler.UserCommands.Values.Where(x => x.IsGlobal).Select(x => x.GetBuilder().Build()));
                    if (globalCommands.Any()) {
                        await EventHandler.Client.BulkOverwriteGlobalApplicationCommandsAsync(globalCommands.ToArray());
                        foreach (ApplicationCommandProperties globalCommand in globalCommands)
                            Log("Global." + globalCommand.GetType().Name + "." + globalCommand.Name);
                    }

                    List<ApplicationCommandProperties> guildCommands = new List<ApplicationCommandProperties>();
                    guildCommands.AddRange(EventHandler.MessageCommands.Values.Where(x => !x.IsGlobal).Select(x => x.GetBuilder().Build()));
                    guildCommands.AddRange(EventHandler.SlashCommands.Values.Where(x => !x.IsGlobal).Select(x => x.GetBuilder().Build()));
                    guildCommands.AddRange(EventHandler.UserCommands.Values.Where(x => !x.IsGlobal).Select(x => x.GetBuilder().Build()));
                    if (guildCommands.Any()) {
                        foreach (SocketGuild guild in EventHandler.Client.Guilds)
                            await guild.BulkOverwriteApplicationCommandAsync(guildCommands.ToArray());
                        foreach (ApplicationCommandProperties guildCommand in guildCommands)
                            Log("Guild." + guildCommand.GetType().Name + "." + guildCommand.Name);
                    }
                });
            }
            return Task.CompletedTask;
        }

    }

}