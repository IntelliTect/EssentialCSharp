namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_19
{
    using System;

    // Restrict the attribute to properties and methods
    [AttributeUsage(
      AttributeTargets.Field | AttributeTargets.Property)]
    public class CommandLineSwitchAliasAttribute : Attribute
    {
        // ...
    }
}