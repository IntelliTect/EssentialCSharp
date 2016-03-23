using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_50.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ProgrammingLanguages()
        {
            const string expected = @"The wave of the future, COBOL, is at index 2.

First Element       	Last Element        
-------------       	------------        
C#                  	Visual Basic        
Visual Basic        	C#                  
                    	                    
After clearing, the array size is: 9";

            IntelliTect.ConsoleView.Tester.Test(
                expected, ProgrammingLanguages.Main);
        }
    }
}