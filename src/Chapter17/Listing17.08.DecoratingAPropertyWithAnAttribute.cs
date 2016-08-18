namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_07
{
    using System;

    class CommandLineInfo
    {
        [CommandLineSwitchAlias("?")]
        public bool Help { get; set; }

        [CommandLineSwitchRequired]
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