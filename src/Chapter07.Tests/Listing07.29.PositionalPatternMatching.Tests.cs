using System.Drawing;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_29.Tests;

[TestClass]
public class ProgramTests
{
    const bool IsVgaVisible = true;
    const bool NotVgaVisible = false;
    [TestMethod]
    [DataRow(IsVgaVisible, 1920, 1080)]
    [DataRow(IsVgaVisible, 0, 0)]
    [DataRow(IsVgaVisible, 1024, 768)]
    [DataRow(NotVgaVisible, 0, 1440)]
    public void Main_EncryptFile_Success(bool isVgaVisible, int x, int y)
    {
        Assert.AreEqual(isVgaVisible, (PointHelper.IsVisibleOnVGAScreen(new Point(x, y))));
    }


    [TestMethod]
    [DataRow(1,1, "I")]
    [DataRow(0, 0, "I")]
    [DataRow(-1, 1, "II")]
    [DataRow(-1, 0, "II")]
    [DataRow(-1, -1, "III")]
    [DataRow(1, -1, "IV")]
    [DataRow(0, -1, "III")]
    public void GetQuadrant(int x, int y, string quadrant)
    {
        Assert.AreEqual<string>($"Quadrant { quadrant }", PointHelper.GetQuadrant(new Point(x,y)),
            $"({ x}, {y}) is not in the expected {quadrant}.");
    }
}
