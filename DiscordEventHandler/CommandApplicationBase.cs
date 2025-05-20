namespace Discord {

    /// <summary>
    /// Base for all types of commands.
    /// </summary>
    public abstract class CommandApplicationBase : CommandBase {

        /// <summary>
        /// Indicates whether this command is available globally, without server-specific customization.
        /// </summary>
        public bool IsGlobal { get; protected set; }

        /// <summary>
        /// Base constructor.
        /// </summary>
        public CommandApplicationBase(bool isGlobal = true, CommandContextType contextType = CommandContextType.None) : base(contextType) {
            this.IsGlobal = isGlobal;
            if (!this.IsGlobal && contextType.HasFlag(CommandContextType.Private)) {
                LogWarning(this.GetName() + " constructed with an invalid CommandContextType. Only global commands are visible in private channels.");
            }
            if (!this.IsGlobal && contextType.HasFlag(CommandContextType.DM)) {
                LogWarning(this.GetName() + " constructed with an invalid CommandContextType. Only global commands are visible in DM channels.");
            }
        }

    }

}