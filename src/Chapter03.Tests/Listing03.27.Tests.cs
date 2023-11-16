using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_27.Tests;

[TestClass]
public class ProgrammingLanguagesTests
{
    [TestMethod]
    public void Main_AssertConsoleOutput_MatchesExpected()
    {
        var expected =
        """
        The wave of the future, COBOL, is at index 2.
        
        First Element       	Last Element        
        -------------       	------------        
        C#                  	TypeScript          
        TypeScript          	C#                  
                            	                    
        After clearing, the array size is: 9
        """;

        ConsoleAssert.Expect(
            expected, ProgrammingLanguages.Main);
    }
}
