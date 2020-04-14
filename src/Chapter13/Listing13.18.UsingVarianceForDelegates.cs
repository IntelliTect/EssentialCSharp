// Justification: Left as lamda to elucidate generic types.
#pragma warning disable IDE0039 // Use local function
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_18
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Contravariance
            Action<object> broadAction =
                (object data) =>
                {
                    Console.WriteLine(data);
                };

            Action<string> narrowAction = broadAction;

            // Covariance
            Func<string> narrowFunction =
                () => Console.ReadLine();

            Func<object> broadFunction = narrowFunction;

            // Contravariance and covariance combined
            Func<object, string?> func1 =
                (object data) => data.ToString();

            Func<string, object?> func2 = func1;
        }
    }
}