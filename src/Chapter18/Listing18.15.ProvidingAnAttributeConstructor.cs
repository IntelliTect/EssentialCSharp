namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15;

#region INCLUDE
public class CommandLineSwitchAliasAttribute : Attribute
{
    #region HIGHLIGHT
    public CommandLineSwitchAliasAttribute(string alias)
    {
        Alias = alias;
    }
    #endregion HIGHLIGHT
    public string Alias { get; }
}
public class CommandLineInfo
{
    #region HIGHLIGHT
    [CommandLineSwitchAlias("?")]
    #endregion HIGHLIGHT
    public bool Help { get; set; }

    // ...
}
#endregion INCLUDE
