
#define CSHARP2PLUS

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.TicTacToe;

using System;

#pragma warning disable 1030 // 禁止用户自定义警告

// TicTacToe类允许两个玩家玩井字棋游戏
public class TicTacToeGame      // 声明TicTacToeGame类
{
    public static void Main()  // 声明程序入口点
    {
        // 存储每个玩家的落子位置
        int[] playerPositions = { 0, 0 };

        // 最新将currentPlayer设为玩家1
        int currentPlayer = 1;

        // 获胜玩家
        int winner = 0;

        string input = "游戏开始!";

        // 显示棋盘，并提示当前玩家落子
        for(int turn = 1; turn <= 10; ++turn)
        {
            DisplayBoard(playerPositions);

            #region Check for End Game
            if(EndGame(winner, turn, input))
            {
                break;
            }
            #endregion Check for End Game

            input = NextMove(playerPositions, currentPlayer);

            winner = DetermineWinner(playerPositions);

            // 交换玩家
            currentPlayer = (currentPlayer == 2) ? 1 : 2;
        }
    }

    private static string NextMove(int[] playerPositions,
                   int currentPlayer)
    {
        string? input;

        // 反复提示玩家落子，直到输入一个有效的落子
        bool validMove;
        do
        {
            // 请求当前玩家落子
            System.Console.Write($"\n玩家{currentPlayer} - 输入落子位置:");
            // TODO: Update listing in Manuscript
            input = System.Console.ReadLine();
            validMove = ValidateAndMove(playerPositions,
                          currentPlayer, input);
        } while(!validMove);

        return input!;
    }

    static bool EndGame(int winner, int turn, string input)
    {
        bool endGame = false;
        if(winner > 0)
        {
            System.Console.WriteLine($"\nPlayer {winner} has won!!!!");
            endGame = true;
        }
        else if(turn == 10)
        {
            // 完成棋盘的第10次显示后，直接退出。
            // 而不是再次提示玩家落子。
            System.Console.WriteLine("\n平局!");
            endGame = true;
        }
        else if(input.Length == 0 || input == "quit")
        {
            // 检查是否没有输入任何字符就按Enter键，
            // 或者输入"quit"，这两者都表示退出
            System.Console.WriteLine("上一个玩家已退出。");
            endGame = true;
        }
        return endGame;
    }

    static int DetermineWinner(int[] playerPositions)
    {
        int winner = 0;

        // 判断是否出现了一个赢家.
        int[] winningMasks = {
      7, 56, 448, 73, 146, 292, 84, 273};

        foreach(int mask in winningMasks)
        {
            if((mask & playerPositions[0]) == mask)
            {
                winner = 1;
                break;
            }
            else if((mask & playerPositions[1]) == mask)
            {
                winner = 2;
                break;
            }
        }
        return winner;
    }

    static bool ValidateAndMove(
      int[] playerPositions, int currentPlayer, string? input)
    {
        bool valid = false;

        // 检查当前玩家的输入
        switch(input)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
#warning  "允许在同一个位置多次落子。"
                int shifter;   // 要移多少位来设置一个bit
                int position;  // 要设置的bit

                // int.Parse() 将"input"转换为整数。
                // 之所以要用"int.Parse(input) - 1"，是因为
                // 数组基于零。
                shifter = int.Parse(input) - 1;

                // 使掩码00000000000000000000000000000001
                // 移位单元格的位置。
                position = 1 << shifter;


                // 取当前玩家的单元格，并对它们进行
                // 按位或（OR）运算，以设置新的位置。
                // 由于currentPlayer要么是1，要么是2，
                // 因此要减去1，才能将currentPlayer
                // 用作零基数组的索引。
                playerPositions[currentPlayer - 1] |= position;

                valid = true;
                break;

            case null:
            case "quit":
                valid = true;
                break;

            case "":
            default:
                // 如果和其他case都不匹配，表明输入无效
                System.Console.WriteLine(
                    "\n错误:  输入1-9的值。 "
                    + "按Enter键退出。");
                break;
        }

        return valid;
    }

    static void DisplayBoard(int[] playerPositions)
    {
        // 代表一行中每个单元格之间的边框
        string[] borders = {
"|", "|", "\n---+---+---\n", "|", "|",
"\n---+---+---\n", "|", "|", ""
};

        // 显示当前棋盘
        int border = 0;  // 设置第一个边框，(border[0] = "|").

#if CSHARP2PLUS
        System.Console.Clear();
#endif

        for(int position = 1;
             position <= 256;
             position <<= 1, border++)
        {
            char token = CalculateToken(
                playerPositions, position);

            // 输出一个单元格值以及它之后的边框
            System.Console.Write($" {token} {borders[border]}");
        }
    }

    static char CalculateToken(
        int[] playerPositions, int position)
    {
        // 将和玩家对应的符号初始化为'X'和'O'
        char[] players = { 'X', 'O' };

        char token;
        // 如果玩家设置了那个位置，
        // 就将符号设为那个玩家的。
        if((position & playerPositions[0]) == position)
        {
            // 为玩家1标记那个位置
            token = players[0];
        }
        else if((position & playerPositions[1]) == position)
        {
            // 为玩家2标记那个位置
            token = players[1];
        }
        else
        {
            // 位置为空
            token = ' ';
        }
        return token;
    }

#line 113 "TicTacToe.cs"
    // 生成的代码放在这里
#line default
}