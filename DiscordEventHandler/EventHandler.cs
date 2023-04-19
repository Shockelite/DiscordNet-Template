using Discord.CommandClassic;
using Discord.CommandMessage;
using Discord.CommandSlash;
using Discord.CommandUser;
using Discord.OnEvent;
using Discord.WebSocket;

namespace Discord {

    /// <summary>
    /// Holds all <see cref="BaseSocketClient"/> events.
    /// </summary>
    public class EventHandler {

        /// <summary>
        /// Object events are subscribed to.
        /// </summary>
        public readonly DiscordSocketClient Client;

        /// <summary>
        /// All events in this handler.
        /// </summary>
        public readonly List<OnEventBase> Events;

        public OnApplicationCommandCreated OnApplicationCommandCreated;
        public OnApplicationCommandDeleted OnApplicationCommandDeleted;
        public OnApplicationCommandUpdated OnApplicationCommandUpdated;
        public OnAutocompleteExecuted OnAutocompleteExecuted;
        public OnButtonExecuted OnButtonExecuted;
        public OnChannelCreated OnChannelCreated;
        public OnChannelDestroyed OnChannelDestroyed;
        public OnChannelUpdated OnChannelUpdated;
        public OnConnected OnConnected;
        public OnCurrentUserUpdated OnCurrentUserUpdated;
        public OnDisconnected OnDisconnected;
        public OnGuildAvailable OnGuildAvailable;
        public OnGuildJoin OnGuildJoin;
        public OnGuildJoinRequestDeleted OnGuildJoinRequestDeleted;
        public OnGuildLeft OnGuildLeft;
        public OnGuildMembersDownloaded OnGuildMembersDownloaded;
        public OnGuildMemberUpdated OnGuildMemberUpdated;
        public OnGuildScheduledEventCancelled OnGuildScheduledEventCancelled;
        public OnGuildScheduledEventCompleted OnGuildScheduledEventCompleted;
        public OnGuildScheduledEventCreated OnGuildScheduledEventCreated;
        public OnGuildScheduledEventStarted OnGuildScheduledEventStarted;
        public OnGuildScheduledEventUpdated OnGuildScheduledEventUpdated;
        public OnGuildScheduledEventUserAdd OnGuildScheduledEventUserAdd;
        public OnGuildScheduledEventUserRemove OnGuildScheduledEventUserRemove;
        public OnGuildStickerCreated OnGuildStickerCreated;
        public OnGuildStickerDeleted OnGuildStickerDeleted;
        public OnGuildStickerUpdated OnGuildStickerUpdated;
        public OnGuildUnavailable OnGuildUnavailable;
        public OnGuildUpdated OnGuildUpdated;
        public OnIntegrationCreated OnIntegrationCreated;
        public OnIntegrationDeleted OnIntegrationDeleted;
        public OnIntegrationUpdated OnIntegrationUpdated;
        public OnInteractionCreated OnInteractionCreated;
        public OnInviteCreated OnInviteCreated;
        public OnInviteDeleted OnInviteDeleted;
        public OnLatencyUpdated OnLatencyUpdated;
        public OnLog OnLog;
        public OnLoggedOut OnLoggedOut;
        public OnMessageCommandExecuted OnMessageCommandExecuted;
        public OnMessageDeleted OnMessageDeleted;
        public OnMessageReceived OnMessageReceived;
        public OnMessagesBulkDeleted OnMessagesBulkDeleted;
        public OnMessageUpdated OnMessageUpdated;
        public OnModalSubmitted OnModalSubmitted;
        public OnPresenceUpdated OnPresenceUpdated;
        public OnReactionAdded OnReactionAdded;
        public OnReactionRemoved OnReactionRemoved;
        public OnReactionsCleared OnReactionsCleared;
        public OnReactionsRemovedForEmote OnReactionsRemovedForEmote;
        public OnReady OnReady;
        public OnRecipientAdded OnRecipientAdded;
        public OnRecipientRemoved OnRecipientRemoved;
        public OnRequestToSpeak OnRequestToSpeak;
        public OnRoleCreated OnRoleCreated;
        public OnRoleDeleted OnRoleDeleted;
        public OnRoleUpdated OnRoleUpdated;
        public OnSelectMenuExecuted OnSelectMenuExecuted;
        public OnSlashCommandExecuted OnSlashCommandExecuted;
        public OnSpeakerAdded OnSpeakerAdded;
        public OnSpeakerRemoved OnSpeakerRemoved;
        public OnStageEnded OnStageEnded;
        public OnStageStarted OnStageStarted;
        public OnStageUpdated OnStageUpdated;
        public OnThreadCreated OnThreadCreated;
        public OnThreadDeleted OnThreadDeleted;
        public OnThreadMemberJoined OnThreadMemberJoined;
        public OnThreadMemberLeft OnThreadMemberLeft;
        public OnThreadUpdated OnThreadUpdated;
        public OnUserBanned OnUserBanned;
        public OnUserCommandExecuted OnUserCommandExecuted;
        public OnUserIsTyping OnUserIsTyping;
        public OnUserJoined OnUserJoined;
        public OnUserLeft OnUserLeft;
        public OnUserUnbanned OnUserUnbanned;
        public OnUserUpdated OnUserUpdated;
        public OnUserVoiceStateUpdated OnUserVoiceStateUpdated;
        public OnVoiceServerUpdated OnVoiceServerUpdated;

