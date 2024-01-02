namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_51;

using System;
using static SimpleMath;

#region INCLUDE
#region HIGHLIGHT
public static class SimpleMath
#endregion HIGHLIGHT
{
    // params支持可变数量的参数
    public static int Max(params int[] numbers)
    {
        // 检查numbers数组中是否至少有一项
        if(numbers.Length == 0)
        {
            throw new ArgumentException(
                "numbers不能空白", nameof(numbers));
        }

        int result;
        result = numbers[0];
        foreach(int number in numbers)
        {
            if(number > result)
            {
                result = number;
            }
        }
        return result;
    }

    // params支持可变数量的参数
    public static int Min(params int[] numbers)
    {
        // 检查numbers数组中是否至少有一项
        if (numbers.Length == 0)
        {
            throw new ArgumentException(
                "numbers不能空白", nameof(numbers));
        }

        int result;
        result = numbers[0];
        foreach(int number in numbers)
        {
            if(number < result)
            {
                result = number;
            }
        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[args.Length];
        for (int index = 0; index < args.Length; index++)
        {
            numbers[index] = args[index].Length;
        }

        Console.WriteLine(
            $@"最长的实参长度 = {
                Max(numbers) }");

        Console.WriteLine(
            $@"最短的实参长度 = {
                Min(numbers) }");
    }
}
#endregion INCLUDE
