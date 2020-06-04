namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_11
{
    using Listing08_09;

    interface IDistributedSettingsProvider : ISettingsProvider
    {
        /// <summary>
        /// Get the settings for a particular URI
        /// </summary>
        /// <param name="uri">
        /// The URI name the setting is related to</param>
        /// <param name="name">The name of the setting</param>
        /// <param name="defaultValue">
        /// The value returned if the setting is not found</param>
        /// <returns>The specified setting</returns>
        string GetSetting(
            string uri, string name, string defaultValue);

        /// <summary>
        /// Set the settings for a particular URI
        /// </summary>
        /// <param name="uri">
        /// The URI name the setting is related to</param>
        /// <param name="name">The name of the setting</param>
        /// <param name="value">The value to be persisted</param>
        /// <returns>The specified setting</returns>
        void SetSetting(
            string uri, string name, string value);
    }
}
