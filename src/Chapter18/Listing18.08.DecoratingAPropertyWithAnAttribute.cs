namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_08
{
    using System;

    class CommandLineInfo
    {
        [CommandLineSwitchAlias("?")]
        public bool Help { get; set; }

        [CommandLineSwitchRequired]
        public string? Out { get; set; }

        public System.Diagnostics.ProcessPriorityClass Priority
        { get; set; } = 
            System.Diagnostics.ProcessPriorityClass.Normal;


    }
    // Disabling warning since it is not implemented or shown in manuscript
    #pragma warning disable CA1018 // Mark attributes with AttributeUsageAttribute
    internal class CommandLineSwitchRequiredAttribute : Attribute
    {
        //not implemented
    }

    internal class CommandLineSwitchAliasAttribute : Attribute
    {
        public CommandLineSwitchAliasAttribute(string _)
        {
            //not implemented
        }
    }
}