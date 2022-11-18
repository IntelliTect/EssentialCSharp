namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_04
{
    public class Program
    {
        public static void PatternMatchingIsNull(string? uri = null!)
        {
            // 1.
            if (uri is null) 
            {
                Console.WriteLine(
                    "Uri is null");
            }
            else
            {
                Console.WriteLine(
                    $"Uri is: {uri}");
            }
        }
        public static void PatternMatchingIsNotNull(string? uri = null)
        {
            // 2.
            if (uri is not null)
            {
                Console.WriteLine(
                    $"Uri is: {uri}");
            }
            else
            {
                Console.WriteLine(
                    "Uri is null");
            }
        }
        public static void EqualityInEqualityCheckForNull(string? uri = null)
        {
            // 3.
            if (uri == null)
            {
                Console.WriteLine(
                    "Uri is null");
            }

            if (uri != null)
            {
                Console.WriteLine(
                    $"Uri is: {uri}");
            }

        }
        public static void IsObject(string? uri = null!)
        {
            // 4.
            int number = 0;
            if ((uri is object)
                // Warning CS0183: The given
                // expression is always not
                // null.
                && (number is object)
            )
            {
                Console.WriteLine(
                    $"Uri is: {uri}");
            }
            else 
            {
                Console.WriteLine(
                    "Uri is null");
            }
        }
        public static void IsPatternMatching(string? uri = null!)
        {
            // 5.
            if (uri is { })
            {
                Console.WriteLine(
                    $"Uri is: {uri}");
            }
            else
            {
                Console.WriteLine(
                    "Uri is null");
            }
        }
        public static void ReferenceEqualsCheckForNotNull(string? uri = null)
        {
            // 6.
            if (ReferenceEquals(
              uri, null))
            {
                Console.WriteLine(
                    "Uri is null");
            }
            else
            {
                Console.WriteLine(
                    $"Uri is: {uri}");
            }
        }
    }
}
