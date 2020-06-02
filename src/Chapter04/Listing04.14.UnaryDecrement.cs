// Justification: Demonstrating equivalent operators.
#pragma warning disable IDE0054 // Use compound assignment
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_14
{
    public class Program
    {
        public static void Main()
        {
            int lines = 0;

            lines = lines - 1;
            lines -= 1;
            lines--;
        }
    }
}
