using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_11.Tests
{
    [TestClass]
    public class MiracleMaxTests
    {
        [TestMethod]
        public void Main_StormCastleLong()
        {
            string view =
@"Have fun storming the castle!
Think it will work?
It would take a miracle.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                MiracleMax.Main();
            });
        }
    }
}