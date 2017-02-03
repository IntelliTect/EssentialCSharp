namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_13
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
