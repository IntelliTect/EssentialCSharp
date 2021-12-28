#pragma warning disable CA1806 // Calls ToUpper but does not use the new string instance that the method returns.
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17
{
    public class Uppercase
    {
        public static void Main()
        {
            string text;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper();

            System.Console.WriteLine(text);
        }
    }
}
#pragma warning restore CA1806