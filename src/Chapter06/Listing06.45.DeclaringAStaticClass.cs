namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_45
{
    using System;
    using static SimpleMath;

    public static class SimpleMath
    {
        // params allows the number of parameters to vary
        public static int Max(params int[] numbers)
        {
            // Check that there is at least one item in numbers
            if(numbers.Length == 0)
            {
                // In C# 6.0 replace "numbers" with nameof(numbers)
                throw new ArgumentException(
                    "numbers cannot be empty", "numbers");
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
                // In C# 6.0 replace "numbers" with nameof(numbers)
                throw new ArgumentException(
                    "numbers cannot be empty", "numbers");
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
            for (int count = 0; count < args.Length; count++)
            {
                numbers[count] = args[count].Length;
            }

            Console.WriteLine(
                $@"Longest argument length = { Max(numbers) }");

            Console.WriteLine(
                $@"Shortest argument length = {
                    SimpleMath.Min(numbers) }");
        }
    }

}
