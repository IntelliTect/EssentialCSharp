namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            int input = int.Parse(args[0]);

            if(input < 0)
                System.Console.WriteLine("Exiting...");
            else if(input < 9)
                System.Console.WriteLine(
                    $"Tic-tac-toe has more than {input}" +
                    " maximum turns.");
            else if (input > 9)
                System.Console.WriteLine(
                    $"Tic-tac-toe has less than {input}" +
                    " maximum turns.");

            else
                System.Console.WriteLine(
                    "Correct, tic-tac-toe has a maximum" +
                    " of 9 turns.");
        }
    }
}
