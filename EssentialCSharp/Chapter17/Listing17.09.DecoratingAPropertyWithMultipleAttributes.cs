namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_08
{
    using System;

    class CommandLineInfo
    {
        [CommandLineSwitchAlias("?")]
        public bool Help { get; set; }

        //Two Ways to do it
        //[CommandLineSwitchRequired]
        //[CommandLineSwitchAlias("FileName")]
        [CommandLineSwitchRequired,
        CommandLineSwitchAlias("FileName")]
        public string Out { get; set; }

        public System.Diagnostics.ProcessPriorityClass Priority
            { get; set; } = 
                System.Diagnostics.ProcessPriorityClass.Normal;
    }

    internal class CommandLineSwitchRequiredAttribute : Attribute
    {
        //not implimented
    }

    internal class CommandLineSwitchAliasAttribute : Attribute
    {
        public CommandLineSwitchAliasAttribute(string s)
        {
            //not implimented
        }
    }

}
