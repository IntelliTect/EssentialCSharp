using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_28
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
C#                  	TypeScript          
TypeScript          	C#                  
                    	                    
After clearing, the array size is: 9";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ProgrammingLanguages.Main);
        }
    }
}
