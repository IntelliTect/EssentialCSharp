namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_09;

#region INCLUDE
interface IReadableSettingsProvider
{
    string GetSetting(string name, string defaultValue);
}

interface IWriteableSettingsProvider
{
    void SetSetting(string name, string value);
}

interface ISettingsProvider : IReadableSettingsProvider,
#region HIGHLIGHT
    IWriteableSettingsProvider
#endregion HIGHLIGHT
{
}
#endregion INCLUDE
