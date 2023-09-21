namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_55;

using System;

class CommonGuid
{
    public static readonly Guid ComIUnknownGuid =
        new("00000000-0000-0000-C000-000000000046");
    public static readonly Guid ComIClassFactoryGuid =
        new("00000001-0000-0000-C000-000000000046");
    public static readonly Guid ComIDispatchGuid =
        new("00020400-0000-0000-C000-000000000046");
    public static readonly Guid ComITypeInfoGuid =
        new("00020401-0000-0000-C000-000000000046");
    // ...
}

public class Program
{
    public static void Main()
    {
        // Note: board.Cells does not require initialization
        TicTacToeBoard board = new();
        Console.WriteLine(board.Cells);
    }
}

#region INCLUDE
class TicTacToeBoard
{
    // Set both player's initial board to all false (blank)
    //    |   |          |   |
    // ---+---+---    ---+---+---
    //    |   |          |   |   
    // ---+---+---    ---+---+---
    //    |   |          |   |   
    // Player 1 - X   Player 2 - O
    #region HIGHLIGHT
    public bool[,,] Cells { get; } = new bool[2, 3, 3];
    #endregion HIGHLIGHT
    // Error: The property Cells cannot 
    // be assigned to because it is read-only
    // public void SetCells(bool[,,] value) =>
    //         _Cells = new bool[2, 3, 3];

    // ...
}
#endregion INCLUDE

class TicTacToeBoardPreCSharp5
{
    public TicTacToeBoardPreCSharp5()
    {
        // Set both player's initial board to all false (blank)
        //    |   |
        // ---+---+---
        //    |   |   
        // ---+---+---
        //    |   |   
        _Cells = new bool[2, 3, 3];
    }

    private readonly bool[,,] _Cells;

    public bool[,,] Cells
    {
        get { return _Cells; }
    }

    // Error: A readonly field cannot be assigned to(except 
    // in a constructor or a variable initializer)
    // public void SetCells(bool[,,] value) =>
    // Cells = new bool[2, 3, 3];

    // ...
}
