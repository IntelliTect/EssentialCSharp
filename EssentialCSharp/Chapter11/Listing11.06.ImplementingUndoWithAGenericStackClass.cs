namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_06
{
    using System;
    using System.Collections.Generic;
    using Listing11_02;

    class Program
    {
        // ...

        public void Sketch()
        {
            Stack<Cell> path;          // Generic variable declaration
            path = new Stack<Cell>();  // Generic object instantiation
            Cell currentPosition;
            ConsoleKeyInfo key;

            do
            {
                // Etch in the direction indicated by the
                // arrow keys entered by the user.
                key = Move();

                switch (key.Key)
                {
                    case ConsoleKey.Z:
                        // Undo the previous Move.
                        if (path.Count >= 1)
                        {
                            // No cast required.
                            currentPosition = path.Pop();
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
                        // Only type Cell allowed in call to Push().
                        path.Push(currentPosition);
                        break;

                    default:
                        Console.Beep();
                        break;
                }

            } while (key.Key != ConsoleKey.X);  // Use X to quit.
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
}