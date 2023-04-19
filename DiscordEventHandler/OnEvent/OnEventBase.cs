namespace Discord.OnEvent {

    /// <summary>
    /// Base class for events.
    /// </summary>
    public abstract class OnEventBase : ConsoleLoggingBase {

        /// <summary>
        /// Root <see cref="EventHandler"/> object.
        /// </summary>
        internal readonly EventHandler EventHandler;

        /// <summary>
        /// Base event for all events. Should be called when event is first initialized.
        /// </summary>
        /// <param name="eventHandler"></param>
        protected OnEventBase(EventHandler eventHandler) {
            EventHandler = eventHandler;
            eventHandler.Events.Add(this);
            Log("Created.");
        }

        /// <summary>
        /// Enable this event.
        /// </summary>
        public abstract void Subscribe();

        /// <summary>
        /// Disable this event.
        /// </summary>
        public abstract void Unsubscribe();

    }
}