namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_29;
#pragma warning disable CS0168 // Variable is declared but never used

#region INCLUDE
// A previous catch clause already catches all exceptions
#pragma warning disable CS1058
#region EXCLUDE
using System;

public class ExceptionHandling
{
    public static int Main()
    {
        string? firstName;
        string ageText;
        int age;
        int result = 0;

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter your age: ");
        // Assume not null for clarity
        ageText = Console.ReadLine()!;

        #endregion EXCLUDE
        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"Hi { firstName }! You are { age * 12 } months old.");
        }
        catch(FormatException exception)
        {
            Console.WriteLine(
                $"The age entered ,{ageText}, is not valid.");
            result = 1;
        }
        catch(Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error: { exception.Message }");
            result = 1;
        }
        catch
        {
            Console.WriteLine("Unexpected error!");
            result = 1;
        }
        finally
        {
            Console.WriteLine($"Goodbye { firstName }");
        }
        #endregion INCLUDE
        return result;
    }
}
