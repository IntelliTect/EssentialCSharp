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
        // 注意：board.Cells不需要初始化
        TicTacToeBoard board = new();
        Console.WriteLine(board.Cells);
    }
}

#region INCLUDE
class TicTacToeBoard
{
    // 将两个玩家的初始棋盘设为全false (空白)
    //    |   |          |   |
    // ---+---+---    ---+---+---
    //    |   |          |   |   
    // ---+---+---    ---+---+---
    //    |   |          |   |   
    // 玩家1 - X      玩家 2 - O
    #region HIGHLIGHT
    public bool[,,] Cells { get; } = new bool[2, 3, 3];
    #endregion HIGHLIGHT
    // 错误：不能向Cells属性赋值，因为它是只读的
    // public void SetCells(bool[,,] value) =>
    //         _Cells = new bool[2, 3, 3];

    // ...
}
#endregion INCLUDE

class TicTacToeBoardPreCSharp5
{
    public TicTacToeBoardPreCSharp5()
    {
        // 将两个玩家的初始棋盘设为全false (空白)
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
    
    // 错误：无法向只读字段赋值(除非通过构造函数或者变量初始化器)
    // public void SetCells(bool[,,] value) =>
    // Cells = new bool[2, 3, 3];

    // ...
}
