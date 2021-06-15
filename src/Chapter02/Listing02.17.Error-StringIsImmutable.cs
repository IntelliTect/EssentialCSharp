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
