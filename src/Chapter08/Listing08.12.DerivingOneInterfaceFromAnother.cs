namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_12
{
    using Listing08_09;

    interface IDistributedSettingsProvider : ISettingsProvider
    {
        /// <summary>
        /// Get the settings for a particular machine
        /// </summary>
        /// <param name="machineName">
        /// The machine name the setting is related to</param>
        /// <param name="name">The name of the setting</param>
        /// <param name="defaultValue">
        /// The value returned if the setting is not found</param>
        /// <returns>The specified setting</returns>
        string GetSetting(
            string machineName, string name, string defaultValue);

        /// <summary>
        /// Set the settings for a particular machine
        /// </summary>
        /// <param name="machineName">
        /// The machine name the setting is related to</param>
        /// <param name="name">The name of the setting</param>
        /// <param name="value">The value to be persisted</param>
        /// <returns>The specified setting</returns>
        void SetSetting(
            string machineName, string name, string value);
    }
}
