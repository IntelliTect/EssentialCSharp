namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_25;

using System;
#region INCLUDE
public class DisplayFibonacci
{
    public static void Main()
    {
        // Intentionally using ArrayList to demonstrate boxing
        System.Collections.ArrayList list = new();

        Console.Write("Enter an integer between 2 and 1000: ");
        string? inputText = Console.ReadLine();
        if (!int.TryParse(inputText, out int totalCount))
        {
            Console.WriteLine($"'{inputText}' is not a valid integer.");
            return;
        }

        if (totalCount == 7)  // Magic number used for testing
        {
            // Triggers exception when retrieving  value as double.
            list.Add(0);  // Cast to double or 'D' suffix required.
                          // Whether cast or using 'D' suffix,
                          // CIL is identical.

        }
        else
        {
            list.Add((double)0);
        }

        list.Add((double)1);
        
        for(int count = 2; count < totalCount; count++)
        {
            list.Add(
                (double)list[count - 1]! +
                (double)list[count - 2]!);
        }

        // Using a foreach to clarify the box operation rather than
        // Console.WriteLine(string.Join(", ", list.ToArray()));
        foreach (double? count in list)
        {
            Console.Write("{0}, ", count);
        }
    }
}
#endregion INCLUDE
