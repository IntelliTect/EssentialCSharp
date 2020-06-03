// Ignored as implementation was removed for elucidation
#pragma warning disable IDE0060 //Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_52
{
    using System;


    // File: Program.cs
    partial class Program
    {
        static void Main(string[] args)
        {
            CommandLine commandLine = new CommandLine(args);

            #pragma warning disable CS1522 // Empty switch block
            switch(commandLine.Action)
            {
                // ...
            }
            #pragma warning restore CS1522 // Empty switch block
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
}
