namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17
{
    public class Uppercase
    {
        public static void Main()
        {
            System.Console.Write("Enter text: ");
            var text = System.Console.ReadLine();

            // Return a new string in uppercase
            var uppercase = text.ToUpper();

            System.Console.WriteLine(uppercase);
        }
    }
}
