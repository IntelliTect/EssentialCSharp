#region INCLUDE
// The global using directive imports all types from
// the specified namespace into the project
global using System.Text;
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_10;
#endregion EXCLUDE
public class Program
{
    public static void Main()
    {
        // See Chapter 6 for explanation of new();
        StringBuilder name = new();

        Console.WriteLine("Enter your first name: ");
        name.Append(Console.ReadLine()!.Trim());

        Console.WriteLine("Enter your middle initial: ");
        name.Append( $" { Console.ReadLine()!.Trim('.').Trim() }." );

        Console.WriteLine("Enter your last name: ");
        name.Append($" { Console.ReadLine()!.Trim() }");

        Console.WriteLine($"Hello {name}!");
    }
}
#endregion INCLUDE
