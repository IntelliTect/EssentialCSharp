namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_51;

using System;
using static SimpleMath;

#region INCLUDE
#region HIGHLIGHT
public static class SimpleMath
#endregion HIGHLIGHT
{
    // params֧�ֿɱ������Ĳ���
    public static int Max(params int[] numbers)
    {
        // ���numbers�������Ƿ�������һ��
        if(numbers.Length == 0)
        {
            throw new ArgumentException(
                "numbers���ܿհ�", nameof(numbers));
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

    // params֧�ֿɱ������Ĳ���
    public static int Min(params int[] numbers)
    {
        // ���numbers�������Ƿ�������һ��
        if (numbers.Length == 0)
        {
            throw new ArgumentException(
                "numbers���ܿհ�", nameof(numbers));
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
            $@"���ʵ�γ��� = {
                Max(numbers) }");

        Console.WriteLine(
            $@"��̵�ʵ�γ��� = {
                Min(numbers) }");
    }
}
#endregion INCLUDE
