using System;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Discord {

    /// <summary>
    /// Provides an example of using a DiscordSocketClient with an event handler and a command loop.
    /// </summary>
    public static class Program {

        /// <summary>
        /// Entry point for the example application.
        /// </summary>
        public static void Main(string[] args) {
            // Configuration for discord bot.
            DiscordSocketConfig config = new DiscordSocketConfig() {
                // NOTE: If you don't plan to use ClassicCommands; remove GatewayIntents.MessageContent.
                GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.MessageContent
            };

            // Create a new DiscordSocketClient with the specified configuration options.
            DiscordSocketClient client = new DiscordSocketClient(config);

            // Create a new EventHandler instance and subscribe to all events.
            EventHandler eventHandler = new EventHandler(client)
                .AddCommands(new CommandClassic.Ping(), new CommandClassic.Rand(), new CommandMessage.GetId(), new CommandSlash.Ping(), new CommandUser.GetId());

            // Enable command related functions.
            eventHandler.OnSlashCommandExecuted.Subscribe();
            eventHandler.OnUserCommandExecuted.Subscribe();
            eventHandler.OnMessageCommandExecuted.Subscribe();

            // Only add this event if messages are available to view.
            if (config.GatewayIntents.HasFlag(GatewayIntents.MessageContent))
                eventHandler.OnMessageReceived.Subscribe();

            // Start the client on a background thread.
            Task.Run(async () => {
                try {
#if DEBUG
                    await client.LoginAsync(TokenType.Bot, "TOKEN", true);
#else
                    await client.LoginAsync(TokenType.Bot, "TOKEN", true);
#endif
                    await client.StartAsync();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
            });

            // Loop indefinitely, reading commands from the console.
            while (true) {
                // Read a line of text from the console, or an empty string if the end of the input stream has been reached.
                string l = Console.ReadLine() ?? string.Empty;
                string[] c = l.Split(' ', 2);

                // Process the command entered by the user.
                switch (c[0].ToLower()) {
                    case "exit":
                    case "quit": // Quit application
                        return;
                    // Add more commands here.
                    default: // Unknown command.
                        Console.WriteLine("Unknown command: " + (string.IsNullOrWhiteSpace(c[0]) ? "Null" : "\"" + c[0] + "\""));
                        break;
                }
            }
        }

    }

}