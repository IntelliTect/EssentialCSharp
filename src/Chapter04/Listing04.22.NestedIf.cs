// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22;

public class TicTacToeTrivia
{
    public static void Main()
    {
        #region INCLUDE
        int input;    // Declare a variable to store the input

        Console.Write(
            "What is the maximum number " +
            "of turns in tic-tac-toe?" +
            " (Enter 0 to exit.): ");

        // int.Parse() converts the ReadLine()
        // return to an int data type
        input = int.Parse(Console.ReadLine());

        // Condition 1.
        if (input <= 0) // line 16
            // Input is less than or equal to 0
            Console.WriteLine("Exiting...");
        else
            // Condition 2.
            if (input < 9) // line 20
                // Input is less than 9
                Console.WriteLine(
                    $"Tic-tac-toe has more than {input}" +
                    " maximum turns.");
            else
                // Condition 3.
                if (input > 9) // line 26
                    // Input is greater than 9
                    Console.WriteLine(
                        $"Tic-tac-toe has fewer than {input}" +
                        " maximum turns.");
                // Condition 4.
                else
                    // Input equals 9
                    Console.WriteLine(  // line 33
                        "Correct, tic-tac-toe " +
                        "has a maximum of 9 turns.");
        #endregion INCLUDE
   } 
}
