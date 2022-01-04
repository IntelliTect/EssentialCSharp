using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Table08_01.Tests
{
    // 1.
    namespace StaticMembers { }

    // 2.
    namespace ImplementedPropertiesAndMethods.Tests
    {
        using AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Table08_01.ImplementedPropertiesAndMethods;

        [TestClass]
        public class ProgramTests
        {
            [TestMethod]
            public void Main()
            {
                IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    "Inigo Montoya\nMark Michaelis\nMichaelis, Mark",
                    Program.Main);
            }
        }
    }

    // 3.
    namespace PublicAccessModifiers { }

    // 4.
    namespace ProtectedAccessModifiers { }

    // 5. 
    namespace ProvateAccessModifiers { }

    // 6. 
    namespace InternalAccessModifiers { }

    // 7. 
    namespace ProtectedInternalAccessModifiers { }

    // 8. 
    namespace VirtualMembers { }

    // 9.
    namespace SealedMembers { }

    // 10. 
    namespace AbstractMembers { }

    // 11. 
    namespace PartialMembers { }

}
