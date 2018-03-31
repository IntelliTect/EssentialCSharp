namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_06
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Program p;

            p = new Program();
            p.Sketch();
        }

        public void Sketch()
        {
            Stack<Cell> path = new Stack<Cell>();
            Cell currentPosition;
            ConsoleKeyInfo key;  // Added in C# 2.0

            Console.WriteLine("Use arrow keys to draw. X to exit.");
            for(int i = 2; i < Console.WindowHeight; i++)
            {
                Console.WriteLine();
            }

            currentPosition = new Cell(Console.WindowWidth / 2, Console.WindowHeight / 2);
            path.Push(currentPosition);
            FillCell(currentPosition);

            do
            {
                // Etch in the direction indicated by the
                // arrow keys that the user enters
                key = Move();

                switch(key.Key)
                {
                    case ConsoleKey.Z:
                        // Undo the previous Move
                        if(path.Count >= 1)
                        {
                            // No cast required
                            currentPosition = path.Pop();
                            Console.SetCursorPosition(
                                currentPosition.X, currentPosition.Y);
                            FillCell(currentPosition, ConsoleColor.Black);
                            Undo();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if(Console.CursorTop < Console.WindowHeight - 2)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft, Console.CursorTop + 1);
                        }
                        // Only type Cell allowed in call to Push()
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;
                    case ConsoleKey.UpArrow:
                        if(Console.CursorTop > 1)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft, Console.CursorTop - 1);
                        }
                        // Only type Cell allowed in call to Push()
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;
                    case ConsoleKey.LeftArrow:
                        if(Console.CursorLeft > 1)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft - 1, Console.CursorTop);
                        }
                        // Only type Cell allowed in call to Push()
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;
                    case ConsoleKey.RightArrow:
                        // SaveState()
                        if(Console.CursorLeft < Console.WindowWidth - 2)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft + 1, Console.CursorTop);
                        }
                        // Only type Cell allowed in call to Push()
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;

                    default:
                        Console.Beep();  // Added in C# 2.0
                        break;
                }

            }
            while(key.Key != ConsoleKey.X);  // Use X to quit
        }

        private static ConsoleKeyInfo Move()
        {
            return Console.ReadKey(true);
        }

        private static void Undo()
        {
            // stub
        }

        private static void FillCell(Cell cell)
        {
            FillCell(cell, ConsoleColor.White);
        }

        private static void FillCell(Cell cell, ConsoleColor color)
        {
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.BackgroundColor = color;
            Console.Write(' ');
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.BackgroundColor = ConsoleColor.Black;
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
