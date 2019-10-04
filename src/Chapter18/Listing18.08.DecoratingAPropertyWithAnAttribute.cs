namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_08
{
    using System;

#pragma warning disable CA1019 // 

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
        //not implemented
    }

    internal class CommandLineSwitchAliasAttribute : Attribute
    {
        public CommandLineSwitchAliasAttribute(string s)
        {
            //not implemented
        }
    }
}