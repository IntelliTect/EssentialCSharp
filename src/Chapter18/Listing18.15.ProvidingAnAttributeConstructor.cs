namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15
{
    using System;

    public class CommandLineSwitchAliasAttribute : Attribute
    {
        public CommandLineSwitchAliasAttribute(string alias)
        {
            Alias = alias;
        }
        public string Alias { get; private set; }
    }
    class CommandLineInfo
    {
        [CommandLineSwitchAlias("?")]
        public bool Help { get; set; }

        // ...
    }
}
