namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_25;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        int? age;
        //...

        // Clear the value of age
        age = null;

        #region EXCLUDE
        Console.WriteLine($"The age is: {age}");
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}
