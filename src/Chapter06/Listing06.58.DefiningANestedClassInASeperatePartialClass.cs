// Ignored as implementation was removed for elucidation
#pragma warning disable IDE0060 //Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_58;

using System;

#region INCLUDE
// File: Program.cs
partial class Program
{
    static void Main(string[] args)
    {
        CommandLine commandLine = new(args);

        switch(commandLine.Action)
        {
            #region EXCLUDE
            default:
                break;
            #endregion EXCLUDE
        }
    }
}

// File: Program+CommandLine.cs
partial class Program
{
    // Define a nested class for processing the command line
    private class CommandLine
    {
        #region EXCLUDE
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
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
