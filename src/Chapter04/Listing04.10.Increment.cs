// Justification: Demonstrating the without += just prior showing +=
#pragma warning disable IDE0054 // Use compound assignment
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_10
{
    public class Program
    {
        public static void Main()
        {
            int x = 123;
            x = x + 2;
        }
    }
}
