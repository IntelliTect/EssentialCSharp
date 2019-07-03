namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_48
{
// We dont fully implement our switch block here
#pragma warning disable CS1522
    using System;

    // File: Program.cs
    partial class Program
    {
        static void Main(string[] args)
        {
            CommandLine commandLine = new CommandLine(args);

            switch(commandLine.Action)
            {
                // ...
            }
        }
    }

    // File: Program+CommandLine.cs
    partial class Program
    {
        // Define a nested class for processing the command line
        private class CommandLine
        {
            public CommandLine(string[] args)
            {
                //not implemented
            }

            // ...
            public int Action
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
        }
    }
#pragma warning restore CS1522
}
