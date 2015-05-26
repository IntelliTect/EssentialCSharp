using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = $@"
Keywords:
 abstract as base bool break byte case catch char checked class const continue decimal default delegate do double else enum event explicit extern false finally fixed float for foreach goto if implicit in int interface internal is lock long namespace new null operator out override object params private protected public readonly ref return sbyte sealed short sizeof stackalloc static string struct switch this throw true try typeof uint ulong unsafe ushort using virtual unchecked void volatile while
Contextual Keywords:
 add alias ascending async await by descending dynamic equals from get global group into join let nameof on orderby partial remove select set value var where yield";

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}