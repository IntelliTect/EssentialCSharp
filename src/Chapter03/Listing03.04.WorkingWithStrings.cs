namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_04
{
    #region INCLUDE
    public class Uppercase
    {
        public static void Main()
        {
            Console.Write("Enter text: ");
            var text = Console.ReadLine();

            // Return a new string in uppercase
            var uppercase = text.ToUpper();

            Console.WriteLine(uppercase);
        }
    }
    #endregion INCLUDE
}
