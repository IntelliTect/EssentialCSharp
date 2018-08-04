namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_18
{
    public class Uppercase
    {
        public static void Main()
        {
            string text, uppercase;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            // Return a new string in uppercase
            uppercase = text.ToUpper();

            System.Console.WriteLine(uppercase);
        }
    }
}
