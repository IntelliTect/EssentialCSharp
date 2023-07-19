namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

public class Program
{
    public static void Main()
    {
        (int degrees, int minutes, int seconds, string name) = (
            90, 0, 0, null);

        // The constructor is generated using positional parameters
        Angle angle = new(degrees, minutes, seconds, name);

        // Records have a deconstructor using the 
        // positional parameters.
        #region INCLUDE
        if (angle is (int, int, int, string) angleData)
        {
            // ...
        }
        #endregion INCLUDE
    }
}
