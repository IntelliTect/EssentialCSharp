namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_08;

interface IReadableSettingsProvider
{
    string GetSetting(string name, string defaultValue);
}

interface ISettingsProvider : IReadableSettingsProvider
{
    void SetSetting(string name, string value);
}

#region INCLUDE
public class FileSettingsProvider : ISettingsProvider,
#region HIGHLIGHT
    IReadableSettingsProvider
#endregion HIGHLIGHT
{
    #region ISettingsProvider成员
    public void SetSetting(string name, string value)
    {
        // ...
    }
    #endregion

    #region IReadableSettingsProvider成员
    public string GetSetting(string name, string defaultValue)
    {
        #region EXCLUDE
        return name + defaultValue; // 随便返回的，仅供演示
        #endregion EXCLUDE
    }
    #endregion
}
#endregion INCLUDE
