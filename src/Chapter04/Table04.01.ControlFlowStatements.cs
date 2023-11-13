namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_01;

public class ControlFlowStatements
{
    public static void IfStatement(string input)
    {
        if (input == "quit")
        {
            Console.WriteLine("Game end");
        }
        return;
    }

    public static void IfElseStatement(string input)
    {
        if (input == "quit")
        {
            Console.WriteLine("Game end");
            return;
        }
        else
        GetNextMove();
    }

    public static void WhileStatement(int count, int total)
    {
        while (count < total)
        {
            Console.WriteLine($"count = {count}");
            count++;
        }
    }

    public static void DoWhileStatement()
    {
        string? input;
        do
        {
            Console.WriteLine("Enter name:");
            input = Console.ReadLine();

        } while (input != "exit");
    }

    public static void ForStatement(int count)
    {
        for (; count <= 10; count++)
        {
            Console.WriteLine($"count = {count})");
        }
    }

    public static void SwitchStatement(string input)
    {
        switch (input)
        {
            case "exit":
            case "quit":
                Console.WriteLine("Exiting app....");
                break;
            case "restart":
                Reset();
                goto case "start";
            case "start":
                GetNextMove();
                break;
            default:
                Console.WriteLine(input);
                break;
        }
    }

    private static void Reset()
    {
        Console.WriteLine("Resetting app....");
    }

    private static void GetNextMove()
    {
        Console.WriteLine("Next move obtained.");
    }
}
