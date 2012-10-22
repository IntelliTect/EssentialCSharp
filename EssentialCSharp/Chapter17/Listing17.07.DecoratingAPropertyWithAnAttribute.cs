namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_07
{
    using System;

    class CommandLineInfo
    {
        [CommandLineSwitchAlias("?")]
        public bool Help
        {
            get { return _Help; }
            set { _Help = value; }
        }
        private bool _Help;

        [CommandLineSwitchRequired]
        public string Out
        {
            get { return _Out; }
            set { _Out = value; }
        }
        private string _Out;

        public System.Diagnostics.ProcessPriorityClass Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }
        private System.Diagnostics.ProcessPriorityClass _Priority =
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