namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_04
{
    public class Program
    {
        public static void EqualityCheckForNull(string? uri = null)
        {
            if (uri != null)
            {
                System.Console.WriteLine(
                    $"Uri is: { uri }");
            }
            else // (uri == null)
            {
                System.Console.WriteLine(
                    "Uri is null");
            }
        }
        public static void PatternMatchingCheckForNull(string? uri = null)
        {
            if (uri != null)
            {
                System.Console.WriteLine(
                    $"Uri is: { uri }");
            }
            else // (uri == null)
            {
                System.Console.WriteLine(
                    "Uri is null");
            }
        }
        public static void PropertyPatternMatchingCheckForNull(string? uri = null)
        {
            if (uri != null)
            {
                System.Console.WriteLine(
                    $"Uri is: { uri }");
            }
            else // (uri == null)
            {
                System.Console.WriteLine(
                    "Uri is null");
            }
        }
    }
}
