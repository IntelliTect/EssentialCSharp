namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_02
{
    using System;
    using System.Collections;

    class Program
    {
        // ...

        public void Sketch()
        {
            Stack path = new Stack();
            Cell currentPosition;
            ConsoleKeyInfo key;  // Added in C# 2.0

            do
            {
                // Etch in the direction indicated by the
                // arrow keys that the user enters.
                key = Move();

                switch (key.Key)
                {
                    case ConsoleKey.Z:
                        // Undo the previous Move.
                        if (path.Count >= 1)
                        {
                            currentPosition = (Cell)path.Pop();
                            Console.SetCursorPosition(
                                currentPosition.X, currentPosition.Y);
                            Undo();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                        // SaveState()
                        currentPosition = new Cell(
                            Console.CursorLeft, Console.CursorTop);
                        path.Push(currentPosition);
                        break;

                    default:
                        Console.Beep();  // Added in C# 2.0
                        break;
                }

            }
            while (key.Key != ConsoleKey.X);  // Use X to quit.

        }
        private static ConsoleKeyInfo Move()
        {
            // stub
            return new ConsoleKeyInfo();
        }

        private static void Undo()
        {
            // stub
        }
    }

    public struct Cell
    {
        readonly public int X;
        readonly public int Y;
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}