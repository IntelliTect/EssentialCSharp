namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_40
{
    using System;

    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("No output in this example");
        }
    }

    public static class SimpleMath
    {
        // params allows the number of parameters to vary.
        static int Max(params int[] numbers)
        {
            // Check that there is a least one item in numbers.
            if(numbers.Length == 0)
            {
                throw new ArgumentException(
                    "numbers cannot be empty");
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

        // params allows the number of parameters to vary.
        static int Min(params int[] numbers)
        {
            // Check that there is a least one item in numbers.
            if(numbers.Length == 0)
            {
                throw new ArgumentException(
                    "numbers cannot be empty");
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
}
