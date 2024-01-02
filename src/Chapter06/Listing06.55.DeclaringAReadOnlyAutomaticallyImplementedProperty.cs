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
        // ע�⣺board.Cells����Ҫ��ʼ��
        TicTacToeBoard board = new();
        Console.WriteLine(board.Cells);
    }
}

#region INCLUDE
class TicTacToeBoard
{
    // ��������ҵĳ�ʼ������Ϊȫfalse (�հ�)
    //    |   |          |   |
    // ---+---+---    ---+---+---
    //    |   |          |   |   
    // ---+---+---    ---+---+---
    //    |   |          |   |   
    // ���1 - X      ��� 2 - O
    #region HIGHLIGHT
    public bool[,,] Cells { get; } = new bool[2, 3, 3];
    #endregion HIGHLIGHT
    // ���󣺲�����Cells���Ը�ֵ����Ϊ����ֻ����
    // public void SetCells(bool[,,] value) =>
    //         _Cells = new bool[2, 3, 3];

    // ...
}
#endregion INCLUDE

class TicTacToeBoardPreCSharp5
{
    public TicTacToeBoardPreCSharp5()
    {
        // ��������ҵĳ�ʼ������Ϊȫfalse (�հ�)
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
    
    // �����޷���ֻ���ֶθ�ֵ(����ͨ�����캯�����߱�����ʼ����)
    // public void SetCells(bool[,,] value) =>
    // Cells = new bool[2, 3, 3];

    // ...
}
