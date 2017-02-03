namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_09
{
    interface IReadableSettingsProvider
    {
        string GetSetting(string name, string defaultValue);
    }

    interface IWriteableSettingsProvider
    {
        void SetSetting(string name, string value);
    }

    interface ISettingsProvider : IReadableSettingsProvider,
        IWriteableSettingsProvider
    {
    }
}
