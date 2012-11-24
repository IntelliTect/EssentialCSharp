namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_28
{
    public class Program
    {
        public static void Main()
        {
            int input = 5;

            if(input < 9)
            {
                // Input is less than 9.
                System.Console.WriteLine(
                    "Tic-tac-toe has more than {0}" +
                     " maximum turns.", input);
            }
        }
    }
}
