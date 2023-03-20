namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_15;

using System;
public class Program
{
    public static void Main()
    {
        #region INCLUDE
        //...
        Func<string> getUserInput =
        #region HIGHLIGHT
            () =>
            #endregion HIGHLIGHT
            {
                string? input;
                do
                {
                    input = Console.ReadLine();
                }
                while(!string.IsNullOrWhiteSpace(input));
                return input!;
            };
        //...
        #endregion INCLUDE
        getUserInput();
    }
}