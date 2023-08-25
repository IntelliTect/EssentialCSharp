namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_21;

#region INCLUDE
// Restrict the attribute to properties and methods
#region HIGHLIGHT
[AttributeUsage(
  AttributeTargets.Field | AttributeTargets.Property)]
#endregion HIGHLIGHT
public class CommandLineSwitchAliasAttribute : Attribute
{
    // ...
}
#endregion INCLUDE
