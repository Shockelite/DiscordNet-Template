namespace Discord {

    /// <summary>
    /// Determines where the command can be triggered from.
    /// </summary>
    public enum CommandContextType {
        /// <summary>
        /// Default value, not allowed anywhere.
        /// </summary>
        None = 0,
        /// <summary>
        /// Command available in servers/guilds.
        /// </summary>
        Guild = 1 << 0,
        /// <summary>
        /// Command available in private group channels.
        /// </summary>
        Private = 1 << 1,
        /// <summary>
        /// Command available in DM channels.
        /// </summary>
        DM = 1 << 2
    }

}