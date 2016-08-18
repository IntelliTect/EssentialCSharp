namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_13
{
    using System;

    public class CommandLineSwitchAliasAttribute : Attribute
    {
        public CommandLineSwitchAliasAttribute(string alias)
        {
            Alias = alias;
        }
        public string Alias
        {
            get { return _Alias; }
            set { _Alias = value; }
        }
        private string _Alias;
    }
    class CommandLineInfo
    {
        [CommandLineSwitchAlias("?")]
        public bool Help
        {
            get { return _Help; }
            set { _Help = value; }
        }
        private bool _Help;

        // ...
    }
}
