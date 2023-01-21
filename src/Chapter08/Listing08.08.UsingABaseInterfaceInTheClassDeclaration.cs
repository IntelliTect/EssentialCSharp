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
    #region ISettingsProvider Members
    public void SetSetting(string name, string value)
    {
        // ...
    }
    #endregion

    #region IReadableSettingsProvider Members
    public string GetSetting(string name, string defaultValue)
    {
        #region EXCLUDE
        return name + defaultValue; //just returning this for the example
        #endregion EXCLUDE
    }
    #endregion
}
#endregion INCLUDE
