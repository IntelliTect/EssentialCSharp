
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_29;

#region INCLUDE
using System.Drawing;

public static class PointHelper
{
    public static void Deconstruct(
        this Point point, out int x, out int y) =>
            (x, y) = (point.X, point.Y);

    public static bool IsVisibleOnVGAScreen(Point point) =>
        point is (>=0 and <=1920, >=0 and <=1080);

    public static string GetQuadrant(Point point) => point switch
    {
        (>=0, >=0) => "Quadrant I",   //  II | I
        (<=0, >=0) => "Quadrant II",  // ____|____
        (<=0, <=0) => "Quadrant III", //     |
        (>=0, <=0) => "Quadrant IV"   // III | IV
    };
}
#endregion INCLUDE
