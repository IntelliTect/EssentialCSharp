namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_26;
public class DisplayFibonacci
{
    static void Main()
    {
        #region INCLUDE
        // ...

        int number;
        object thing;
        double bigNumber;

        number = 42;
        thing = number;
        // ERROR: InvalidCastException
        // bigNumber = (double)thing;
        bigNumber = (double)(int)thing;
        // ...
        #endregion INCLUDE
    }
}
