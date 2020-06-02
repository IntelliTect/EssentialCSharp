namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_37
{
    public class Program
    {
        public static void Main(params string[] args)
        {

            string[]? segments = null;

            // Not shown in manuscript since args won't be null in a normal Main method.
            segments = args;

            string? uri = null;

            int? length = segments?.Length;
            if (length is { } && length != 0)
            {
                uri = string.Join('/', segments!);
            }

            // Null-conditional with array accessor
            // uri = segments?[0];
                

            if (uri is null || length is 0)
            {
                System.Console.WriteLine(
                    "There were no segments to combine.");
            }
            else
            {
                System.Console.WriteLine(
                    $"Uri: { uri }");
            }
        }
    }
}
