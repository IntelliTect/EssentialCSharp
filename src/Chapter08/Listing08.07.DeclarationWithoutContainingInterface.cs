namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_07
{
    interface IReadableSettingsProvider
    {
        string GetSetting(string name, string defaultValue);
    }

    interface ISettingsProvider : IReadableSettingsProvider
    {
        // ERROR:  GetSetting() not available on ISettingsProvider

        //string ISettingsProvider.GetSetting(
        //    string name, string defaultValue)
        //{
        //    ...
        //}

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
