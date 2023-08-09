using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15;

public class Program
{
    public static void Main()
    {
        // The constructor is generated using positional parameters
        Angle angle = new(90, 0, 0, null);

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
