namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_51;

using System;
using static SimpleMath;

#region INCLUDE
#region HIGHLIGHT
public static class SimpleMath
#endregion HIGHLIGHT
{
    // params allows the number of parameters to vary
    public static int Max(params int[] numbers)
    {
        // Check that there is at least one item in numbers
        if(numbers.Length == 0)
        {
            throw new ArgumentException(
                "numbers cannot be empty", nameof(numbers));
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

    // params allows the number of parameters to vary
    public static int Min(params int[] numbers)
    {
        // Check that there is at least one item in numbers
        if(numbers.Length == 0)
        {
            throw new ArgumentException(
                "numbers cannot be empty", nameof(numbers));
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
            $@"Longest argument length = {
                Max(numbers) }");

        Console.WriteLine(
            $@"Shortest argument length = {
                Min(numbers) }");
    }
}
#endregion INCLUDE
