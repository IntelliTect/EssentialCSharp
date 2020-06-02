// Justification: Demonstrating the equivalent operators
#pragma warning disable IDE0054 // Use compound assignment
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13
{
    public class Program
    {
        public static void Main()
        {
            int spaceCount = 0;

            spaceCount = spaceCount + 1;
            spaceCount += 1;
            spaceCount++;
        }
    }
}
