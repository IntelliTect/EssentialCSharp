using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_10.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = $@"{Environment.NewLine}Keywords:{Environment.NewLine} abstract as base bool break byte case catch char checked class const continue decimal default delegate do double else enum event explicit extern false finally fixed float for foreach goto if implicit in int interface internal is lock long namespace new null operator out override object params private protected public readonly ref return sbyte sealed short sizeof stackalloc static string struct switch this throw true try typeof uint ulong unsafe ushort using virtual unchecked void volatile while{Environment.NewLine}Contextual Keywords:{Environment.NewLine} add alias ascending async await by descending dynamic equals from get global group into join let nameof on orderby partial remove select set value var where yield";


            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}