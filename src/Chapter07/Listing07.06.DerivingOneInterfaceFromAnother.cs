namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_06
{
    interface IReadableSettingsProvider
    {
        string GetSetting(string name, string defaultValue);
    }

    interface ISettingsProvider : IReadableSettingsProvider
    {
        void SetSetting(string name, string value);
    }

    class FileSettingsProvider : ISettingsProvider
    {
        #region ISettingsProvider Members
        public void SetSetting(string name, string value)
        {
            // ...
        }
        #endregion

        #region IReadableSettingsProvider Members
        public string GetSetting(string name, string defaultValue)
        {
            return name + defaultValue; // just returning this for the example
        }
        #endregion
    }

}