        private readonly List<CommandClassicBase> _commandsClassic;
        private readonly Dictionary<string, CommandMessageBase> _commandsMessage;
        private readonly Dictionary<string, CommandSlashBase> _commandsSlash;
        private readonly Dictionary<string, CommandUserBase> _commandsUser;

        /// <summary>
        /// List containing all added and enabled <see cref="CommandClassicBase"/>(s).
        /// </summary>
        public IEnumerable<CommandClassicBase> ClassicCommands =>
            _commandsClassic;

        /// <summary>
        /// Dictionary containing all added and enabled <see cref="CommandMessageBase"/>(s).
        /// </summary>
        public IReadOnlyDictionary<string, CommandMessageBase> MessageCommands =>
            _commandsMessage;

        /// <summary>
        /// Dictionary containing all added and enabled <see cref="CommandSlashBase"/>(s).
        /// </summary>
        public IReadOnlyDictionary<string, CommandSlashBase> SlashCommands =>
            _commandsSlash;

        /// <summary>
        /// Dictionary containing all added and enabled <see cref="CommandUserBase"/>(s).
        /// </summary>
        public IReadOnlyDictionary<string, CommandUserBase> UserCommands =>
            _commandsUser;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="socketClient"></param>
        public EventHandler(DiscordSocketClient client) {
            Client = client;
            Events = new List<OnEventBase>();
            OnApplicationCommandCreated = new OnApplicationCommandCreated(this);
            OnApplicationCommandDeleted = new OnApplicationCommandDeleted(this);
            OnApplicationCommandUpdated = new OnApplicationCommandUpdated(this);
            OnAutocompleteExecuted = new OnAutocompleteExecuted(this);
            OnButtonExecuted = new OnButtonExecuted(this);
            OnChannelCreated = new OnChannelCreated(this);
            OnChannelDestroyed = new OnChannelDestroyed(this);
            OnChannelUpdated = new OnChannelUpdated(this);
            OnConnected = new OnConnected(this);
            OnCurrentUserUpdated = new OnCurrentUserUpdated(this);
            OnDisconnected = new OnDisconnected(this);
            OnGuildAvailable = new OnGuildAvailable(this);
            OnGuildJoin = new OnGuildJoin(this);
            OnGuildJoinRequestDeleted = new OnGuildJoinRequestDeleted(this);
            OnGuildLeft = new OnGuildLeft(this);
            OnGuildMembersDownloaded = new OnGuildMembersDownloaded(this);
            OnGuildMemberUpdated = new OnGuildMemberUpdated(this);
            OnGuildScheduledEventCancelled = new OnGuildScheduledEventCancelled(this);
            OnGuildScheduledEventCompleted = new OnGuildScheduledEventCompleted(this);
            OnGuildScheduledEventCreated = new OnGuildScheduledEventCreated(this);
            OnGuildScheduledEventStarted = new OnGuildScheduledEventStarted(this);
            OnGuildScheduledEventUpdated = new OnGuildScheduledEventUpdated(this);
            OnGuildScheduledEventUserAdd = new OnGuildScheduledEventUserAdd(this);
            OnGuildScheduledEventUserRemove = new OnGuildScheduledEventUserRemove(this);
            OnGuildStickerCreated = new OnGuildStickerCreated(this);
            OnGuildStickerDeleted = new OnGuildStickerDeleted(this);
            OnGuildStickerUpdated = new OnGuildStickerUpdated(this);
            OnGuildUnavailable = new OnGuildUnavailable(this);
            OnGuildUpdated = new OnGuildUpdated(this);
            OnIntegrationCreated = new OnIntegrationCreated(this);
            OnIntegrationDeleted = new OnIntegrationDeleted(this);
            OnIntegrationUpdated = new OnIntegrationUpdated(this);
            OnInteractionCreated = new OnInteractionCreated(this);
            OnInviteCreated = new OnInviteCreated(this);
            OnInviteDeleted = new OnInviteDeleted(this);
            OnLatencyUpdated = new OnLatencyUpdated(this);
            OnLog = new OnLog(this);
            OnLoggedOut = new OnLoggedOut(this);
            OnMessageCommandExecuted = new OnMessageCommandExecuted(this);
            OnMessageDeleted = new OnMessageDeleted(this);
            OnMessageReceived = new OnMessageReceived(this);
            OnMessagesBulkDeleted = new OnMessagesBulkDeleted(this);
            OnMessageUpdated = new OnMessageUpdated(this);
            OnModalSubmitted = new OnModalSubmitted(this);
            OnPresenceUpdated = new OnPresenceUpdated(this);
            OnReactionAdded = new OnReactionAdded(this);
            OnReactionRemoved = new OnReactionRemoved(this);
            OnReactionsCleared = new OnReactionsCleared(this);
            OnReactionsRemovedForEmote = new OnReactionsRemovedForEmote(this);
            OnReady = new OnReady(this);
            OnRecipientAdded = new OnRecipientAdded(this);
            OnRecipientRemoved = new OnRecipientRemoved(this);
            OnRequestToSpeak = new OnRequestToSpeak(this);
            OnRoleCreated = new OnRoleCreated(this);
            OnRoleDeleted = new OnRoleDeleted(this);
            OnRoleUpdated = new OnRoleUpdated(this);
            OnSelectMenuExecuted = new OnSelectMenuExecuted(this);
            OnSlashCommandExecuted = new OnSlashCommandExecuted(this);
            OnSpeakerAdded = new OnSpeakerAdded(this);
            OnSpeakerRemoved = new OnSpeakerRemoved(this);
            OnStageEnded = new OnStageEnded(this);
            OnStageStarted = new OnStageStarted(this);
            OnStageUpdated = new OnStageUpdated(this);
            OnThreadCreated = new OnThreadCreated(this);
            OnThreadDeleted = new OnThreadDeleted(this);
            OnThreadMemberJoined = new OnThreadMemberJoined(this);
            OnThreadMemberLeft = new OnThreadMemberLeft(this);
            OnThreadUpdated = new OnThreadUpdated(this);
            OnUserBanned = new OnUserBanned(this);
            OnUserCommandExecuted = new OnUserCommandExecuted(this);
            OnUserIsTyping = new OnUserIsTyping(this);
            OnUserJoined = new OnUserJoined(this);
            OnUserLeft = new OnUserLeft(this);
            OnUserUnbanned = new OnUserUnbanned(this);
            OnUserUpdated = new OnUserUpdated(this);
            OnUserVoiceStateUpdated = new OnUserVoiceStateUpdated(this);
            OnVoiceServerUpdated = new OnVoiceServerUpdated(this);
            _commandsClassic = new List<CommandClassicBase>();
            _commandsMessage = new Dictionary<string, CommandMessageBase>();
            _commandsSlash = new Dictionary<string, CommandSlashBase>();
            _commandsUser = new Dictionary<string, CommandUserBase>();
        }

