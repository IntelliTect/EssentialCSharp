using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_09.Tests
{
    [TestClass]
    public class MiracleMaxTests
    {
        [TestMethod]
        public void Main_StormCastleShort()
        {
            string view = @"Have fun storming the castle!";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                MiracleMax.Main();
            });
        }
    }
}