        /// <summary>
        /// Enable all possible events.
        /// </summary>
        /// <returns></returns>
        public EventHandler SubscribeAll() {
            foreach (OnEventBase e in Events) e.Subscribe();
            return this;
        }

        /// <summary>
        /// Disable all events.
        /// </summary>
        /// <returns></returns>
        public EventHandler UnsubscribeAll() {
            foreach (OnEventBase e in Events) e.Unsubscribe();
            return this;
        }

        /// <summary>
        /// Add commands to the execution list and dictionaries if they don't exist.
        /// </summary>
        /// <param name="commands">Commands to add.</param>
        /// <returns></returns>
        public EventHandler AddCommands(params CommandBase[] commands) {
            if (commands != null) {
                foreach (CommandBase command in commands) {
                    if (command == null)
                        continue;
                    switch (command) {
                        case CommandClassicBase commandClassic:
                            if (!_commandsClassic.Contains(commandClassic))
                                _commandsClassic.Add(commandClassic);
                            break;
                        case CommandMessageBase commandMessage:
                            _commandsMessage.TryAdd(commandMessage.GetName(), commandMessage);
                            break;
                        case CommandSlashBase commandSlash:
                            _commandsSlash.TryAdd(commandSlash.GetName(), commandSlash);
                            break;
                        case CommandUserBase commandUser:
                            _commandsUser.TryAdd(commandUser.GetName(), commandUser);
                            break;
                    }
                }
            }
            return this;
        }

        /// <summary>
        /// Remove select commands from the execution list and dictionaries.
        /// </summary>
        /// <param name="commands">Commands to remove.</param>
        /// <returns></returns>
        public EventHandler RemoveCommands(params CommandBase[] commands) {
            if (commands != null) {
                foreach (CommandBase command in commands) {
                    if (command == null)
                        continue;
                    switch (command) {
                        case CommandClassicBase commandClassic:
                            _commandsClassic.Remove(commandClassic);
                            break;
                        case CommandMessageBase commandMessage:
                            _commandsMessage.Remove(commandMessage.GetName());
                            break;
                        case CommandSlashBase commandSlash:
                            _commandsSlash.Remove(commandSlash.GetName());
                            break;
                        case CommandUserBase commandUser:
                            _commandsUser.Remove(commandUser.GetName());
                            break;
                    }
                }
            }
            return this;
        }

        /// <summary>
        /// Clear all commands from the execution list and dictionaries.
        /// </summary>
        /// <returns></returns>
        public EventHandler RemoveAllCommands() {
            _commandsClassic.Clear();
            _commandsMessage.Clear();
            _commandsSlash.Clear();
            _commandsUser.Clear();
            return this;
        }

    }
}